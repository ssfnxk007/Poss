using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using POSS.Entity;
using POSS.BLL;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

namespace POSS
{
    public partial class text : Form
    {

        private Dictionary<string, string> columnNameAlias = new Dictionary<string, string>();//字段别名字典集合
        private System.Drawing.Printing.PrintDocument pintxiaopiaoCz;
        PosSetup possetup = new PosSetup();//POSS打印设置
        StringBuilder sb = new StringBuilder();
        public text()
        {
            InitializeComponent();
            // this.dataGridView1.AutoGenerateColumns = false;//禁止DataGridView自动加载数据列
           
            this.winGridView1.GridView1.DataSourceChanged += GridView1_DataSourceChanged;
        }

        private void GridView1_DataSourceChanged(object sender, EventArgs e)
        {
            pintxiaopiaoCz = new System.Drawing.Printing.PrintDocument();
            //MultipadPrintDocument print = new MultipadPrintDocument();//小票打印.分页
            //PrintDialog pd = new PrintDialog();
            //if (Productlist.Count == 1)
            //{
            //    print.Text = PrintText();
            //}
            //else
            //{
            //    print.Text = PrintText1();
            //}

            //print.Font = new Font("宋体", 9f);
            //print.DefaultPageSettings.Landscape = false;
            //int posMargin = 2;
            //print.DefaultPageSettings.Margins = new Margins(posMargin, posMargin, posMargin, posMargin);
            //print.PrinterSettings.PrinterName = this.possetup.PrintName;
            //print.PrintController = new StandardPrintController();

            //pd.Document = print;
            //print.Print();
            pintxiaopiaoCz = new System.Drawing.Printing.PrintDocument();
            pintxiaopiaoCz.PrintController = new StandardPrintController();//不出现正在打印框
            pintxiaopiaoCz.PrintPage += new PrintPageEventHandler(PintxiaopiaoCz_PrintPage);
            pintxiaopiaoCz.Print();
        }

        private void PintxiaopiaoCz_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            Font f = SystemFonts.DefaultFont;
            Brush fbrush = SystemBrushes.ControlText;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Near;
            if (Productlist.Count == 1)
            {
              string top=  PrintText();
              e.Graphics.DrawString(top.ToString(), f, fbrush, new Rectangle(3, 3, (int)(58 / 25.4) * 100, Height), sf);
            }else if (Productlist.Count > 1)
            {
                string min = PrintText1();
                e.Graphics.DrawString(min.ToString(), f, fbrush, new Rectangle(3, 3, (int)(58 / 25.4) * 100, Height), sf);
            }
        }

        private string PrintText()
        {
            string printtext = string.Empty;

            try
            {

                
                if (!string.IsNullOrEmpty(possetup.Tou1))
                {
                    sb.AppendLine(string.Format("{0}", possetup.Tou1).PadLeft(15, ' '));
                }
                if (!string.IsNullOrEmpty(possetup.Tou2))
                {
                    sb.AppendLine(string.Format("{0}", possetup.Tou2).PadLeft(15, ' '));
                }
                //sb.AppendLine(string.Format("单号：{0}", WanZhengLsInfo.Ls_id));
                sb.AppendLine(string.Format("品名 "));
                sb.AppendLine(string.Format("折扣   数量   售价   合计"));
                sb.AppendLine(string.Format("----------------------------"));
                
                
                //if (!string.IsNullOrEmpty(possetup.Wei1))
                //{
                //    sb.AppendLine(string.Format("{0}", possetup.Wei1));
                //}
                //if (!string.IsNullOrEmpty(possetup.Wei2))
                //{
                //    sb.AppendLine(string.Format("{0}", possetup.Wei2));
                //}
                //if (!string.IsNullOrEmpty(possetup.Wei3))
                //{
                //    sb.AppendLine(string.Format("{0}", possetup.Wei3));
                //}
                //if (!string.IsNullOrEmpty(possetup.Wei4))
                //{
                //    sb.AppendLine(string.Format("{0}", possetup.Wei4));
                //}

                //e.Graphics.DrawString(sb.ToString(), f, fbrush, new Rectangle(3, 3, (int)(58 / 25.4) * 100, Height), sf);//this.ClientRectangle
                printtext = sb.ToString();

            }
            catch (Exception ex)
            {
                MessagboxUit.ShowTips(ex.Message);
            }
            return printtext;

        }
        private string PrintText1()
        {
            StringBuilder sb = new StringBuilder();
            Font f = SystemFonts.DefaultFont;
            Brush fbrush = SystemBrushes.ControlText;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Near;
            foreach (var item in Productlist)
            {
                sb.AppendLine(string.Format("{0}", AutomaticLine(item.H_name, 22, 28)));
                sb.AppendLine(string.Format("{0}{1}{2}{3:c2}", string.Format("{0:0.00%}", item.H_output_discount_ls).PadRight(6, ' '), string.Format("  {0:n0}", item.H_amount).PadRight(6, ' '), string.Format("{0:c2}", item.H_output_price).PadRight(8, ' '), item.H_output_price * item.H_output_discount_ls * item.H_amount));
            }
            return sb.ToString();

        }
        public string AutomaticLine(string strOldText, int intLenMin, int intLenMax)
        {

            int intLength = 0;
            string strResult = "";

            //获取原字符串的字节长度    
            intLength = System.Text.Encoding.GetEncoding("gb2312").GetByteCount(strOldText);

            if (intLength > intLenMax)
            {
                //总字节数> 最长截取的最长字节数，    
                //则截取最长字节数, 然后对剩余字符串再处理    

                //获取字符串的UCS2码    
                byte[] bytes = System.Text.Encoding.Unicode.GetBytes(strOldText);
                //获取字符的实际截取位置    
                int intCutPos = RealCutPos(bytes, intLenMax);
                //采用递归调用    
                strResult = System.Text.Encoding.Unicode.GetString(bytes, 0, intCutPos * 2) + "\r\n" + AutomaticLine(Strings.Mid(strOldText, intCutPos + 1), intLenMin, intLenMax);

            }
            else if (intLength > intLenMin)
            {
                //如果 最长字节数 >总字节数 > 最短字节数，则 换行，并补齐空格到最短字节数位置    
                strResult = strOldText + "\r\n" + Strings.Space(intLenMin);

            }
            else
            {
                //如果 总字节数 < 最短字节数，则直接补齐空格到最短字节数的位置    
                strResult = strOldText + Strings.Space(intLenMin - intLength);
            }
            return strResult;
        }

