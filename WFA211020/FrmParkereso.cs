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
    public partial class FrmParkereso: Form
    {
        public string ConnectionString { get; set; }
        public string KivVaros { get; set; }
        public string KivFajta { get; set; }
        public string KivSuly { get; set; }
        public int KivNem { get; set; }

        public FrmParkereso(string connectionString, string kivVaros, string kivFajta, string kivSuly, int kivNem)
        {
            ConnectionString = connectionString;
            KivVaros = kivVaros;
            KivFajta = kivFajta;
            KivSuly = kivSuly;
            KivNem = kivNem;

            InitializeComponent();
        }

        private void FrmParkereso_Load(object sender, EventArgs e)
        {
            BackColor = KivNem == 1 ? Color.LightBlue : Color.LightPink;
            tbFajta.Text = KivFajta;
            tbSuly.Text = KivSuly;
            tbVaros.Text = KivVaros;

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT Unikornis.Id, Fajta.Nev, Tenyeszto.Nev, Suly " +
                    "FROM Fajta " +
                    "INNER JOIN Unikornis ON Fajta.Id = FajtaId " +
                    "INNER JOIN Tenyeszto ON Tenyeszto.Id = TulajdonosId " +
                    $"WHERE Varos LIKE '{KivVaros}' " +
                    $"AND Nem != {KivNem}", c)
                    .ExecuteReader();

                while (r.Read())
                {
                    dgvParok.Rows.Add(r[0], r[1], r[2], r[3] + " Kg");
                }
            }
        }
    }
}
