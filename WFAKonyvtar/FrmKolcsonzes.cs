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

namespace WFAKonyvtar
{
    public partial class FrmKolcsonzes : Form
    {
        string connString;
        string sISBN;
        string sSzerzo;
        string sCim;

        public FrmKolcsonzes(string connString, string sISBN, string sSzerzo, string sCim)
        {
            this.connString = connString;
            this.sISBN = sISBN;
            this.sSzerzo = sSzerzo;
            this.sCim = sCim;
            InitializeComponent();
        }

        private void FrmKolcsonzes_Load(object sender, EventArgs e)
        {
            tbkISBN.Text = sISBN;
            tbkCim.Text = sCim;
            tbkSzerzo.Text = sSzerzo;
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            var connection = new SqlConnection(connString);
            string nev = tbKolcsonzo.Text;
            long ISBN = Convert.ToInt64(sISBN);
            var honap = Convert.ToInt32(nudHonap.Value);
            var datum = new TimeSpan(0, honap, 0);

            try
            {
                connection.Open();
                var adapter = new SqlDataAdapter()
                {
                    InsertCommand = new SqlCommand($"INSERT INTO Kolcsonzesek VALUES('{nev}', '{ISBN}', '{DateTime.Today + datum}');",connection),
                };
                adapter.InsertCommand.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            this.Dispose();
        }
    }
}