        /// <summary>    
        /// 返回字符的实际截取位置    
        /// </summary>    
        /// <param name="bytes">UCS2码</param>    
        /// <param name="intLength">要截取的字节长度</param>    
        /// <returns></returns>    
        /// <remarks></remarks>    
        public int RealCutPos(byte[] bytes, int intLength)
        {
            //获取UCS2编码    
            int intCountB = 0;
            // 统计当前的字节数     
            int intCutPos = 0;
            //记录要截取字节的位置      

            while ((intCutPos < bytes.GetLength(0) && intCountB < intLength))
            {
                // 偶数位置，如0、2、4等，为UCS2编码中两个字节的第一个字节    
                if (intCutPos % 2 == 0)
                {
                    // 在UCS2第一个字节时，字节数加1    
                    intCountB += 1;
                }
                else
                {
                    // 当UCS2编码的第二个字节大于0时，该UCS2字符为汉字，一个汉字算两个字节    
                    if (bytes[intCutPos] > 0)
                    {
                        intCountB += 1;
                    }
                }
                intCutPos += 1;
            }

            // 如果intCutPos为奇数时，处理成偶数      
            if (intCutPos % 2 == 1)
            {
                // 该UCS2字符是汉字时，去掉这个截一半的汉字    
                if (bytes[intCutPos] > 0)
                {
                    intCutPos = intCutPos - 1;
                }
                else
                {
                    // 该UCS2字符是字母或数字，则保留该字符    
                    intCutPos = intCutPos + 1;
                }
            }

            return intCutPos / 2;
        }
        /// <summary>  
        /// 设置小票各部分的分隔线  
        /// </summary>  
        /// <param name="ticketwidth">小票的宽度，按照字符个数计算</param>  
        /// <param name="signChar">分隔线的样式</param>  
        /// <returns>小票的分隔线</returns>  
        private String CreateLine(int ticketwidth, Char signChar)
        {
            String result = String.Empty;
            try
            {
                for (int i = 0; i < ticketwidth; i++)
                {
                    result += signChar;
                }
                result += "\r\n";
            }
            catch (Exception ex)
            {
                LogTextHelper.Info(ex.Message);

            }


            return result;
        }

        public object TypeNames { get; private set; }

        private void text_Load(object sender, EventArgs e)
        {
            //DataGridViewTextBoxColumn dtEvent = new DataGridViewTextBoxColumn();
            //dtEvent.DataPropertyName = "eventMark";
            //dtEvent.HeaderText = "事件";
            //dataGridView1.Columns.Add(dtEvent);

            ////添加timeBlock项
            //DataGridViewTextBoxColumn dtTime = new DataGridViewTextBoxColumn();
            //dtTime.DataPropertyName = "timeBlock";
            //dtTime.HeaderText = "时间段";
            //dataGridView1.Columns.Add(dtTime);

            ////添加typeName项
            //DataGridViewComboBoxColumn dtType = new DataGridViewComboBoxColumn();
            //dtType.DataPropertyName = "typeName";
            //dtType.HeaderText = "类型";
            ////dtType.DataSource = TypeNames.GetTypeNames();//绑定combox显示的数据源
            //dataGridView1.Columns.Add(dtType);
            ////添加isComplete项
            //DataGridViewCheckBoxColumn dtCheck = new DataGridViewCheckBoxColumn();
            //dtCheck.DataPropertyName = "isComplete";
            //dtCheck.HeaderText = "状态";
            //dataGridView1.Columns.Add(dtCheck);
            set();
           
        }

