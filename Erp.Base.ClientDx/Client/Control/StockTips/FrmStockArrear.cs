using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Erp.Base.UI
{
   public class FrmStockArrear : BaseForm
    {
       private DevExpress.XtraEditors.LabelControl labelControl1;
       private WHC.Pager.WinControl.WinGridView winGridView1;
       private DevExpress.XtraEditors.SimpleButton simpleButton1;
       private DevExpress.XtraEditors.SimpleButton simpleButton2;
       private System.Windows.Forms.CheckBox checkBox1;
       private DevExpress.XtraEditors.MemoEdit textEdit1;


       private void InitializeComponent()
       {
            this.textEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "书号：9787305064807  商品名称：三字经-注音版  定价 1111 版别：南京大学";
            this.textEdit1.Location = new System.Drawing.Point(12, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Size = new System.Drawing.Size(586, 36);
            this.textEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "进项明细：";
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Location = new System.Drawing.Point(12, 74);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = true;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = true;
            this.winGridView1.ShowEditMenu = true;
            this.winGridView1.ShowExportButton = true;
            this.winGridView1.Size = new System.Drawing.Size(586, 234);
            this.winGridView1.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(349, 323);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "打印";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(454, 323);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "关闭";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 328);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 18);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "查看冲减完成";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FrmStockArrear
            // 
            this.ClientSize = new System.Drawing.Size(621, 351);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.winGridView1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit1);
            this.Name = "FrmStockArrear";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

       }

       private void simpleButton2_Click(object sender, EventArgs e)
       {
           this.Close();
       }
   }
}
