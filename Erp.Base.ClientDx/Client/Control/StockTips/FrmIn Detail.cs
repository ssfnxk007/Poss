using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Erp.Base.UI
{
   public class FrmIn_Detail:BaseForm
    {
        private WHC.Framework.Commons.DateTimeControl dateTimeControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit textEdit1;
        private DevExpress.XtraEditors.MemoEdit textEdit2;
        private WHC.Pager.WinControl.WinGridView winGridView1;
        private System.ComponentModel.IContainer components;


       private void InitializeComponent()
       {
            this.components = new System.ComponentModel.Container();
            this.dateTimeControl1 = new WHC.Framework.Commons.DateTimeControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.winGridView1 = new WHC.Pager.WinControl.WinGridView();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeControl1
            // 
            this.dateTimeControl1.ChineseColumnName = null;
            this.dateTimeControl1.ColumnName = null;
            this.dateTimeControl1.Location = new System.Drawing.Point(88, 338);
            this.dateTimeControl1.Name = "dateTimeControl1";
            this.dateTimeControl1.Size = new System.Drawing.Size(162, 20);
            this.dateTimeControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(388, 341);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "库房:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(40, 338);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "时段:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 14);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "出入库明细：";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(422, 338);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.NullText = "";
            this.textEdit1.Size = new System.Drawing.Size(140, 20);
            this.textEdit1.TabIndex = 4;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(25, 12);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(586, 36);
            this.textEdit2.TabIndex = 5;
            // 
            // winGridView1
            // 
            this.winGridView1.AppendedMenu = null;
            this.winGridView1.DataSource = null;
            this.winGridView1.DisplayColumns = "";
            this.winGridView1.Location = new System.Drawing.Point(22, 75);
            this.winGridView1.Name = "winGridView1";
            this.winGridView1.PrintTitle = "";
            this.winGridView1.ShowAddMenu = true;
            this.winGridView1.ShowCheckBox = false;
            this.winGridView1.ShowDeleteMenu = true;
            this.winGridView1.ShowEditMenu = true;
            this.winGridView1.ShowExportButton = true;
            this.winGridView1.Size = new System.Drawing.Size(589, 212);
            this.winGridView1.TabIndex = 6;
            // 
            // FrmIn_Detail
            // 
            this.ClientSize = new System.Drawing.Size(627, 370);
            this.Controls.Add(this.winGridView1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dateTimeControl1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.textEdit2);
            this.Name = "FrmIn_Detail";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

       }
   }
}
