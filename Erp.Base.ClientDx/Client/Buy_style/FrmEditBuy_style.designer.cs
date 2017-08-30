namespace WHC.Dictionary.UI
{
    partial class FrmEditBuy_style
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();                

            this.txtBuy_style_name = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
             this.txtLast_mod_date = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
             this.txtLast_trans_date = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
             this.txtNotrigger = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
             
            ((System.ComponentModel.ISupportInitialize)(this.picPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();

            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();            
            ((System.ComponentModel.ISupportInitialize)(this.txtBuy_style_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
             ((System.ComponentModel.ISupportInitialize)(this.txtLast_mod_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLast_mod_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
             ((System.ComponentModel.ISupportInitialize)(this.txtLast_trans_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLast_trans_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
             ((System.ComponentModel.ISupportInitialize)(this.txtNotrigger.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
             
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(438, 392);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(537, 392);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(351, 392);
            // 
            // layoutControl1
            //             
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Location = new System.Drawing.Point(12, 8);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(605, 363);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";

            this.layoutControl1.Controls.Add(this.txtBuy_style_name);
             this.layoutControl1.Controls.Add(this.txtLast_mod_date);
             this.layoutControl1.Controls.Add(this.txtLast_trans_date);
             this.layoutControl1.Controls.Add(this.txtNotrigger);
 
            // 
            // txtBuy_style_name
            // 
            this.txtBuy_style_name.Location = new System.Drawing.Point(112, 12);
            this.txtBuy_style_name.Name = "txtBuy_style_name";
            this.txtBuy_style_name.Size = new System.Drawing.Size(481, 20);
            this.txtBuy_style_name.StyleController = this.layoutControl1;
            this.txtBuy_style_name.TabIndex = 1;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtBuy_style_name;
            this.layoutControlItem1.CustomizationFormText = "";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(585, 24);
            this.layoutControlItem1.Text = "";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 14);  

             // 
            // txtLast_mod_date
            // 
            this.txtLast_mod_date.EditValue = null;
            this.txtLast_mod_date.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtLast_mod_date.Location = new System.Drawing.Point(112, 36);
            this.txtLast_mod_date.Name = "txtLast_mod_date";
            this.txtLast_mod_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLast_mod_date.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtLast_mod_date.Size = new System.Drawing.Size(481, 20);
            this.txtLast_mod_date.StyleController = this.layoutControl1;
            this.txtLast_mod_date.TabIndex = 2;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtLast_mod_date;
            this.layoutControlItem2.CustomizationFormText = "";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(585, 24);
            this.layoutControlItem2.Text = "";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(96, 14);  

             // 
            // txtLast_trans_date
            // 
            this.txtLast_trans_date.EditValue = null;
            this.txtLast_trans_date.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtLast_trans_date.Location = new System.Drawing.Point(112, 60);
            this.txtLast_trans_date.Name = "txtLast_trans_date";
            this.txtLast_trans_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLast_trans_date.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtLast_trans_date.Size = new System.Drawing.Size(481, 20);
            this.txtLast_trans_date.StyleController = this.layoutControl1;
            this.txtLast_trans_date.TabIndex = 3;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtLast_trans_date;
            this.layoutControlItem3.CustomizationFormText = "";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(585, 24);
            this.layoutControlItem3.Text = "";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(96, 14);  

             // 
            // txtNotrigger
            // 
            this.txtNotrigger.Location = new System.Drawing.Point(112, 84);
            this.txtNotrigger.Name = "txtNotrigger";
            this.txtNotrigger.Size = new System.Drawing.Size(481, 20);
            this.txtNotrigger.StyleController = this.layoutControl1;
            this.txtNotrigger.TabIndex = 4;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtNotrigger;
            this.layoutControlItem4.CustomizationFormText = "";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(585, 24);
            this.layoutControlItem4.Text = "";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(96, 14);  

 
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
	        this.layoutControlItem1
	 	       ,this.layoutControlItem2
	 	       ,this.layoutControlItem3
	 	       ,this.layoutControlItem4
	        });
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(605, 363);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;          

            // 
            // FrmEditBuy_style
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 427);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmEditBuy_style";
            this.Text = "Buy_style";
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.dataNavigator1, 0);
            this.Controls.SetChildIndex(this.picPrint, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);            
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.txtBuy_style_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();            
             ((System.ComponentModel.ISupportInitialize)(this.txtLast_mod_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();            
             ((System.ComponentModel.ISupportInitialize)(this.txtLast_trans_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();            
             ((System.ComponentModel.ISupportInitialize)(this.txtNotrigger.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();            
 
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;

        private DevExpress.XtraEditors.TextEdit txtBuy_style_name;
          private DevExpress.XtraEditors.DateEdit txtLast_mod_date;
          private DevExpress.XtraEditors.DateEdit txtLast_trans_date;
          private DevExpress.XtraEditors.TextEdit txtNotrigger;
  
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;    
         private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;    
         private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;    
         private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;    
 
    }
}