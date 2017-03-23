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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 408);
            this.Controls.Add(this.listBoxSaetze);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonCom);
            this.Controls.Add(this.buttonCon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCon;
        private System.Windows.Forms.Button buttonCom;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ListBox listBoxSaetze;
    }
}

