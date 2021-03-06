﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationDB
{
    
    public partial class ArtikelUpdate : Form
    {
        private OleDbConnection con;
        public Boolean neu;
        private Artikel a;
        public OleDbConnection Con
        {
            get
            {
                return con;
            }

            set
            {
                con = value;
            }
        }

        public ArtikelUpdate()
        {
            InitializeComponent();
            if (neu) buttonAendern.Text = "Anlegen";
        }
        public ArtikelUpdate(Boolean b, OleDbConnection c)
        {
            InitializeComponent();
            neu = b;
            con = c;
            if (neu) buttonAendern.Text = "Anlegen";
        }

        private void Anlegen()
        {
            OleDbCommand com = con.CreateCommand();
            com.Parameters.Add("Nr", OleDbType.WChar);
            com.Parameters.Add("Gr", OleDbType.Integer);
            com.Parameters.Add("Bez", OleDbType.WChar);
         
            com.Parameters.Add("Verp", OleDbType.Integer);
        
            
            com.CommandText = "insert into tArtikel(ArtikelNr, ArtikelGruppe, Bezeichnung, Verpackung) values(Nr, Gr, Bez, Verp)"; // Spalten angeben

            com.Parameters["Nr"].Value = textBoxNr.Text;
            com.Parameters["Gr"].Value = textBoxGruppe.Text;
           
            com.Parameters["Bez"].Value = textBoxBez.Text;
            
            com.Parameters["Verp"].Value = textBoxVerpackung.Text;
           
           

            try
            {
                com.ExecuteNonQuery();

                com.CommandText = "Select @@IDENTITY from tArtikel";
                int aw = (Int32)com.ExecuteScalar();
                textBoxId.Text = aw.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Fehler");
            }
           
        }
        private void buttonAendern_Click(object sender, EventArgs e)
        {
            
            if (neu) Anlegen();
        //    else UpdateArtikel;
        }

        private void textBoxNr_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(textBoxNr.Text);
            }
            catch
            {
                MessageBox.Show("muss Ganzzahl sein");
                e.Cancel = true;
            }
        }

        private void textBoxGruppe_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(textBoxGruppe.Text);
            }
            catch
            {
                MessageBox.Show("muss Ganzzahl sein");
                e.Cancel = true;
            }
        }

        private void textBoxBestand_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt16(textBoxBestand.Text);
            }
            catch
            {
                MessageBox.Show("muss Ganzzahl sein");
                e.Cancel = true;
            }
        }

        private void textBoxMeldeBestand_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt16(textBoxMeldeBestand.Text);
            }
            catch
            {
                MessageBox.Show("muss Ganzzahl sein");
                e.Cancel = true;
            }
        }

        private void textBoxPreis_Validating(object sender, CancelEventArgs e)
        {
            decimal i = 0;
            try
            {
                i = Convert.ToDecimal(textBoxPreis.Text);
            }
            catch
            {
                MessageBox.Show("muss Betrag sein");
                e.Cancel = true;
            }
        }

        
    }
}
