using Aop.Api.Response;
using CCWin;
using Com.Alipay;
using Com.Alipay.Business;
using Com.Alipay.Domain;
using Com.Alipay.Model;
using POSS;
using POSS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WHC.Framework.Commons;

namespace POSS
{
   public class FrmZhiFuBao: CCSkinMain
    {
        private DevExpress.XtraEditors.TextEdit zfb_code;
        private System.Windows.Forms.Label zfb_money;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        /// <summary>
        /// 待支付金额
        /// </summary>
        private decimal pay_money = 0.0m;

        /// <summary>
        /// 是否支付成功
        /// </summary>
        public static bool YesOrNo = false;
        private void InitializeComponent()
        {
            this.zfb_code = new DevExpress.XtraEditors.TextEdit();
            this.zfb_money = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zfb_code.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // zfb_code
            // 
            this.zfb_code.Location = new System.Drawing.Point(172, 78);
            this.zfb_code.Name = "zfb_code";
            this.zfb_code.Size = new System.Drawing.Size(243, 20);
            this.zfb_code.TabIndex = 5;
            this.zfb_code.EditValueChanged += new System.EventHandler(this.zfb_code_EditValueChanged);
            this.zfb_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zfb_code_KeyDown);
            // 
            // zfb_money
            // 
            this.zfb_money.AutoSize = true;
            this.zfb_money.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zfb_money.ForeColor = System.Drawing.Color.Red;
            this.zfb_money.Location = new System.Drawing.Point(183, 45);
            this.zfb_money.Name = "zfb_money";
            this.zfb_money.Size = new System.Drawing.Size(46, 21);
            this.zfb_money.TabIndex = 2;
            this.zfb_money.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "扫描支付宝码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "支付金额：";
            // 
            // FrmZhiFuBao
            // 
            this.ClientSize = new System.Drawing.Size(450, 142);
            this.Controls.Add(this.zfb_code);
            this.Controls.Add(this.zfb_money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmZhiFuBao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "支付宝支付";
            this.Load += new System.EventHandler(this.FrmZhiFuBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zfb_code.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public FrmZhiFuBao()
        {
            InitializeComponent();
            Portal.gc.loginUserInfo = Cache.Instance["loginUserInfo"] as LoginUserInfo;//取出缓存里的值
            Portal.gc.QPossConfig = Cache.Instance["QPossConfig"] as QueryPossConfig;
            
        }

        private void FrmZhiFuBao_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;//关闭退出按件
            this.zfb_money.Text = pay_money.ToString("#0.00");
        }
        public static void ShowPay(decimal money)
        {
            FrmZhiFuBao fw = new FrmZhiFuBao();
            fw.pay_money = money;
            fw.ShowDialog();
        }

        /// <summary>
        /// 支付宝 条码支付
        /// </summary>
        private void ZhiFuBao()
        {
            IAlipayTradeService serviceClient = F2FBiz.CreateClientInstance(ZFBConfig.serverUrl, Portal.gc.QPossConfig.Zfb_appid, Portal.gc.QPossConfig.Zfb_merchant_private_key, ZFBConfig.version,
                ZFBConfig.sign_type, Portal.gc.QPossConfig.Zfb_alipay_public_key, ZFBConfig.charset);
            AlipayTradePayContentBuilder builder = BuildPayContent();
            string out_trade_no = builder.out_trade_no;
            AlipayF2FPayResult payResult = serviceClient.tradePay(builder);
            AlipayTradePayResponse kk = payResult.response;
            if (kk.Code == "10003")
            {
                this.Cursor = Cursors.WaitCursor;
                Thread.Sleep(10000);
                MessageBox.Show("用户输入密码");
                this.Cursor = Cursors.Default;

            }
            switch (payResult.Status)
            {
                case ResultEnum.SUCCESS:
                    DoSuccessProcess(payResult);
                    break;
                case ResultEnum.FAILED:
                    DoFailedProcess(payResult);
                    break;
                case ResultEnum.UNKNOWN:
                    MessageBox.Show("网络异常，请检查网络配置后，更换外部订单号重试");
                    break;
            }
        }
        /// <summary>
        /// 构造支付请求数据
        /// </summary>
        /// <returns>请求数据集</returns>
        private AlipayTradePayContentBuilder BuildPayContent()
        {
            //线上联调时，请输入真实的外部订单号。
            string out_trade_no = "";
            out_trade_no = System.DateTime.Now.ToString("yyyyMMddHHmmss") + "0000" + (new Random()).Next(1, 10000).ToString();//创建单号
            //扫码枪扫描到的用户手机钱包中的付款条码
            AlipayTradePayContentBuilder builder = new AlipayTradePayContentBuilder();

            //收款账号
            builder.seller_id = Portal.gc.QPossConfig.Zfb_pid;
            //订单编号
            builder.out_trade_no = Guid.NewGuid().ToString();
            //支付场景，无需修改
            builder.scene = "bar_code";
            //支付授权码,付款码
            builder.auth_code = this.zfb_code.Text.Trim();
            //订单总金额
            builder.total_amount = this.zfb_money.Text.Trim();
            //参与优惠计算的金额
            //builder.discountable_amount = "";
            //不参与优惠计算的金额
            //builder.undiscountable_amount = "";
            //订单名称
            builder.subject = Portal.gc.QPossConfig.Zfb_miaoshu;
            //自定义超时时间
            builder.timeout_express = "2m";
            //订单描述
            builder.body = "零售商品";
            //门店编号，很重要的参数，可以用作之后的营销
            builder.store_id = "门店";
            //操作员编号，很重要的参数，可以用作之后的营销
            builder.operator_id = "操作员：张三";


            //传入商品信息详情
            List<GoodsInfo> gList = new List<GoodsInfo>();

            GoodsInfo goods = new GoodsInfo();
            goods.goods_id = "304";
            goods.goods_name = Portal.gc.QPossConfig.Zfb_miaoshu;
            goods.price = zfb_money.Text.Trim();
            goods.quantity = "1";
            gList.Add(goods);
            builder.goods_detail = gList;

            //系统商接入可以填此参数用作返佣
            //ExtendParams exParam = new ExtendParams();
            //exParam.sysServiceProviderId = "20880000000000";
            //builder.extendParams = exParam;

            return builder;

        }
        /// <summary>
        /// 请添加支付成功后的处理
        /// </summary>
        private void DoSuccessProcess(AlipayF2FPayResult payResult)
        {
            AlipayTradePayResponse kk = payResult.response;
            if (kk.Code == "10000")
            {
                MessageBox.Show("成功！");
                FrmZhiFuBao.YesOrNo = true;
                this.Close();
            }
        }

        /// <summary>
        /// 请添加支付失败后的处理
        /// </summary>
        private void DoFailedProcess(AlipayF2FPayResult payResult)
        {
            AlipayTradePayResponse kk = payResult.response;
            MessageBox.Show(kk.SubMsg);
            FrmZhiFuBao.YesOrNo = false;
            this.Close();
        }

        private void zfb_code_EditValueChanged(object sender, EventArgs e)
        {
            bool k = Regex.IsMatch(this.zfb_code.Text.Trim(), @"^[+-]?\d*[.]?\d*$");
            if (k == false)
            {
                MessageBox.Show("不是数字");
            }
        }

        private void zfb_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                ZhiFuBao();
            }
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                FrmZhiFuBao.YesOrNo = false;
                this.Close();
            }
        }
    }
}
