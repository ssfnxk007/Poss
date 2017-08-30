namespace Cord
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_cord = new System.Windows.Forms.TextBox();
            this.l_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "冲 值 ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tb_cord
            // 
            this.tb_cord.Location = new System.Drawing.Point(116, 14);
            this.tb_cord.Name = "tb_cord";
            this.tb_cord.Size = new System.Drawing.Size(248, 21);
            this.tb_cord.TabIndex = 1;
            // 
            // l_text
            // 
            this.l_text.AutoSize = true;
            this.l_text.Location = new System.Drawing.Point(69, 17);
            this.l_text.Name = "l_text";
            this.l_text.Size = new System.Drawing.Size(41, 12);
            this.l_text.TabIndex = 2;
            this.l_text.Text = "卡号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "冲值金额：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "折扣率：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "备注：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 21);
            this.textBox3.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(276, 55);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 21);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(116, 54);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(104, 21);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 152);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_text);
            this.Controls.Add(this.tb_cord);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "冲值";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_cord;
        private System.Windows.Forms.Label l_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

