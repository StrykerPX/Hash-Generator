namespace Hashing_Algorithm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.cmbb_hashType = new System.Windows.Forms.ComboBox();
            this.cmbb_output = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hash:";
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(397, 388);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 4;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(397, 359);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 5;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            // 
            // cmbb_hashType
            // 
            this.cmbb_hashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbb_hashType.FormattingEnabled = true;
            this.cmbb_hashType.Items.AddRange(new object[] {
            "SHA-256",
            "SHA-384",
            "SHA-512"});
            this.cmbb_hashType.Location = new System.Drawing.Point(316, 359);
            this.cmbb_hashType.Name = "cmbb_hashType";
            this.cmbb_hashType.Size = new System.Drawing.Size(75, 21);
            this.cmbb_hashType.TabIndex = 7;
            this.cmbb_hashType.SelectedIndexChanged += new System.EventHandler(this.cmbb_hashType_SelectedIndexChanged);
            // 
            // cmbb_output
            // 
            this.cmbb_output.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbb_output.FormattingEnabled = true;
            this.cmbb_output.Items.AddRange(new object[] {
            "Text",
            "Binary"});
            this.cmbb_output.Location = new System.Drawing.Point(235, 359);
            this.cmbb_output.Name = "cmbb_output";
            this.cmbb_output.Size = new System.Drawing.Size(75, 21);
            this.cmbb_output.TabIndex = 9;
            this.cmbb_output.SelectedIndexChanged += new System.EventHandler(this.cmbb_output_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(37, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(400, 149);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(37, 203);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(400, 149);
            this.textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 436);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbb_output);
            this.Controls.Add(this.cmbb_hashType);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hashing Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.ComboBox cmbb_hashType;
        private System.Windows.Forms.ComboBox cmbb_output;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

