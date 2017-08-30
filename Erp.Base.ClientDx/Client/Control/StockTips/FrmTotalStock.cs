using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Erp.Base.UI.Client.Control.StockTips
{
    public class FrmTotalStock : BaseForm
    {
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.MemoEdit textEdit1;
    
        private void InitializeComponent()
        {
            this.textEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
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
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Location = new System.Drawing.Point(12, 54);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = true;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = true;
            this.winGridView1.ShowEditMenu = true;
            this.winGridView1.ShowExportButton = true;
            this.winGridView1.Size = new System.Drawing.Size(586, 212);
            this.winGridView1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(308, 321);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "架分布";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(417, 321);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "出入明细";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(513, 321);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "关闭";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(214, 321);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(71, 23);
            this.simpleButton4.TabIndex = 5;
            this.simpleButton4.Text = "进出冲减";
            // 
            // FrmTotalStock
            // 
            this.ClientSize = new System.Drawing.Size(617, 356);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.winGridView1);
            this.Controls.Add(this.textEdit1);
            this.Name = "FrmTotalStock";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
