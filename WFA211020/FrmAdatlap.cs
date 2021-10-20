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
    public partial class FrmAdatlap : Form
    {
        string connString;
        int id;

        public FrmAdatlap(string connString, int id)
        {
            this.connString = connString;
            this.id = id;
            InitializeComponent();
        }

        private void FrmAdatlap_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                var r = new SqlCommand(
                    $"SELECT * FROM Unikornis WHERE Id = {id};",
                    conn)
                    .ExecuteReader();
                r.Read();
                lblInfo.Text = $"{r[0]} - {r[1]} - {r[2]} - {r[3]} - {r[4]}";
            }


                
        }
    }
}
