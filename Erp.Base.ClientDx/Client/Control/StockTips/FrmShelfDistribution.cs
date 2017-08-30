using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Erp.Base.UI
{
   public class FrmShelfDistribution:BaseForm
    {
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;

       private void InitializeComponent()
       {
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Location = new System.Drawing.Point(12, 48);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = true;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = true;
            this.winGridView1.ShowEditMenu = true;
            this.winGridView1.ShowExportButton = true;
            this.winGridView1.Size = new System.Drawing.Size(496, 326);
            this.winGridView1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "数据明细：";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(307, 16);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 22);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "打印";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(415, 16);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 22);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "确定";
            // 
            // FrmShelfDistribution
            // 
            this.ClientSize = new System.Drawing.Size(516, 400);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.winGridView1);
            this.Name = "FrmShelfDistribution";
            this.ResumeLayout(false);
            this.PerformLayout();

       }
   }
}
