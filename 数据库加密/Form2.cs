using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据库加密
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           string str1=  this.textEdit1.Text.Trim();
           string code= EncodeHelper.DesEncrypt(str1);
            try
            {
                FileStream fs = new FileStream("F:\\output\\License.Lib", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(code);//开始写入值
                sr.Close();
                fs.Close();
                MessageBox.Show("ok");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
