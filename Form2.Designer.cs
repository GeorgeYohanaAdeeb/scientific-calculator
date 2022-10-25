namespace scientific_calculator
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbKeliv = new System.Windows.Forms.RadioButton();
            this.rbFahToCel = new System.Windows.Forms.RadioButton();
            this.rbCelToFah = new System.Windows.Forms.RadioButton();
            this.lblConvert = new System.Windows.Forms.TextBox();
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.button42 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblConvert);
            this.groupBox1.Controls.Add(this.txtConvert);
            this.groupBox1.Controls.Add(this.button42);
            this.groupBox1.Controls.Add(this.button41);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 435);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.rbKeliv);
            this.groupBox2.Controls.Add(this.rbFahToCel);
            this.groupBox2.Controls.Add(this.rbCelToFah);
            this.groupBox2.Location = new System.Drawing.Point(20, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 165);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Temperature for Conversion";
            // 
            // rbKeliv
            // 
            this.rbKeliv.AutoSize = true;
            this.rbKeliv.Location = new System.Drawing.Point(13, 128);
            this.rbKeliv.Name = "rbKeliv";
            this.rbKeliv.Size = new System.Drawing.Size(95, 33);
            this.rbKeliv.TabIndex = 1;
            this.rbKeliv.TabStop = true;
            this.rbKeliv.Text = "Kelvin";
            this.rbKeliv.UseVisualStyleBackColor = true;
            this.rbKeliv.Enter += new System.EventHandler(this.rbKeliv_CheckedChanged);
            // 
            // rbFahToCel
            // 
            this.rbFahToCel.AutoSize = true;
            this.rbFahToCel.Location = new System.Drawing.Point(13, 80);
            this.rbFahToCel.Name = "rbFahToCel";
            this.rbFahToCel.Size = new System.Drawing.Size(248, 33);
            this.rbFahToCel.TabIndex = 2;
            this.rbFahToCel.TabStop = true;
            this.rbFahToCel.Text = " Fahrenheit to Celsius";
            this.rbFahToCel.UseVisualStyleBackColor = true;
            this.rbFahToCel.Enter += new System.EventHandler(this.rbFahToCel_CheckedChanged);
            // 
            // rbCelToFah
            // 
            this.rbCelToFah.AutoSize = true;
            this.rbCelToFah.Location = new System.Drawing.Point(12, 35);
            this.rbCelToFah.Name = "rbCelToFah";
            this.rbCelToFah.Size = new System.Drawing.Size(243, 33);
            this.rbCelToFah.TabIndex = 3;
            this.rbCelToFah.TabStop = true;
            this.rbCelToFah.Text = "Celsius to Fahrenheit";
            this.rbCelToFah.UseVisualStyleBackColor = true;
            this.rbCelToFah.Enter += new System.EventHandler(this.rbCelToFah_CheckedChanged);
            // 
            // lblConvert
            // 
            this.lblConvert.Location = new System.Drawing.Point(351, 305);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(133, 36);
            this.lblConvert.TabIndex = 3;
            // 
            // txtConvert
            // 
            this.txtConvert.Location = new System.Drawing.Point(351, 73);
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(133, 36);
            this.txtConvert.TabIndex = 3;
            // 
            // button42
            // 
            this.button42.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button42.Location = new System.Drawing.Point(340, 372);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(109, 48);
            this.button42.TabIndex = 2;
            this.button42.Text = "Reset";
            this.button42.UseVisualStyleBackColor = false;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button41
            // 
            this.button41.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button41.Location = new System.Drawing.Point(123, 372);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(109, 48);
            this.button41.TabIndex = 2;
            this.button41.Text = "Convert";
            this.button41.UseVisualStyleBackColor = false;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result of Converted Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Value to Convert";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Temperature";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbKeliv;
        private System.Windows.Forms.RadioButton rbFahToCel;
        private System.Windows.Forms.RadioButton rbCelToFah;
        private System.Windows.Forms.TextBox lblConvert;
        private System.Windows.Forms.TextBox txtConvert;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}