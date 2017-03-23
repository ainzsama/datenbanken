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
            OleDbConnectionStringBuilder bldr = new OleDbConnectionStringBuilder();
            bldr.Provider = "Microsoft.ACE.OLEDB.12.0";
            bldr.DataSource = "Bestellung.accdb";
            con = new OleDbConnection(bldr.ConnectionString);
            try
            {
                con.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Zugriffsfehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }
        }

        private void buttonCom_Click(object sender, EventArgs e)
        {
            com = con.CreateCommand();
            com.CommandText = "tArtikel";
            com.CommandType = CommandType.TableDirect;
            try
            {
                rd = com.ExecuteReader();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Zugriffsfehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            
            while (rd.Read())
            {
                listBoxSaetze.Items.Add(rd["ArtikelNr"].ToString() + ":" + rd["Bezeichnung"].ToString());
            }
            rd.Close();
        }
    }
}
