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
        //private static string connString =
        //    @"Data Source=(localdb)\MSSQLLocalDB;" +
        //    "Initial Catalog=UniMenes;";

        private string fullPath;
        private string connString;
            
        public FrmMain()
        {
            fullPath = AppDomain.CurrentDomain
            .BaseDirectory
            .Replace(@"bin\Debug\", @"Resources\UniMenes.mdf");

            connString = @"Server=(localdb)\MSSQLLocalDB;" +
            $@"AttachDbFileName={fullPath};";

            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) => UpdateDGV();

        private void MainDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string kuid = mainDGV.SelectedRows[0].Cells[0].Value.ToString();
            //int kuid = Convert.ToInt32(mainDGV[0, e.RowIndex].Value);
        }

        private void BejelentesTSMI_Click(object sender, EventArgs e)
        {
            var frm = new FrmAdatlap(connString);
            frm.ShowDialog();
            UpdateDGV();
        }

        private void UpdateDGV()
        {
            mainDGV.Rows.Clear();
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
    }
}
