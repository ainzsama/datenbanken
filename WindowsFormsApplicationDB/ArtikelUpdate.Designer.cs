namespace WindowsFormsApplicationDB
{
    partial class ArtikelUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNr = new System.Windows.Forms.TextBox();
            this.textBoxGruppe = new System.Windows.Forms.TextBox();
            this.textBoxBez = new System.Windows.Forms.TextBox();
            this.textBoxBestand = new System.Windows.Forms.TextBox();
            this.textBoxMeldeBestand = new System.Windows.Forms.TextBox();
            this.textBoxVerpackung = new System.Windows.Forms.TextBox();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.textBoxLetzteEntnahme = new System.Windows.Forms.TextBox();
            this.buttonAendern = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artikelgruppe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bezeichnung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bestand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Meldebestand";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Verpackung";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Verkaufspreis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "letzte Entnahme";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(209, 58);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 9;
            // 
            // textBoxNr
            // 
            this.textBoxNr.Location = new System.Drawing.Point(209, 84);
            this.textBoxNr.Name = "textBoxNr";
            this.textBoxNr.Size = new System.Drawing.Size(100, 20);
            this.textBoxNr.TabIndex = 10;
            this.textBoxNr.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNr_Validating);
            // 
            // textBoxGruppe
            // 
            this.textBoxGruppe.Location = new System.Drawing.Point(209, 110);
            this.textBoxGruppe.Name = "textBoxGruppe";
            this.textBoxGruppe.Size = new System.Drawing.Size(100, 20);
            this.textBoxGruppe.TabIndex = 11;
            this.textBoxGruppe.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxGruppe_Validating);
            // 
            // textBoxBez
            // 
            this.textBoxBez.Location = new System.Drawing.Point(209, 136);
            this.textBoxBez.Name = "textBoxBez";
            this.textBoxBez.Size = new System.Drawing.Size(100, 20);
            this.textBoxBez.TabIndex = 12;
            // 
            // textBoxBestand
            // 
            this.textBoxBestand.Location = new System.Drawing.Point(209, 162);
            this.textBoxBestand.Name = "textBoxBestand";
            this.textBoxBestand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBestand.TabIndex = 13;
            this.textBoxBestand.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBestand_Validating);
            // 
            // textBoxMeldeBestand
            // 
            this.textBoxMeldeBestand.Location = new System.Drawing.Point(209, 188);
            this.textBoxMeldeBestand.Name = "textBoxMeldeBestand";
            this.textBoxMeldeBestand.Size = new System.Drawing.Size(100, 20);
            this.textBoxMeldeBestand.TabIndex = 14;
            this.textBoxMeldeBestand.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMeldeBestand_Validating);
            // 
            // textBoxVerpackung
            // 
            this.textBoxVerpackung.Location = new System.Drawing.Point(209, 214);
            this.textBoxVerpackung.Name = "textBoxVerpackung";
            this.textBoxVerpackung.Size = new System.Drawing.Size(100, 20);
            this.textBoxVerpackung.TabIndex = 15;
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.Location = new System.Drawing.Point(209, 240);
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.Size = new System.Drawing.Size(100, 20);
            this.textBoxPreis.TabIndex = 16;
            this.textBoxPreis.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPreis_Validating);
            // 
            // textBoxLetzteEntnahme
            // 
            this.textBoxLetzteEntnahme.Location = new System.Drawing.Point(209, 266);
            this.textBoxLetzteEntnahme.Name = "textBoxLetzteEntnahme";
            this.textBoxLetzteEntnahme.Size = new System.Drawing.Size(100, 20);
            this.textBoxLetzteEntnahme.TabIndex = 17;
            this.textBoxLetzteEntnahme.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLetzteEntnahme_Validating);
            // 
            // buttonAendern
            // 
            this.buttonAendern.Location = new System.Drawing.Point(97, 360);
            this.buttonAendern.Name = "buttonAendern";
            this.buttonAendern.Size = new System.Drawing.Size(101, 39);
            this.buttonAendern.TabIndex = 18;
            this.buttonAendern.Text = "Ändern";
            this.buttonAendern.UseVisualStyleBackColor = true;
            this.buttonAendern.Click += new System.EventHandler(this.buttonAendern_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(239, 360);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 39);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ArtikelUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 474);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAendern);
            this.Controls.Add(this.textBoxLetzteEntnahme);
            this.Controls.Add(this.textBoxPreis);
            this.Controls.Add(this.textBoxVerpackung);
            this.Controls.Add(this.textBoxMeldeBestand);
            this.Controls.Add(this.textBoxBestand);
            this.Controls.Add(this.textBoxBez);
            this.Controls.Add(this.textBoxGruppe);
            this.Controls.Add(this.textBoxNr);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArtikelUpdate";
            this.Text = "ArtikelUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNr;
        private System.Windows.Forms.TextBox textBoxGruppe;
        private System.Windows.Forms.TextBox textBoxBez;
        private System.Windows.Forms.TextBox textBoxBestand;
        private System.Windows.Forms.TextBox textBoxMeldeBestand;
        private System.Windows.Forms.TextBox textBoxVerpackung;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.TextBox textBoxLetzteEntnahme;
        private System.Windows.Forms.Button buttonAendern;
        private System.Windows.Forms.Button buttonCancel;
    }
}