namespace Klasses_recap
{
    partial class Oef01
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
            this.btnLeesTeller = new System.Windows.Forms.Button();
            this.btnVerhoog = new System.Windows.Forms.Button();
            this.btnVerminder = new System.Windows.Forms.Button();
            this.btnResetten = new System.Windows.Forms.Button();
            this.btnEinde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeesTeller
            // 
            this.btnLeesTeller.Location = new System.Drawing.Point(12, 12);
            this.btnLeesTeller.Name = "btnLeesTeller";
            this.btnLeesTeller.Size = new System.Drawing.Size(192, 23);
            this.btnLeesTeller.TabIndex = 0;
            this.btnLeesTeller.Text = "Lezen waarde teller";
            this.btnLeesTeller.UseVisualStyleBackColor = true;
            this.btnLeesTeller.Click += new System.EventHandler(this.btnLeesTeller_Click);
            // 
            // btnVerhoog
            // 
            this.btnVerhoog.Location = new System.Drawing.Point(12, 41);
            this.btnVerhoog.Name = "btnVerhoog";
            this.btnVerhoog.Size = new System.Drawing.Size(192, 23);
            this.btnVerhoog.TabIndex = 1;
            this.btnVerhoog.Text = "Verhoog teller met 1";
            this.btnVerhoog.UseVisualStyleBackColor = true;
            this.btnVerhoog.Click += new System.EventHandler(this.btnVerhoog_Click);
            // 
            // btnVerminder
            // 
            this.btnVerminder.Location = new System.Drawing.Point(12, 70);
            this.btnVerminder.Name = "btnVerminder";
            this.btnVerminder.Size = new System.Drawing.Size(192, 23);
            this.btnVerminder.TabIndex = 2;
            this.btnVerminder.Text = "Verminder teller met 1";
            this.btnVerminder.UseVisualStyleBackColor = true;
            this.btnVerminder.Click += new System.EventHandler(this.btnVerminder_Click);
            // 
            // btnResetten
            // 
            this.btnResetten.Location = new System.Drawing.Point(12, 99);
            this.btnResetten.Name = "btnResetten";
            this.btnResetten.Size = new System.Drawing.Size(192, 23);
            this.btnResetten.TabIndex = 3;
            this.btnResetten.Text = "Reset teller naar 0";
            this.btnResetten.UseVisualStyleBackColor = true;
            this.btnResetten.Click += new System.EventHandler(this.btnResetten_Click);
            // 
            // btnEinde
            // 
            this.btnEinde.Location = new System.Drawing.Point(12, 128);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(192, 23);
            this.btnEinde.TabIndex = 4;
            this.btnEinde.Text = "Einde";
            this.btnEinde.UseVisualStyleBackColor = true;
            this.btnEinde.Click += new System.EventHandler(this.btnEinde_Click);
            // 
            // Oef01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 183);
            this.Controls.Add(this.btnEinde);
            this.Controls.Add(this.btnResetten);
            this.Controls.Add(this.btnVerminder);
            this.Controls.Add(this.btnVerhoog);
            this.Controls.Add(this.btnLeesTeller);
            this.Name = "Oef01";
            this.Text = "Oef01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeesTeller;
        private System.Windows.Forms.Button btnVerhoog;
        private System.Windows.Forms.Button btnVerminder;
        private System.Windows.Forms.Button btnResetten;
        private System.Windows.Forms.Button btnEinde;
    }
}