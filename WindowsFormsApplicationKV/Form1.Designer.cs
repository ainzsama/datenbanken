namespace WindowsFormsApplicationKV
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowData = new System.Windows.Forms.Button();
            this.comboBoxKurse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKursId = new System.Windows.Forms.TextBox();
            this.textBoxBez = new System.Windows.Forms.TextBox();
            this.textBoxDat = new System.Windows.Forms.TextBox();
            this.groupBoxKurse = new System.Windows.Forms.GroupBox();
            this.comboBoxTeiln = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTeilnId = new System.Windows.Forms.TextBox();
            this.textBoxNName = new System.Windows.Forms.TextBox();
            this.textBoxVName = new System.Windows.Forms.TextBox();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxKurse.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowData
            // 
            this.buttonShowData.Location = new System.Drawing.Point(27, 17);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(834, 33);
            this.buttonShowData.TabIndex = 0;
            this.buttonShowData.Text = "Daten anzeigen";
            this.buttonShowData.UseVisualStyleBackColor = true;
            // 
            // comboBoxKurse
            // 
            this.comboBoxKurse.FormattingEnabled = true;
            this.comboBoxKurse.Location = new System.Drawing.Point(46, 47);
            this.comboBoxKurse.Name = "comboBoxKurse";
            this.comboBoxKurse.Size = new System.Drawing.Size(207, 21);
            this.comboBoxKurse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bezeichnung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum";
            // 
            // textBoxKursId
            // 
            this.textBoxKursId.Location = new System.Drawing.Point(153, 99);
            this.textBoxKursId.Name = "textBoxKursId";
            this.textBoxKursId.Size = new System.Drawing.Size(100, 20);
            this.textBoxKursId.TabIndex = 5;
            // 
            // textBoxBez
            // 
            this.textBoxBez.Location = new System.Drawing.Point(153, 130);
            this.textBoxBez.Name = "textBoxBez";
            this.textBoxBez.Size = new System.Drawing.Size(100, 20);
            this.textBoxBez.TabIndex = 6;
            // 
            // textBoxDat
            // 
            this.textBoxDat.Location = new System.Drawing.Point(153, 159);
            this.textBoxDat.Name = "textBoxDat";
            this.textBoxDat.Size = new System.Drawing.Size(100, 20);
            this.textBoxDat.TabIndex = 7;
            // 
            // groupBoxKurse
            // 
            this.groupBoxKurse.BackColor = System.Drawing.Color.Khaki;
            this.groupBoxKurse.Controls.Add(this.textBoxDat);
            this.groupBoxKurse.Controls.Add(this.textBoxBez);
            this.groupBoxKurse.Controls.Add(this.textBoxKursId);
            this.groupBoxKurse.Controls.Add(this.label3);
            this.groupBoxKurse.Controls.Add(this.label2);
            this.groupBoxKurse.Controls.Add(this.label1);
            this.groupBoxKurse.Controls.Add(this.comboBoxKurse);
            this.groupBoxKurse.Location = new System.Drawing.Point(27, 103);
            this.groupBoxKurse.Name = "groupBoxKurse";
            this.groupBoxKurse.Size = new System.Drawing.Size(340, 268);
            this.groupBoxKurse.TabIndex = 8;
            this.groupBoxKurse.TabStop = false;
            this.groupBoxKurse.Text = "Kurse";
            // 
            // comboBoxTeiln
            // 
            this.comboBoxTeiln.FormattingEnabled = true;
            this.comboBoxTeiln.Location = new System.Drawing.Point(55, 47);
            this.comboBoxTeiln.Name = "comboBoxTeiln";
            this.comboBoxTeiln.Size = new System.Drawing.Size(207, 21);
            this.comboBoxTeiln.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nachname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vorname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "eMail";
            // 
            // textBoxTeilnId
            // 
            this.textBoxTeilnId.Location = new System.Drawing.Point(162, 99);
            this.textBoxTeilnId.Name = "textBoxTeilnId";
            this.textBoxTeilnId.Size = new System.Drawing.Size(100, 20);
            this.textBoxTeilnId.TabIndex = 14;
            // 
            // textBoxNName
            // 
            this.textBoxNName.Location = new System.Drawing.Point(162, 130);
            this.textBoxNName.Name = "textBoxNName";
            this.textBoxNName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNName.TabIndex = 15;
            // 
            // textBoxVName
            // 
            this.textBoxVName.Location = new System.Drawing.Point(162, 159);
            this.textBoxVName.Name = "textBoxVName";
            this.textBoxVName.Size = new System.Drawing.Size(100, 20);
            this.textBoxVName.TabIndex = 16;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(162, 188);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEMail.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LawnGreen;
            this.groupBox1.Controls.Add(this.textBoxEMail);
            this.groupBox1.Controls.Add(this.textBoxVName);
            this.groupBox1.Controls.Add(this.textBoxNName);
            this.groupBox1.Controls.Add(this.textBoxTeilnId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxTeiln);
            this.groupBox1.Location = new System.Drawing.Point(521, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 268);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 585);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxKurse);
            this.Controls.Add(this.buttonShowData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxKurse.ResumeLayout(false);
            this.groupBoxKurse.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.ComboBox comboBoxKurse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKursId;
        private System.Windows.Forms.TextBox textBoxBez;
        private System.Windows.Forms.TextBox textBoxDat;
        private System.Windows.Forms.GroupBox groupBoxKurse;
        private System.Windows.Forms.ComboBox comboBoxTeiln;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTeilnId;
        private System.Windows.Forms.TextBox textBoxNName;
        private System.Windows.Forms.TextBox textBoxVName;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

