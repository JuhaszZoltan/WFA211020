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

namespace WFA211020
{
    public partial class FrmMain : Form
    {
        private static string connString =
            @"Data Source=(localdb)\MSSQLLocalDB;" +
            "Initial Catalog=UniMenes;";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();

                var r = new SqlCommand(
                    "SELECT Unikornis.Id, Fajta.Nev, Tenyeszto.Nev, Varos, Suly, Nem " +
                    "FROM Fajta " +
                    "INNER JOIN Unikornis ON Fajta.Id = FajtaId " +
                    "INNER JOIN Tenyeszto ON Tenyeszto.Id = TulajdonosId;", conn)
                    .ExecuteReader();

                while (r.Read())
                {
                    mainDGV.Rows.Add(
                        r[0], r[1], r[2], r[3],
                        r[4] + " Kg",
                        r.GetBoolean(5) ? "csődör" : "kanca");
                }
            }
        }

        private void mainDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string kuid = mainDGV.SelectedRows[0].Cells[0].Value.ToString();
            int kuid = Convert.ToInt32(mainDGV[0, e.RowIndex].Value);
            
            var frm = new FrmAdatlap(connString, kuid);
            frm.ShowDialog();
        }
    }
}
