﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplicationDB
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbCommand com;
        OleDbDataReader rd;
        List<Artikel> listArt = null;
        public Form1()
        {
            InitializeComponent();
            listArt = new List<Artikel>();
        }

        private void buttonCon_Click(object sender, EventArgs e)
        {
            //OleDbConnectionStringBuilder bldr = new OleDbConnectionStringBuilder();
            //bldr.Provider = "Microsoft.ACE.OLEDB.12.0";
            //bldr.DataSource = "Bestellung.accdb";
            con = new OleDbConnection(Properties.Settings.Default.DBCon);
            try
            {
                con.Open();
                buttonCom.Enabled = true;
                buttonCreateArticle.Enabled = true;
                com = con.CreateCommand();
                com.Parameters.Add("AGR", OleDbType.Integer);
                String artgr = textBoxArtGr.Text;
                com.CommandText = "Select * from tArtikel where Artikelgruppe = AGR";
                com.CommandType = CommandType.Text;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Zugriffsfehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }
        }

        private void buttonCom_Click(object sender, EventArgs e)
        {
            
            try
            {
                com.Parameters["AGR"].Value = textBoxArtGr.Text;
                rd = com.ExecuteReader();
                buttonRead.Enabled = true;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Zugriffsfehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }
        }

        private void buttonRead_Click(object sender, EventArgs e) 
        {
            listArt.Clear();
            listBoxSaetze.Refresh();
            while (rd.Read())
            {

                // listBoxSaetze.Items.Add(makeArtikelObject(rd));
                listArt.Add(makeArtikelObject(rd));
            }
            rd.Close();
            listBoxSaetze.DataSource = listArt;
            listBoxSaetze.DisplayMember = "Display";
            buttonRead.Enabled = false;
       }
        private Artikel makeArtikelObject(OleDbDataReader reader)
        {
            Artikel a = new Artikel();
            int i = 0;
            if (!DBNull.Value.Equals(reader[i])) a.ArtikelOid = Convert.ToInt32(reader[i]);
            i++;
            if (!DBNull.Value.Equals(reader[i])) a.ArtikelNr = Convert.ToInt32(reader[i]);
            i++;
            if (!DBNull.Value.Equals(reader[i])) a.ArtikelGruppe = Convert.ToInt32(reader[i]);
            i++;
            if (!DBNull.Value.Equals(reader[i])) a.Bezeichnung = reader[i].ToString();
            i++;
            if (!DBNull.Value.Equals(reader[i])) a.Bestand = Convert.ToInt16(reader[i]);
            i++;
            if (!DBNull.Value.Equals(reader[i])) a.Meldebestand = Convert.ToInt16(reader[i]);
            i++;
            if (!DBNull.Value.Equals(reader[i])) a.Verpackung = Convert.ToInt32(reader[i]);
            i++;
            if (!DBNull.Value.Equals(reader[i])) a.VkPreis = Convert.ToDecimal(reader[i]);
            i++;
            if (!DBNull.Value.Equals(reader[i])) a.letzteEntnahme = Convert.ToDateTime(reader[i]);
            return a;
            
        }

        private void buttonCreateArticle_Click(object sender, EventArgs e)
        {
            ArtikelUpdate art = new ArtikelUpdate();
            art.neu = true;
            art.Con = con;
            art.ShowDialog();

        }
    }
}
