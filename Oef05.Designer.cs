namespace Klasses_recap
{
    partial class Oef05
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
            this.cbxKlassen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtGeboortedatum = new System.Windows.Forms.DateTimePicker();
            this.gbGeslacht = new System.Windows.Forms.GroupBox();
            this.tbxAnderGeslacht = new System.Windows.Forms.TextBox();
            this.rbAndere = new System.Windows.Forms.RadioButton();
            this.rbVrouw = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gbGeslacht.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxKlassen
            // 
            this.cbxKlassen.FormattingEnabled = true;
            this.cbxKlassen.Location = new System.Drawing.Point(48, 19);
            this.cbxKlassen.Name = "cbxKlassen";
            this.cbxKlassen.Size = new System.Drawing.Size(190, 21);
            this.cbxKlassen.TabIndex = 0;
            this.cbxKlassen.SelectedIndexChanged += new System.EventHandler(this.cbxKlassen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "klas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbGeslacht);
            this.groupBox1.Controls.Add(this.dtGeboortedatum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNaam);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "student";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(51, 19);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(169, 20);
            this.txtNaam.TabIndex = 0;
            // 
            // lbxStudents
            // 
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.Location = new System.Drawing.Point(12, 287);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(226, 147);
            this.lbxStudents.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(163, 258);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "geboortedatum:";
            // 
            // dtGeboortedatum
            // 
            this.dtGeboortedatum.Location = new System.Drawing.Point(13, 65);
            this.dtGeboortedatum.MaxDate = new System.DateTime(2020, 8, 17, 0, 0, 0, 0);
            this.dtGeboortedatum.Name = "dtGeboortedatum";
            this.dtGeboortedatum.Size = new System.Drawing.Size(200, 20);
            this.dtGeboortedatum.TabIndex = 4;
            this.dtGeboortedatum.Value = new System.DateTime(2020, 8, 17, 0, 0, 0, 0);
            // 
            // gbGeslacht
            // 
            this.gbGeslacht.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbGeslacht.Controls.Add(this.tbxAnderGeslacht);
            this.gbGeslacht.Controls.Add(this.rbAndere);
            this.gbGeslacht.Controls.Add(this.rbVrouw);
            this.gbGeslacht.Controls.Add(this.rbMan);
            this.gbGeslacht.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbGeslacht.Location = new System.Drawing.Point(13, 91);
            this.gbGeslacht.Name = "gbGeslacht";
            this.gbGeslacht.Size = new System.Drawing.Size(200, 100);
            this.gbGeslacht.TabIndex = 5;
            this.gbGeslacht.TabStop = false;
            this.gbGeslacht.Text = "Geslacht:";
            // 
            // tbxAnderGeslacht
            // 
            this.tbxAnderGeslacht.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.tbxAnderGeslacht.Location = new System.Drawing.Point(73, 68);
            this.tbxAnderGeslacht.Name = "tbxAnderGeslacht";
            this.tbxAnderGeslacht.Size = new System.Drawing.Size(100, 20);
            this.tbxAnderGeslacht.TabIndex = 4;
            // 
            // rbAndere
            // 
            this.rbAndere.AutoSize = true;
            this.rbAndere.Location = new System.Drawing.Point(7, 68);
            this.rbAndere.Name = "rbAndere";
            this.rbAndere.Size = new System.Drawing.Size(62, 17);
            this.rbAndere.TabIndex = 3;
            this.rbAndere.Text = "Andere:";
            this.rbAndere.UseVisualStyleBackColor = true;
            // 
            // rbVrouw
            // 
            this.rbVrouw.AutoSize = true;
            this.rbVrouw.Location = new System.Drawing.Point(7, 44);
            this.rbVrouw.Name = "rbVrouw";
            this.rbVrouw.Size = new System.Drawing.Size(55, 17);
            this.rbVrouw.TabIndex = 2;
            this.rbVrouw.Text = "Vrouw";
            this.rbVrouw.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Checked = true;
            this.rbMan.Location = new System.Drawing.Point(7, 20);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(46, 17);
            this.rbMan.TabIndex = 1;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // Oef05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 467);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lbxStudents);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxKlassen);
            this.Name = "Oef05";
            this.Text = "Oef05";
            this.Load += new System.EventHandler(this.Oef05_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGeslacht.ResumeLayout(false);
            this.gbGeslacht.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxKlassen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.GroupBox gbGeslacht;
        private System.Windows.Forms.TextBox tbxAnderGeslacht;
        private System.Windows.Forms.RadioButton rbAndere;
        private System.Windows.Forms.RadioButton rbVrouw;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.DateTimePicker dtGeboortedatum;
    }
}