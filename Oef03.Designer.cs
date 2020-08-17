namespace Klasses_recap
{
    partial class Oef03
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
            this.cbxVak = new System.Windows.Forms.ComboBox();
            this.numPunten = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbxPunten = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGemiddelde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPunten)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxVak
            // 
            this.cbxVak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxVak.FormattingEnabled = true;
            this.cbxVak.Location = new System.Drawing.Point(12, 12);
            this.cbxVak.Name = "cbxVak";
            this.cbxVak.Size = new System.Drawing.Size(197, 21);
            this.cbxVak.TabIndex = 0;
            this.cbxVak.SelectedIndexChanged += new System.EventHandler(this.cbxVak_SelectedIndexChanged);
            // 
            // numPunten
            // 
            this.numPunten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPunten.Location = new System.Drawing.Point(13, 40);
            this.numPunten.Name = "numPunten";
            this.numPunten.Size = new System.Drawing.Size(114, 20);
            this.numPunten.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(134, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 20);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbxPunten
            // 
            this.lbxPunten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxPunten.FormattingEnabled = true;
            this.lbxPunten.Location = new System.Drawing.Point(13, 67);
            this.lbxPunten.Name = "lbxPunten";
            this.lbxPunten.Size = new System.Drawing.Size(196, 238);
            this.lbxPunten.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(13, 351);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(196, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gemiddelde:";
            // 
            // lblGemiddelde
            // 
            this.lblGemiddelde.AutoSize = true;
            this.lblGemiddelde.Location = new System.Drawing.Point(82, 308);
            this.lblGemiddelde.Name = "lblGemiddelde";
            this.lblGemiddelde.Size = new System.Drawing.Size(19, 13);
            this.lblGemiddelde.TabIndex = 6;
            this.lblGemiddelde.Text = "00";
            // 
            // Oef03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 386);
            this.Controls.Add(this.lblGemiddelde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbxPunten);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numPunten);
            this.Controls.Add(this.cbxVak);
            this.Name = "Oef03";
            this.Text = "Oef03";
            this.Load += new System.EventHandler(this.Oef03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPunten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxVak;
        private System.Windows.Forms.NumericUpDown numPunten;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxPunten;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGemiddelde;
    }
}