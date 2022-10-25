namespace scientific_calculator
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMult = new System.Windows.Forms.TextBox();
            this.btnmty = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.multplyList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMult);
            this.groupBox1.Controls.Add(this.btnmty);
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.multplyList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Number ";
            // 
            // txtMult
            // 
            this.txtMult.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMult.Location = new System.Drawing.Point(284, 137);
            this.txtMult.Name = "txtMult";
            this.txtMult.Size = new System.Drawing.Size(109, 36);
            this.txtMult.TabIndex = 2;
            // 
            // btnmty
            // 
            this.btnmty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmty.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmty.Location = new System.Drawing.Point(284, 203);
            this.btnmty.Name = "btnmty";
            this.btnmty.Size = new System.Drawing.Size(109, 48);
            this.btnmty.TabIndex = 1;
            this.btnmty.Text = "Multiply";
            this.btnmty.UseVisualStyleBackColor = false;
            this.btnmty.Click += new System.EventHandler(this.btnmty_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(284, 280);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(109, 48);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // multplyList
            // 
            this.multplyList.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multplyList.FormattingEnabled = true;
            this.multplyList.ItemHeight = 33;
            this.multplyList.Location = new System.Drawing.Point(2, 12);
            this.multplyList.Name = "multplyList";
            this.multplyList.Size = new System.Drawing.Size(257, 433);
            this.multplyList.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Multiplication";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmty;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ListBox multplyList;
        private System.Windows.Forms.TextBox txtMult;
        private System.Windows.Forms.Label label1;
    }
}