        public Dictionary<string, string> AddColumnAlias(string key, string alias)
        {
            Dictionary<string, string> columnNameAlias = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(alias))
            {
                if (!columnNameAlias.ContainsKey(key.ToUpper()))
                {
                    columnNameAlias.Add(key.ToUpper(), alias);
                }
                else
                {
                    columnNameAlias[key.ToUpper()] = alias;
                }
            }
            return columnNameAlias;
        }
        public void set()
        {

            setxx(AddColumnAlias("h_isbn", "书号"));
            setxx(AddColumnAlias("h_name", "书名"));
            setxx(AddColumnAlias("h_price", "定价"));

        }
        string name = string.Empty;

        public void setxx(Dictionary<string, string> dic)
        {
            foreach (var item in dic)
            {
                //DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
                //name.DataPropertyName = item.Key;
                //name.HeaderText = item.Value;
                //dataGridView1.Columns.Add(name);
                
                   

                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
           
            splashScreenManager1.SetWaitFormCaption("");
            splashScreenManager1.SetWaitFormDescription("");
            Thread.Sleep(3000);
            splashScreenManager1.CloseWaitForm();
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind== DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                OpenFileDialog op = new OpenFileDialog();
                op.AutoUpgradeEnabled = true;
                op.CheckFileExists = true;
                op.CheckPathExists = true;
                op.ReadOnlyChecked = false;
                op.Multiselect = false;
                op.FileName = "";
                op.Filter = "所有文件|*.EXE";
                op.Title = "浏览";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    this.buttonEdit1.Text =    op.FileName;
                    this.txt_mid.Text = op.SafeFileName;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //FrmPosPrintPreview f = new FrmPosPrintPreview();
            //f.Show();

        }

        private void txt_mid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = this.txt_mid.Text.TrimEnd();
                text = text.Replace('　', ' ');
                text = text.Replace("'", "");
                string sqlwhere = string.Format(" and db_product.h_isbn = '{0}'", text);
                
                    SearchProductToOney(sqlwhere, "MMWY01000000232", "WY01", "50");
                    winGridView1.GridView1.RefreshData();
               
            }
            
        }
        List<SimpleProductInfo> Productlist = new List<SimpleProductInfo>();//全据商品列表
        List<SimpleProductInfo> SelectProductlist = new List<SimpleProductInfo>();//多打记录时 子窗体返回 选择商品列表
        List<SimpleProductInfo> xxlist = null;//一号多书判断重复所用
        private bool SearchProductToOney(string where, string m_id, string staton_iid, string WHC_Num)
        {
            this.Cursor = Cursors.WaitCursor;//改变鼠标样式
            bool result = false;
            List<SimpleProductInfo> list = null;
            List<SimpleProductInfo> infolist = new List<SimpleProductInfo>();//准备合并相当品种的 list
            string sqlwhere = string.Empty;
            sqlwhere = where;
            list = new List<SimpleProductInfo>();
            string mm_id = m_id;
            list = BLLFactory<Product>.Instance.Get_simpleproduct(sqlwhere, staton_iid, mm_id, WHC_Num);
            foreach (var item in list)
            {
                string k = BLLFactory<Product_discount_clientjb>.Instance.GetProduct_h_risediscount(item.H_id, "MMWY01000000232");
                if (!string.IsNullOrEmpty(k))
                {
                    item.H_output_discount_ls = k.ToDecimal();
                }
                else
                {
                    item.H_output_discount_ls = BLLFactory<Product>.Instance.GetMemberDiscountByProduct(item.H_id, "WY01", "MMWY01000000232", item.H_amount, item.H_output_price);
                }
                item.Ls_Sum = item.H_output_price * item.H_output_discount_ls * item.H_amount;
            }
            if (list.Count == 1)
            {
                infolist = Productlist;
                infolist.AddRange(list);
                Productlist = infolist;
                winGridView1.DataSource = null;
                winGridView1.DataSource = Productlist;
                //SetGeShi();
               
                //解决:扫码后光标跟到跑~！
                winGridView1.GridView1.MoveLast();
                result = true;
            }
            else if (list.Count == 0)
            {
                result = false;
                if (result == false && tb_isbn.Text.Trim().Length == 0)//判断用于条码查询
                {
                    MessagboxUit.ShowTips("没有检索到数据！");
                }
            }
            else if (list.Count > 1)
            {
                InputMoveProductInfo move = new InputMoveProductInfo();//多书目选择框
                move.MoveProductList = null;
                move.MoveProductList = list;
                move.ShowDialog();
                move.Dispose();
                this.SelectProductlist.Clear();
                this.SelectProductlist = move.MoveSelectedList;
                xxlist = new List<SimpleProductInfo>();//过读list
                                                       //TODO:多选结果 提示是否重复
                xxlist = Productlist;
                xxlist.AddRange(SelectProductlist);
                Productlist = xxlist;
                winGridView1.DataSource = null;
                winGridView1.DataSource = Productlist;
                //SetGeShi();
                
                //解决:扫码后光标跟到跑~！
                winGridView1.GridView1.MoveLast();
                result = true;
            }

            this.Cursor = Cursors.Default;

            return result;
        }

        
    }
}
