using CCWin;
using POSS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WHC.Framework.Commons;
using WxPayAPI;

namespace POSS
{
    public class FrmWeiXinZhiFu : CCSkinMain
    {
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_money;
        private DevExpress.XtraEditors.TextEdit text_code;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.IContainer components;
        public static WxDataEntity k = null;
        /// <summary>
        /// 待支付金额
        /// </summary>
        private decimal pay_money = 0.0m;

        /// <summary>
        /// 是否支付成功
        /// </summary>
        public static bool YesOrNo = false;
        WxPayData data = null;//微信支付接口类

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeiXinZhiFu));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lab_money = new System.Windows.Forms.Label();
            this.text_code = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.text_code.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "wx.bmp");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(81, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "支付金额：";
            // 
            // lab_money
            // 
            this.lab_money.AutoSize = true;
            this.lab_money.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_money.ForeColor = System.Drawing.Color.Red;
            this.lab_money.Location = new System.Drawing.Point(207, 28);
            this.lab_money.Name = "lab_money";
            this.lab_money.Size = new System.Drawing.Size(46, 21);
            this.lab_money.TabIndex = 0;
            this.lab_money.Text = "0.0";
            // 
            // text_code
            // 
            this.text_code.Location = new System.Drawing.Point(196, 61);
            this.text_code.Name = "text_code";
            this.text_code.Size = new System.Drawing.Size(243, 20);
            this.text_code.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(59, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "扫描微信码：";
            // 
            // FrmWeiXinZhiFu
            // 
            this.ClientSize = new System.Drawing.Size(516, 116);
            this.Controls.Add(this.text_code);
            this.Controls.Add(this.lab_money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWeiXinZhiFu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "微信支付";
            this.Load += new System.EventHandler(this.FrmWeiXinZhiFu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmWeiXinZhiFu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.text_code.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public FrmWeiXinZhiFu()
        {
            InitializeComponent();
            Portal.gc.loginUserInfo = Cache.Instance["loginUserInfo"] as LoginUserInfo;//取出缓存里的值
            Portal.gc.QPossConfig = Cache.Instance["QPossConfig"] as QueryPossConfig;

        }

        public static void ShowPay(decimal money)
        {
            FrmWeiXinZhiFu fw = new FrmWeiXinZhiFu();
            fw.pay_money = money;
            fw.ShowDialog();

        }

        private void FrmWeiXinZhiFu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;//关闭退出按件
            this.lab_money.Text =pay_money.ToString("#0.00");
        }

        private void WeiXinZhiFu()
        {
            string pay_money = lab_money.Text.Trim();
            string code = this.text_code.Text.Trim();
            if (!string.IsNullOrEmpty(pay_money) && !string.IsNullOrEmpty(code))
            {
                data = new WxPayData();
                data.SetValue("auth_code", code);
                data.SetValue("body", Portal.gc.QPossConfig.Wx_miaosu);
                data.SetValue("total_fee", int.Parse((decimal.Parse(pay_money) * 100).ToString("0")));
                data.SetValue("out_trade_no", WxPayApi.GenerateOutTradeNo());//产生随机的商户订单号
                WxPayData result = WxPayApi.Micropay(data, 10);
                k= new WxDataEntity();
                k = result.SetReturn();
                if (k.Err_code == "USERPAYING" && k.Return_code == "SUCCESS")
                {
                    MessagboxUit.ShowTips("等待用户输入密码！");
                    Thread.Sleep(5000);
                }
                //如果提交被扫支付接口调用失败，则抛异常
                if (!result.IsSet("return_code") || result.GetValue("return_code").ToString() == "FAIL")
                {
                    string returnMsg = result.IsSet("return_msg") ? result.GetValue("return_msg").ToString() : "";
                    MessagboxUit.ShowTips(returnMsg);
                    return;
                }
                //签名验证
                result.CheckSign();
                //刷卡支付直接成功
                if (result.GetValue("return_code").ToString() == "SUCCESS" &&
                    result.GetValue("result_code").ToString() == "SUCCESS")
                {
                    MessagboxUit.ShowTips("支付成功！");
                    this.text_code.Text = "";
                    this.lab_money.Text = "";

                    FrmWeiXinZhiFu.YesOrNo = true;
                    this.Close();
                    return;
                }
                /******************************************************************
                * 剩下的都是接口调用成功，业务失败的情况
                * ****************************************************************/
                //1）业务结果明确失败
                if (result.GetValue("err_code").ToString() != "USERPAYING" &&
                result.GetValue("err_code").ToString() != "SYSTEMERROR")
                {
                    MessagboxUit.ShowError(result.GetValue("err_code_des").ToString());
                    this.text_code.Text = "";
                    this.lab_money.Text = "";
                    FrmWeiXinZhiFu.YesOrNo = false;
                    this.Close();
                    return;
                }
                //2）不能确定是否失败，需查单
                //用商户订单号去查单
                string out_trade_no = data.GetValue("out_trade_no").ToString();

                //确认支付是否成功,每隔一段时间查询一次订单，共查询10次
                int queryTimes = 10;//查询次数计数器
                while (queryTimes-- > 0)
                {
                    int succResult = 0;//查询结果
                    WxPayData queryResult = Query(out_trade_no, out succResult);
                    //如果需要继续查询，则等待2s后继续
                    if (succResult == 2)
                    {
                        Thread.Sleep(2000);
                        continue;
                    }
                    //查询成功,返回订单查询接口返回的数据
                    else if (succResult == 1)
                    {
                        // Log.Debug("MicroPay", "Mircopay success, return order query result : " + queryResult.ToXml());
                        MessagboxUit.ShowTips("查询到订单！支付成功！");
                        this.text_code.Text = "";
                        this.lab_money.Text = "";
                        FrmWeiXinZhiFu.YesOrNo = true;
                        this.Close();
                        return;
                    }
                    //订单交易失败，直接返回刷卡支付接口返回的结果，失败原因会在err_code中描述
                    else
                    {
                        MessagboxUit.ShowError(queryResult.GetValue("trade_state_desc").ToString());
                        this.text_code.Text = "";
                        this.lab_money.Text = "";
                        FrmWeiXinZhiFu.YesOrNo = false;
                        this.Close();
                        return;

                    }
                }

                //确认失败，则撤销订单
                //Log.Error("MicroPay", "Micropay failure, Reverse order is processing...");
                if (!Cancel(out_trade_no))
                {
                    throw new WxPayException("撤销订单 失败！");
                }

            }

        }
        /**
            * 
            * 查询订单情况
            * @param string out_trade_no  商户订单号
            * @param int succCode         查询订单结果：0表示订单不成功，1表示订单成功，2表示继续查询
            * @return 订单查询接口返回的数据，参见协议接口
            */
        public static WxPayData Query(string out_trade_no, out int succCode)
        {
            WxPayData queryOrderInput = new WxPayData();
            queryOrderInput.SetValue("out_trade_no", out_trade_no);
            WxPayData result = WxPayApi.OrderQuery(queryOrderInput);

            if (result.GetValue("return_code").ToString() == "SUCCESS"
                && result.GetValue("result_code").ToString() == "SUCCESS")
            {
                //支付成功
                if (result.GetValue("trade_state").ToString() == "SUCCESS")
                {
                    succCode = 1;
                    return result;
                }
                //用户支付中，需要继续查询
                else if (result.GetValue("trade_state").ToString() == "USERPAYING")
                {
                    succCode = 2;
                    return result;
                }
                else if (result.GetValue("trade_state").ToString() == "PAYERROR")
                {
                    succCode = 9;
                    // MessageBox.Show(result.GetValue("trade_state_desc").ToString());
                    return result;
                }
                else if (result.GetValue("trade_state").ToString() == "REVOKED")
                {
                    succCode = 8;
                    // MessageBox.Show(result.GetValue("trade_state_desc").ToString());
                    return result;
                }
                else if (result.GetValue("trade_state").ToString() == "CLOSED")
                {
                    succCode = 7;
                    //MessageBox.Show(result.GetValue("trade_state_desc").ToString());
                    return result;
                }
                else if (result.GetValue("trade_state").ToString() == "NOTPAY")
                {
                    succCode = 6;
                    //MessageBox.Show(result.GetValue("trade_state_desc").ToString());
                    return result;
                }
                else if (result.GetValue("trade_state").ToString() == "NOTENOUGH")
                {
                    succCode = 5;
                    //MessageBox.Show(result.GetValue("trade_state_desc").ToString());
                    return result;
                }
            }


            //如果返回错误码为“此交易订单号不存在”则直接认定失败
            if (result.GetValue("err_code").ToString() == "ORDERNOTEXIST")
            {
                succCode = 0;
            }
            else
            {
                //如果是系统错误，则后续继续
                succCode = 2;
            }
            return result;
        }
        /**
       * 
       * 撤销订单，如果失败会重复调用10次
       * @param string out_trade_no 商户订单号
       * @param depth 调用次数，这里用递归深度表示
       * @return false表示撤销失败，true表示撤销成功
       */
        public static bool Cancel(string out_trade_no, int depth = 0)
        {
            if (depth > 10)
            {
                return false;
            }

            WxPayData reverseInput = new WxPayData();
            reverseInput.SetValue("out_trade_no", out_trade_no);
            WxPayData result = WxPayApi.Reverse(reverseInput);

            //接口调用失败
            if (result.GetValue("return_code").ToString() != "SUCCESS")
            {
                return false;
            }

            //如果结果为success且不需要重新调用撤销，则表示撤销成功
            if (result.GetValue("result_code").ToString() != "SUCCESS" && result.GetValue("recall").ToString() == "N")
            {
                return true;
            }
            else if (result.GetValue("recall").ToString() == "Y")
            {
                return Cancel(out_trade_no, ++depth);
            }
            return false;
        }

        private void text_code_EditValueChanged(object sender, EventArgs e)
        {
            bool k = Regex.IsMatch(this.text_code.Text.Trim(), @"^[+-]?\d*[.]?\d*$");
            if (k == false)
            {
                MessagboxUit.ShowError("不是数字");
            }
        }

        private void FrmWeiXinZhiFu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                WeiXinZhiFu();
                
            }
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                FrmWeiXinZhiFu.YesOrNo = false;
                this.Close();
            }
        }
    }
}

