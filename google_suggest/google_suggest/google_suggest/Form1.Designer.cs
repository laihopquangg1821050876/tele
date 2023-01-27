namespace google_suggest
{
    partial class Form1
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
            this.btnGetsuggest = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetsuggest
            // 
            this.btnGetsuggest.Location = new System.Drawing.Point(357, 11);
            this.btnGetsuggest.Name = "btnGetsuggest";
            this.btnGetsuggest.Size = new System.Drawing.Size(80, 23);
            this.btnGetsuggest.TabIndex = 0;
            this.btnGetsuggest.Text = "Get suggest";
            this.btnGetsuggest.UseVisualStyleBackColor = true;
            this.btnGetsuggest.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(72, 12);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(261, 20);
            this.txtKeyword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keywords:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 44);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(425, 205);
            this.txtResult.TabIndex = 3;
            this.txtResult.Text = "";
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(492, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(437, 206);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(837, 11);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(90, 22);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Đăng blog";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 261);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.btnGetsuggest);
            this.Name = "Form1";
            this.Text = "quét keyWord";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetsuggest;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnUpload;
    }
}

