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

namespace WFA201015
{
    public partial class FrmUjTurazo : Form
    {
        SqlConnection conn;
        public FrmUjTurazo(SqlConnection conn)
        {
            this.conn = conn; /*az osztály connection mezője legyen egyenlő a paraméterként kapottal*/
            InitializeComponent();
        }

        private void Btn_felvitel_Click(object sender, EventArgs e)
        {
            conn.Open();
            var adapter = new SqlDataAdapter()
            {
                InsertCommand = new SqlCommand(
                    "insert into turazo  (vezeteknev, keresztnev, varos, telefonszam) values " +
                    $"('{tbVeznev.Text}', '{tbKeresztnev.Text}', '{tbVaros.Text}', '{tbTelszam.Text}');", conn),
            };
            adapter.InsertCommand.ExecuteNonQuery(); /*hajtsa végre, amit definiáltunk*/
            conn.Close();

            MessageBox.Show("Siker");
        }
    }
}
