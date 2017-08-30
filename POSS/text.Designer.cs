namespace POSS
{
    partial class text
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::POSS.WaitFormSeach), true, true);
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_mid = new System.Windows.Forms.TextBox();
            this.productInput1 = new POSS.ProductInput();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(442, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(213, 323);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(259, 20);
            this.buttonEdit1.TabIndex = 2;
            this.buttonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(598, 240);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_mid
            // 
            this.txt_mid.Location = new System.Drawing.Point(813, 62);
            this.txt_mid.Name = "txt_mid";
            this.txt_mid.Size = new System.Drawing.Size(100, 21);
            this.txt_mid.TabIndex = 4;
            this.txt_mid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mid_KeyDown);
            // 
            // productInput1
            // 
            this.productInput1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.productInput1.Appearance.Options.UseBackColor = true;
            this.productInput1.Location = new System.Drawing.Point(503, 117);
            this.productInput1.M_id = null;
            this.productInput1.Name = "productInput1";
            this.productInput1.ReadOnly = false;
            this.productInput1.Size = new System.Drawing.Size(459, 45);
            this.productInput1.TabIndex = 5;
            // 
            // text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 431);
            this.Controls.Add(this.productInput1);
            this.Controls.Add(this.txt_mid);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.buttonEdit1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "text";
            this.Text = "text";
            this.Load += new System.EventHandler(this.text_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txt_mid;
        private ProductInput productInput1;
    }
}