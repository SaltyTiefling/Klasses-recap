namespace Klasses_recap
{
    partial class Oef02
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnVolumeUp = new System.Windows.Forms.Button();
            this.btnVolumeDown = new System.Windows.Forms.Button();
            this.btnKanaalMinus = new System.Windows.Forms.Button();
            this.btnKanaalPlus = new System.Windows.Forms.Button();
            this.numKanaal = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numKanaal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(120, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Volume: 05 Kanaal:BBC";
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolumeUp.Location = new System.Drawing.Point(12, 40);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(254, 23);
            this.btnVolumeUp.TabIndex = 1;
            this.btnVolumeUp.Text = "Volume up";
            this.btnVolumeUp.UseVisualStyleBackColor = true;
            this.btnVolumeUp.Click += new System.EventHandler(this.btnVolumeUp_Click);
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolumeDown.Location = new System.Drawing.Point(12, 69);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(254, 23);
            this.btnVolumeDown.TabIndex = 2;
            this.btnVolumeDown.Text = "Volume down";
            this.btnVolumeDown.UseVisualStyleBackColor = true;
            this.btnVolumeDown.Click += new System.EventHandler(this.btnVolumeDown_Click);
            // 
            // btnKanaalMinus
            // 
            this.btnKanaalMinus.Location = new System.Drawing.Point(7, 19);
            this.btnKanaalMinus.Name = "btnKanaalMinus";
            this.btnKanaalMinus.Size = new System.Drawing.Size(80, 23);
            this.btnKanaalMinus.TabIndex = 3;
            this.btnKanaalMinus.Text = "-";
            this.btnKanaalMinus.UseVisualStyleBackColor = true;
            this.btnKanaalMinus.Click += new System.EventHandler(this.btnKanaalMinus_Click);
            // 
            // btnKanaalPlus
            // 
            this.btnKanaalPlus.Location = new System.Drawing.Point(168, 19);
            this.btnKanaalPlus.Name = "btnKanaalPlus";
            this.btnKanaalPlus.Size = new System.Drawing.Size(80, 23);
            this.btnKanaalPlus.TabIndex = 4;
            this.btnKanaalPlus.Text = "+";
            this.btnKanaalPlus.UseVisualStyleBackColor = true;
            this.btnKanaalPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // numKanaal
            // 
            this.numKanaal.Location = new System.Drawing.Point(93, 22);
            this.numKanaal.Name = "numKanaal";
            this.numKanaal.Size = new System.Drawing.Size(69, 20);
            this.numKanaal.TabIndex = 5;
            this.numKanaal.ValueChanged += new System.EventHandler(this.numKanaal_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKanaalMinus);
            this.groupBox1.Controls.Add(this.btnKanaalPlus);
            this.groupBox1.Controls.Add(this.numKanaal);
            this.groupBox1.Location = new System.Drawing.Point(12, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kanaal";
            // 
            // Oef02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVolumeDown);
            this.Controls.Add(this.btnVolumeUp);
            this.Controls.Add(this.lblInfo);
            this.Name = "Oef02";
            this.Text = "Oef02";
            this.Load += new System.EventHandler(this.Oef02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKanaal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnVolumeUp;
        private System.Windows.Forms.Button btnVolumeDown;
        private System.Windows.Forms.Button btnKanaalMinus;
        private System.Windows.Forms.Button btnKanaalPlus;
        private System.Windows.Forms.NumericUpDown numKanaal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}