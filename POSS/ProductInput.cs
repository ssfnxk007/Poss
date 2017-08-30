using DevExpress.XtraEditors;
using POSS.BLL;
using POSS.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
namespace POSS
{
   public class ProductInput: XtraUserControl
    {
        #region 变量
        private TextBoxControls t_isbn;
        private System.Windows.Forms.Label label2;
        private TextBoxControls t_helper;
        private System.Windows.Forms.Label label3;
        private TextBoxControls t_name;
        private PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private IContainer components;//容器
        private bool readOnly = false;
        private List<SimpleProductInfo> selectedProducts = new List<SimpleProductInfo>();//选择的商品列表

        private INIFileUtil iniFile = new INIFileUtil(DirectoryUtil.GetCurrentDirectory() + @"\Values.ini");

        private SearchCondition seach = new SearchCondition();
        private SqlOperator currentOperator = SqlOperator.Like;

        private string strWhere = string.Empty;

        private string where = string.Empty;

        private string station_id = string.Empty;
        private string tiaoshu = string.Empty;
        /// <summary>
        /// 商品检索线程
        /// </summary>
        private BackgroundWorker seachPorductBackgroundWorker = null;
        #endregion
        /// <summary>
        /// 只读
        /// </summary>
        public bool ReadOnly
        {
            get { return readOnly; }
            set
            {
                readOnly = value;
            }
        }
        

        /// <summary>
        /// 已选择的商品列表
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public List<SimpleProductInfo> SelectedProducts
        {
            get { return selectedProducts; }
            set { selectedProducts = value; }
        }
        /// <summary>
        /// 会员编号
        /// </summary>
        public string M_id
        {
            get;set;
        }




        private void InitializeComponent()
        {
            this.t_isbn = new POSS.TextBoxControls();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_helper = new POSS.TextBoxControls();
            this.label3 = new System.Windows.Forms.Label();
            this.t_name = new POSS.TextBoxControls();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_isbn
            // 
            this.t_isbn.ChineseColumnName = null;
            this.t_isbn.ColumnName = "";
            this.t_isbn.CurrentOperator = null;
            this.t_isbn.Location = new System.Drawing.Point(1, 17);
            this.t_isbn.Name = "t_isbn";
            this.t_isbn.Size = new System.Drawing.Size(150, 22);
            this.t_isbn.TabIndex = 0;
            this.t_isbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_isbn_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "书号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "谐音：";
            // 
            // t_helper
            // 
            this.t_helper.ChineseColumnName = null;
            this.t_helper.ColumnName = "";
            this.t_helper.CurrentOperator = null;
            this.t_helper.Location = new System.Drawing.Point(153, 17);
            this.t_helper.MinimumSize = new System.Drawing.Size(145, 20);
            this.t_helper.Name = "t_helper";
            this.t_helper.Size = new System.Drawing.Size(150, 22);
            this.t_helper.TabIndex = 3;
            this.t_helper.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_helper_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "书名：";
            // 
            // t_name
            // 
            this.t_name.ChineseColumnName = null;
            this.t_name.ColumnName = "";
            this.t_name.CurrentOperator = null;
            this.t_name.Location = new System.Drawing.Point(305, 17);
            this.t_name.MinimumSize = new System.Drawing.Size(145, 20);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(150, 22);
            this.t_name.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.t_name);
            this.panelControl1.Controls.Add(this.t_isbn);
            this.panelControl1.Controls.Add(this.t_helper);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Location = new System.Drawing.Point(1, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(455, 42);
            this.panelControl1.TabIndex = 4;
            // 
            // ProductInput
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.Controls.Add(this.panelControl1);
            this.Name = "ProductInput";
            this.Size = new System.Drawing.Size(459, 45);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        public ProductInput()
        {
            InitializeComponent();
        }

        private void t_helper_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (readOnly) return;
            if(e.KeyCode==System.Windows.Forms.Keys.Enter && !string.IsNullOrEmpty(t_helper.Text))
            {
                this.strWhere = Syntax_like(t_helper.Text, "  db_product.my_help_input", "谐音");
                
                where = string.Format(" and {0}", strWhere);

                SeachProduct(where);
                this.t_helper.ResetText();
            }
        }
        private void t_isbn_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (readOnly) return;
            if (e.KeyCode == System.Windows.Forms.Keys.Enter && !string.IsNullOrEmpty(t_isbn.Text))
            {
                this.strWhere = Syntax_LikeStartAt(t_isbn.Text, "  db_product.h_isbn", "书号");

                where = string.Format(" and {0}", strWhere);

                SeachProduct(where);
                this.t_isbn.ResetText();
            }
        }
        /// <summary>
        /// 检索商品
        /// </summary>
        /// <param name="sqlWhere">检索条件</param>
        private void SeachProduct(string sqlWhere)
        {
            if (string.IsNullOrWhiteSpace(sqlWhere)) return;
            this.selectedProducts.Clear();//清空检索商品列表
            //selectedProducts=BLLFactory<Product>.Instance.Get_simpleproduct()
            seachPorductBackgroundWorker = new BackgroundWorker();
            seachPorductBackgroundWorker.DoWork += SeachPorductBackgroundWorker_DoWork;
            seachPorductBackgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// 后台检索商品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeachPorductBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //SetstationOrtiaoshu();
            //TODO:这里正试用了要 解开
            station_id = "WY01";
            tiaoshu = "20";
            if (!string.IsNullOrWhiteSpace(station_id))
            {
                selectedProducts = BLLFactory<Product>.Instance.Get_simpleproduct(string.Format("{0} ", where), station_id, M_id, tiaoshu);
                if (selectedProducts.Count == 1)
                {

                }else if (selectedProducts.Count > 1)
                {

                }

            }
            
        }
        private void SetstationOrtiaoshu()
        {
            try
            {
                station_id = Portal.gc.loginUserInfo.Station_ID;
                tiaoshu = Portal.gc.QPossConfig.Taosu;
            }
            catch (Exception ex)
            {
                MessagboxUit.ShowError(ex.Message.ToString());
            }
        }

