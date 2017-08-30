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
namespace POSS
{
    public partial class text : Form
    {

        private Dictionary<string, string> columnNameAlias = new Dictionary<string, string>();//字段别名字典集合

     
        public text()
        {
            InitializeComponent();
           // this.dataGridView1.AutoGenerateColumns = false;//禁止DataGridView自动加载数据列
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
            this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Rows[0].Cells[0].ReadOnly = true;
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
                dataGridView1.Columns.Add(item.Key,item.Value);
                   

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
            FrmPosPrintPreview f = new FrmPosPrintPreview();
            f.Show();

        }

        private void txt_mid_KeyDown(object sender, KeyEventArgs e)
        {
            string text = this.txt_mid.Text.TrimEnd();
            text = text.Replace('　', ' ');
            text = text.Replace("'", "");
            string sqlwhere = string.Format(" and db_product.h_isbn = '{0}'", text);
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                MessagboxUit.ShowTips(text);
            }
        }
    }
}
