namespace LatinTranslator
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
            this.btnSinisterLeft = new System.Windows.Forms.Button();
            this.btnDexterRight = new System.Windows.Forms.Button();
            this.btnMediumCenter = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSinisterLeft
            // 
            this.btnSinisterLeft.Location = new System.Drawing.Point(12, 33);
            this.btnSinisterLeft.Name = "btnSinisterLeft";
            this.btnSinisterLeft.Size = new System.Drawing.Size(75, 23);
            this.btnSinisterLeft.TabIndex = 0;
            this.btnSinisterLeft.Text = "Sinister";
            this.btnSinisterLeft.UseVisualStyleBackColor = true;
            this.btnSinisterLeft.Click += new System.EventHandler(this.btnSinisterLeft_Click);
            // 
            // btnDexterRight
            // 
            this.btnDexterRight.Location = new System.Drawing.Point(103, 33);
            this.btnDexterRight.Name = "btnDexterRight";
            this.btnDexterRight.Size = new System.Drawing.Size(75, 23);
            this.btnDexterRight.TabIndex = 1;
            this.btnDexterRight.Text = "Dexter";
            this.btnDexterRight.UseVisualStyleBackColor = true;
            this.btnDexterRight.Click += new System.EventHandler(this.btnDexterRight_Click);
            // 
            // btnMediumCenter
            // 
            this.btnMediumCenter.Location = new System.Drawing.Point(197, 33);
            this.btnMediumCenter.Name = "btnMediumCenter";
            this.btnMediumCenter.Size = new System.Drawing.Size(75, 23);
            this.btnMediumCenter.TabIndex = 2;
            this.btnMediumCenter.Text = "Medium";
            this.btnMediumCenter.UseVisualStyleBackColor = true;
            this.btnMediumCenter.Click += new System.EventHandler(this.btnMediumCenter_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResult.Location = new System.Drawing.Point(0, 80);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(283, 16);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Press one of the buttons.";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnMediumCenter);
            this.Controls.Add(this.btnDexterRight);
            this.Controls.Add(this.btnSinisterLeft);
            this.Name = "Form1";
            this.Text = "Latin Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSinisterLeft;
        private System.Windows.Forms.Button btnDexterRight;
        private System.Windows.Forms.Button btnMediumCenter;
        private System.Windows.Forms.Label lblResult;
    }
}

