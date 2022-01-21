namespace Week4Day5Demo
{
    partial class TestingForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(113, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(113, 271);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 65);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter number n";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 65;
            this.listBox1.Location = new System.Drawing.Point(774, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(581, 979);
            this.listBox1.TabIndex = 3;
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1367, 1047);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "TestingForm";
            this.Text = "My 1st Testing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}