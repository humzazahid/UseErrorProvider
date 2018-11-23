namespace UseErrorProvider
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmptyString = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumericString = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAlphaString = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAlphaNumericString = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSpecialChars = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtRegExString = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtRangeValidation = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtMinLengthTest = new System.Windows.Forms.TextBox();
            this.btnValidateAll = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmptyString);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empty String Test";
            // 
            // txtEmptyString
            // 
            this.txtEmptyString.Location = new System.Drawing.Point(22, 35);
            this.txtEmptyString.Name = "txtEmptyString";
            this.txtEmptyString.Size = new System.Drawing.Size(172, 20);
            this.txtEmptyString.TabIndex = 0;
            this.txtEmptyString.Validated += new System.EventHandler(this.txtEmptyString_Validated);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumericString);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numeric String Test";
            // 
            // txtNumericString
            // 
            this.txtNumericString.Location = new System.Drawing.Point(22, 35);
            this.txtNumericString.Name = "txtNumericString";
            this.txtNumericString.Size = new System.Drawing.Size(172, 20);
            this.txtNumericString.TabIndex = 1;
            this.txtNumericString.Validated += new System.EventHandler(this.txtNumericString_Validated);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAlphaString);
            this.groupBox3.Location = new System.Drawing.Point(12, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 78);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alpha String Test";
            // 
            // txtAlphaString
            // 
            this.txtAlphaString.Location = new System.Drawing.Point(22, 35);
            this.txtAlphaString.Name = "txtAlphaString";
            this.txtAlphaString.Size = new System.Drawing.Size(172, 20);
            this.txtAlphaString.TabIndex = 2;
            this.txtAlphaString.Validated += new System.EventHandler(this.txtAlphaString_Validated);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAlphaNumericString);
            this.groupBox4.Location = new System.Drawing.Point(248, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 78);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alphanumeric String Test";
            // 
            // txtAlphaNumericString
            // 
            this.txtAlphaNumericString.Location = new System.Drawing.Point(22, 35);
            this.txtAlphaNumericString.Name = "txtAlphaNumericString";
            this.txtAlphaNumericString.Size = new System.Drawing.Size(172, 20);
            this.txtAlphaNumericString.TabIndex = 4;
            this.txtAlphaNumericString.Validated += new System.EventHandler(this.txtAlphaNumericString_Validated);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSpecialChars);
            this.groupBox5.Location = new System.Drawing.Point(248, 96);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 78);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Special Characters String Test";
            // 
            // txtSpecialChars
            // 
            this.txtSpecialChars.Location = new System.Drawing.Point(22, 35);
            this.txtSpecialChars.Name = "txtSpecialChars";
            this.txtSpecialChars.Size = new System.Drawing.Size(172, 20);
            this.txtSpecialChars.TabIndex = 5;
            this.txtSpecialChars.Validated += new System.EventHandler(this.txtSpecialChars_Validated);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtRegExString);
            this.groupBox6.Location = new System.Drawing.Point(248, 180);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(230, 78);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Regular Expression String Test";
            // 
            // txtRegExString
            // 
            this.txtRegExString.Location = new System.Drawing.Point(22, 35);
            this.txtRegExString.Name = "txtRegExString";
            this.txtRegExString.Size = new System.Drawing.Size(172, 20);
            this.txtRegExString.TabIndex = 6;
            this.txtRegExString.Validated += new System.EventHandler(this.txtRegExString_Validated);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(367, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtRangeValidation);
            this.groupBox7.Location = new System.Drawing.Point(12, 264);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(230, 78);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Range Validation Test";
            // 
            // txtRangeValidation
            // 
            this.txtRangeValidation.Location = new System.Drawing.Point(22, 35);
            this.txtRangeValidation.Name = "txtRangeValidation";
            this.txtRangeValidation.Size = new System.Drawing.Size(172, 20);
            this.txtRangeValidation.TabIndex = 3;
            this.txtRangeValidation.Validated += new System.EventHandler(this.txtRangeValidation_Validated);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtMinLengthTest);
            this.groupBox8.Location = new System.Drawing.Point(248, 264);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(230, 78);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Minimum Length String Test";
            // 
            // txtMinLengthTest
            // 
            this.txtMinLengthTest.Location = new System.Drawing.Point(22, 35);
            this.txtMinLengthTest.Name = "txtMinLengthTest";
            this.txtMinLengthTest.Size = new System.Drawing.Size(172, 20);
            this.txtMinLengthTest.TabIndex = 7;
            this.txtMinLengthTest.Validated += new System.EventHandler(this.txtMinLengthTest_Validated);
            // 
            // btnValidateAll
            // 
            this.btnValidateAll.Location = new System.Drawing.Point(286, 355);
            this.btnValidateAll.Name = "btnValidateAll";
            this.btnValidateAll.Size = new System.Drawing.Size(75, 23);
            this.btnValidateAll.TabIndex = 9;
            this.btnValidateAll.Text = "Validate All";
            this.btnValidateAll.UseVisualStyleBackColor = true;
            this.btnValidateAll.Click += new System.EventHandler(this.btnValidateAll_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 390);
            this.Controls.Add(this.btnValidateAll);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Using the Error Provider";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmptyString;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtRegExString;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSpecialChars;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAlphaNumericString;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAlphaString;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumericString;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtMinLengthTest;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtRangeValidation;
        private System.Windows.Forms.Button btnValidateAll;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

