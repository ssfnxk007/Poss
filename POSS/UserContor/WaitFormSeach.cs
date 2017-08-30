using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS
{
   public class WaitFormSeach : WaitForm
    {
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ProgressPanel progressPanel1;

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.progressPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(232, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.Appearance.Options.UseFont = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.progressPanel1.Caption = "请等待....";
            this.progressPanel1.Description = "数据正在加载 ...";
            this.progressPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressPanel1.Location = new System.Drawing.Point(3, 3);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(226, 53);
            this.progressPanel1.TabIndex = 0;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // WaitFormSeach
            // 
            this.ClientSize = new System.Drawing.Size(232, 59);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WaitFormSeach";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private string caption = string.Empty;


        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }

        public WaitFormSeach()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }
        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(this.caption);
            this.progressPanel1.Caption =this. caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
        public enum WaitFormCommand
        {

        }
    }
}
