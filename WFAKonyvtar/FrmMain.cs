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
    public partial class FrmMain : Form
    {
        public string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=konyvtar;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UpdateDGV();
        }

        public void UpdateDGV()
        {
            dgvMain.Rows.Clear();

            var connection = new SqlConnection(connString);
            connection.Open();

            var command = new SqlCommand("SELECT * FROM Konyvek", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgvMain.Rows.Add(
                    reader[0],
                    reader[1],
                    reader[2],
                    reader.GetDateTime(3).ToString("yyy")); 
            }
            reader.Close();

            connection.Close();
            
        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            long ISBN = Convert.ToInt64(tbISBN.Text);
            string szerzo = tbSzerzo.Text;
            string cim = tbCim.Text;
            string megjelenes = $"{Convert.ToInt32(tbMegjelenes.Text)}-01-01";


            var connection = new SqlConnection(connString);

            try
            {
                var errMessage = "";
                if (!long.TryParse(tbISBN.Text, out _)) errMessage += "Az ISBN mezőbe csak szám érték kerülhet!\n";
                if (String.IsNullOrWhiteSpace(tbISBN.Text)) errMessage += "Az ISBN mező nem maradhat üresen!\n";
                if (String.IsNullOrWhiteSpace(tbSzerzo.Text)) errMessage += "A szerző mező nem maradhat üresen!\n";
                if (String.IsNullOrWhiteSpace(tbCim.Text)) errMessage += "A cím mező nem maradhat üresen!\n";
                if (String.IsNullOrWhiteSpace(tbMegjelenes.Text)) errMessage += "A megjelenés mező nem maradhat üresen!\n";
                if (!int.TryParse(tbMegjelenes.Text, out _)) errMessage += "A megjelenés mező értéke egész szám kell hogy legyen!\n";
                if (tbMegjelenes.Text.Length != 4) errMessage += "A megjelenés mező értéke az évszámot kell hogy tartalmazza, ami 4 karakteres!\n";

                if (!String.IsNullOrEmpty(errMessage)) throw new Exception(errMessage);

                connection.Open();

                var adapter = new SqlDataAdapter()
                {
                    InsertCommand = new SqlCommand($"INSERT INTO Konyvek VALUES ('{ISBN}', '{szerzo}', '{cim}', '{megjelenes}');",connection),
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
            tbClear();
            UpdateDGV();

        }

        private void tbClear()
        {
            tbISBN.Text = "";
            tbSzerzo.Text = "";
            tbCim.Text = "";
            tbMegjelenes.Text = "";
        }

        public void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sISBN = dgvMain[0, e.RowIndex].Value + "";
            string sSzerzo = dgvMain[1, e.RowIndex].Value + "";
            string sCim = dgvMain[2, e.RowIndex].Value + "";
            tbSelectedISBN.Text = sISBN;
            tbSelectedSzerzo.Text = sSzerzo;
            tbSelectedCim.Text = sCim;

            var connection = new SqlConnection(connString);
            connection.Open();
            var command = new SqlCommand("SELECT hatarido FROM Kolcsonzesek", connection);
            var reader = command.ExecuteReader();
            reader.Read();
            if (reader.GetDateTime(0) > DateTime.Today)
            {
                tbSelectedKolcsonozheto.Text = "NEM";
            }
            else
            {
                tbSelectedKolcsonozheto.Text = "IGEN";
            }
            reader.Close();
            connection.Close();
        }

        private void btnKolcsonzes_Click(object sender, EventArgs e)
        {
            var frm = new FrmKolcsonzes(connString, tbSelectedISBN.Text, tbSelectedSzerzo.Text, tbSelectedCim.Text);
            frm.ShowDialog();
            UpdateDGV();
        }
    }
}
