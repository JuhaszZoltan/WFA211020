using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA211020.Properties;

namespace WFA211020
{
    public partial class FrmAdatlap : Form
    {
        string connString;

        public FrmAdatlap(string connString)
        {
            this.connString = connString;
            InitializeComponent();
        }

        private void FrmAdatlap_Load(object sender, EventArgs e)
        {
            using(var c = new SqlConnection(connString))
            {
                c.Open();

                var r = new SqlCommand("SELECT Nev FROM Tenyeszto;", c)
                    .ExecuteReader();
                while (r.Read()) cbTulajok.Items.Add(r[0]);
                r.Close();
                r = new SqlCommand("SELECT Nev FROM Fajta", c)
                    .ExecuteReader();
                while (r.Read()) cbFajtak.Items.Add(r[0]);

                cbFajtak.SelectedIndex = 0;
                cbTulajok.SelectedIndex = 0;
            }
        }

        private void CbFajtak_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFajtak.Text)
            {
                case "dapper": 
                    pbKep.Image = Resources.dapper;
                    return;
                case "hipster":
                    pbKep.Image = Resources.hipster;
                    return;
                case "ninja":
                    pbKep.Image = Resources.ninja;
                    return;
                case "nyan":
                    pbKep.Image = Resources.nyan;
                    return;
                case "robot":
                    pbKep.Image = Resources.robot;
                    return;
                case "zombie":
                    pbKep.Image = Resources.zombie;
                    return;
            }

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(connString))
            {
                c.Open();
                var adapter = new SqlDataAdapter()
                {
                    InsertCommand = new SqlCommand(
                        "INSERT INTO Unikornis VALUES " +
                        $"({cbTulajok.SelectedIndex + 1}, {cbFajtak.SelectedIndex + 1}, {nudSuly.Value}, {(rbKanca.Checked ? 0 : 1)});", c),
                };

                adapter.InsertCommand.ExecuteNonQuery();

                //new SqlCommand(
                //        "INSERT INTO Unikornis VALUES " +
                //        $"({cbTulajok.SelectedIndex + 1}, {cbFajtak.SelectedIndex + 1}," +
                //        $" {nudSuly.Value}, {(rbKanca.Checked ? 0 : 1)});", c)
                //    .ExecuteNonQuery();
            }
            this.Dispose();
        }
    }
}
