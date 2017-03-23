namespace WindowsFormsApplicationDB
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
            this.buttonCon = new System.Windows.Forms.Button();
            this.buttonCom = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.listBoxSaetze = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArtGr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCon
            // 
            this.buttonCon.Location = new System.Drawing.Point(126, 60);
            this.buttonCon.Name = "buttonCon";
            this.buttonCon.Size = new System.Drawing.Size(75, 23);
            this.buttonCon.TabIndex = 0;
            this.buttonCon.Text = "Connect";
            this.buttonCon.UseVisualStyleBackColor = true;
            this.buttonCon.Click += new System.EventHandler(this.buttonCon_Click);
            // 
            // buttonCom
            // 
            this.buttonCom.Enabled = false;
            this.buttonCom.Location = new System.Drawing.Point(126, 89);
            this.buttonCom.Name = "buttonCom";
            this.buttonCom.Size = new System.Drawing.Size(75, 23);
            this.buttonCom.TabIndex = 1;
            this.buttonCom.Text = "Command";
            this.buttonCom.UseVisualStyleBackColor = true;
            this.buttonCom.Click += new System.EventHandler(this.buttonCom_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Enabled = false;
            this.buttonRead.Location = new System.Drawing.Point(126, 118);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // listBoxSaetze
            // 
            this.listBoxSaetze.FormattingEnabled = true;
            this.listBoxSaetze.Location = new System.Drawing.Point(97, 187);
            this.listBoxSaetze.Name = "listBoxSaetze";
            this.listBoxSaetze.Size = new System.Drawing.Size(201, 173);
            this.listBoxSaetze.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Artikelgruppe";
            // 
            // textBoxArtGr
            // 
            this.textBoxArtGr.Location = new System.Drawing.Point(305, 92);
            this.textBoxArtGr.Name = "textBoxArtGr";
            this.textBoxArtGr.Size = new System.Drawing.Size(100, 20);
            this.textBoxArtGr.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 593);
            this.Controls.Add(this.textBoxArtGr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSaetze);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonCom);
            this.Controls.Add(this.buttonCon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCon;
        private System.Windows.Forms.Button buttonCom;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ListBox listBoxSaetze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArtGr;
    }
}

