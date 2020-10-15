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
    public partial class FrmMain : Form
    {
        SqlConnection conn;


        public FrmMain()
        {
            conn = new SqlConnection(

               @"Server = (localdb)\MSSQLLocalDB;" +
               @"AttachDbFileName=|DataDirectory|\res\turautvonalak.mdf;"); /*|konkrét környezeti változó van benne: bin/debug/res - attól függ, h honnan fut az exe|*/

            

            InitializeComponent();
        }


        private void DgvFeltolt()
        {
            dgv.Rows.Clear();
            conn.Open(); /*amikor rákattintok a gombra, megnyitopm a kapcsolatot. Rögtön a conn.Close() parancsot is tegyünk be, nehogy elfelejtődjön*/

            var cmd = new SqlCommand("SELECT * FROM turazo", conn);/*definiáljuk a commandot. A conn mint paraméter azért kell, hogy tudja, hogy melyik ab-on értelmezze a parancsot*/

            var r = cmd.ExecuteReader(); /*kell egy reader*/

            while (r.Read())
            {
                dgv.Rows.Add(r[0], r[1], r[2], r[3], r[4]); /*alapból a tostring-et hívja meg. most van egy int és egy varchar. erre tökéletes*/
            }
                               
            conn.Close();
 


        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DgvFeltolt();
        }
    }
}
