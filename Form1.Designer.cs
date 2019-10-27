namespace DLCMayJune
{
    partial class formDLC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDLC));
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonDirection = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.boxCurrency = new System.Windows.Forms.ComboBox();
            this.boxInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.boxOutput = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConvert
            // 
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(13, 13);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(158, 45);
            this.buttonConvert.TabIndex = 0;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonDirection
            // 
            this.buttonDirection.Location = new System.Drawing.Point(13, 65);
            this.buttonDirection.Name = "buttonDirection";
            this.buttonDirection.Size = new System.Drawing.Size(158, 23);
            this.buttonDirection.TabIndex = 1;
            this.buttonDirection.Text = "Toggle conversion direction";
            this.buttonDirection.UseVisualStyleBackColor = true;
            this.buttonDirection.Click += new System.EventHandler(this.buttonDirection_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(13, 95);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(158, 23);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.Text = "About DLC";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // boxCurrency
            // 
            this.boxCurrency.FormattingEnabled = true;
            this.boxCurrency.Items.AddRange(new object[] {
            "US dollar (USD)",
            "Euro (EUR)",
            "British pound (GBP)",
            "Russian ruble (RUB)",
            "Serbian dinar (RSD)",
            "Swedish krona (SEK)",
            "Canadian dollar (CAD)",
            "Australian dollar (AUD)",
            "Chinese yuan (CNY)",
            "Japanese yen (JPY)"});
            this.boxCurrency.Location = new System.Drawing.Point(13, 125);
            this.boxCurrency.Name = "boxCurrency";
            this.boxCurrency.Size = new System.Drawing.Size(158, 21);
            this.boxCurrency.TabIndex = 3;
            this.boxCurrency.Text = "Select currency...";
            // 
            // boxInput
            // 
            this.boxInput.Location = new System.Drawing.Point(177, 13);
            this.boxInput.Name = "boxInput";
            this.boxInput.Size = new System.Drawing.Size(150, 20);
            this.boxInput.TabIndex = 4;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(174, 36);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(129, 13);
            this.labelInput.TabIndex = 5;
            this.labelInput.Text = "Input in selected currency";
            // 
            // boxOutput
            // 
            this.boxOutput.Location = new System.Drawing.Point(177, 126);
            this.boxOutput.Name = "boxOutput";
            this.boxOutput.ReadOnly = true;
            this.boxOutput.Size = new System.Drawing.Size(150, 20);
            this.boxOutput.TabIndex = 6;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(174, 105);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(86, 13);
            this.labelOutput.TabIndex = 7;
            this.labelOutput.Text = "Output in lemons";
            // 
            // formDLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 160);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.boxOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.boxInput);
            this.Controls.Add(this.boxCurrency);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonDirection);
            this.Controls.Add(this.buttonConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formDLC";
            this.Text = "Digitised Lemon Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonDirection;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.ComboBox boxCurrency;
        private System.Windows.Forms.TextBox boxInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox boxOutput;
        private System.Windows.Forms.Label labelOutput;
    }
}