        /// <summary>
        /// 获取SQLWhere
        /// </summary>
        /// <param name="valse"></param>
        /// <param name="columnName"></param>
        /// <param name="chineseColumnName"></param>
        /// <returns></returns>
        private string Syntax_like(string valse, string columnName,string chineseColumnName)
        {
            seach.ConditionTable.Clear();
            if (string.IsNullOrWhiteSpace(valse))
                return string.Empty;
            string result = string.Empty;
            string text = valse.TrimEnd();
            text = text.Replace('　', ' ');
            text = text.Replace("'", "");
            string[] value = text.Split(' ');
            foreach (string s in value)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    seach.AddCondition(columnName, chineseColumnName, s, SqlOperator.Like);
                }
            }
            result = seach.BuildConditionSqlNoWhere(DatabaseType.SqlServer);
            return result;

        }
        private string Syntax_Equal(string valse, string columnName, string chineseColumnName)
        {
            seach.ConditionTable.Clear();
            if (string.IsNullOrWhiteSpace(valse))
                return string.Empty;
            string result = string.Empty;
            string text = valse.TrimEnd();
            text = text.Replace('　', ' ');
            text = text.Replace("'", "");
            string[] value = text.Split(' ');
            foreach (string s in value)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    seach.AddCondition(columnName, chineseColumnName, s, SqlOperator.Equal);
                }
            }
            result = seach.BuildConditionSqlNoWhere(DatabaseType.SqlServer);
            return result;

        }
        private string Syntax_LikeStartAt(string valse, string columnName, string chineseColumnName)
        {
            seach.ConditionTable.Clear();
            if (string.IsNullOrWhiteSpace(valse))
                return string.Empty;
            string result = string.Empty;
            string text = valse.TrimEnd();
            text = text.Replace('　', ' ');
            text = text.Replace("'", "");
            string[] value = text.Split(' ');
            foreach (string s in value)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    seach.AddCondition(columnName, chineseColumnName, s, SqlOperator.LikeStartAt);
                }
            }
            result = seach.BuildConditionSqlNoWhere(DatabaseType.SqlServer);
            return result;

        }
    }
}
