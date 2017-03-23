using System;
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
        public Form1()
        {
            InitializeComponent();
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
            listBoxSaetze.Items.Clear();
            while (rd.Read())
            {
                listBoxSaetze.Items.Add(rd["ArtikelNr"].ToString() + ":" + rd["Bezeichnung"].ToString());
            }
            rd.Close();
            buttonRead.Enabled = false;
       }
    }
}
