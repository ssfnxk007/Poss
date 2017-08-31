namespace POSS
{
    partial class JiaoBanForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.t_xianjin = new DevExpress.XtraEditors.TextEdit();
            this.t_yujao = new DevExpress.XtraEditors.TextEdit();
            this.t_oper = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.t_feiyong = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.t_beizhu = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_xianjin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_yujao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_oper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_feiyong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_beizhu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(379, 178);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.t_beizhu);
            this.layoutControl1.Controls.Add(this.t_feiyong);
            this.layoutControl1.Controls.Add(this.t_xianjin);
            this.layoutControl1.Controls.Add(this.t_yujao);
            this.layoutControl1.Controls.Add(this.t_oper);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(375, 174);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // t_xianjin
            // 
            this.t_xianjin.Location = new System.Drawing.Point(99, 60);
            this.t_xianjin.Name = "t_xianjin";
            this.t_xianjin.Properties.Mask.EditMask = "n2";
            this.t_xianjin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.t_xianjin.Size = new System.Drawing.Size(264, 20);
            this.t_xianjin.StyleController = this.layoutControl1;
            this.t_xianjin.TabIndex = 6;
            // 
            // t_yujao
            // 
            this.t_yujao.Enabled = false;
            this.t_yujao.Location = new System.Drawing.Point(99, 36);
            this.t_yujao.Name = "t_yujao";
            this.t_yujao.Properties.Mask.EditMask = "n2";
            this.t_yujao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.t_yujao.Size = new System.Drawing.Size(264, 20);
            this.t_yujao.StyleController = this.layoutControl1;
            this.t_yujao.TabIndex = 5;
            // 
            // t_oper
            // 
            this.t_oper.Enabled = false;
            this.t_oper.Location = new System.Drawing.Point(99, 12);
            this.t_oper.Name = "t_oper";
            this.t_oper.Size = new System.Drawing.Size(264, 20);
            this.t_oper.StyleController = this.layoutControl1;
            this.t_oper.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(375, 174);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.t_oper;
            this.layoutControlItem1.CustomizationFormText = "交款人：";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(355, 24);
            this.layoutControlItem1.Text = "交款人：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(84, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.t_yujao;
            this.layoutControlItem2.CustomizationFormText = "预备零钱金额：";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(355, 24);
            this.layoutControlItem2.Text = "预备零钱金额：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(84, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.t_xianjin;
            this.layoutControlItem3.CustomizationFormText = "实收现金金额：";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(355, 24);
            this.layoutControlItem3.Text = "实收现金金额：";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(84, 14);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton2);
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 134);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(379, 44);
            this.panelControl2.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(247, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "取 消";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(66, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "交 班";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // t_feiyong
            // 
            this.t_feiyong.Location = new System.Drawing.Point(99, 84);
            this.t_feiyong.Name = "t_feiyong";
            this.t_feiyong.Size = new System.Drawing.Size(264, 20);
            this.t_feiyong.StyleController = this.layoutControl1;
            this.t_feiyong.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.t_feiyong;
            this.layoutControlItem4.CustomizationFormText = "费用:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(355, 24);
            this.layoutControlItem4.Text = "费用:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(84, 14);
            // 
            // t_beizhu
            // 
            this.t_beizhu.Location = new System.Drawing.Point(99, 108);
            this.t_beizhu.Name = "t_beizhu";
            this.t_beizhu.Size = new System.Drawing.Size(264, 20);
            this.t_beizhu.StyleController = this.layoutControl1;
            this.t_beizhu.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.t_beizhu;
            this.layoutControlItem5.CustomizationFormText = "备注:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(355, 58);
            this.layoutControlItem5.Text = "备注:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(84, 14);
            // 
            // JiaoBanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 178);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JiaoBanForm";
            this.Text = "交班";
            this.Load += new System.EventHandler(this.JiaoBanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_xianjin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_yujao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_oper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_feiyong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_beizhu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit t_xianjin;
        private DevExpress.XtraEditors.TextEdit t_yujao;
        private DevExpress.XtraEditors.TextEdit t_oper;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit t_beizhu;
        private DevExpress.XtraEditors.TextEdit t_feiyong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}