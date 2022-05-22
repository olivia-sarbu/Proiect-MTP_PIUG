using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_MTP_PIUG
{
    public partial class CautareAngajat : Form
    {
        public CautareAngajat()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\docs\Angajati.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Acasa a = new Acasa();
            a.Show();
            this.Hide();
        }

        private void afisareAngajat()
        {
            con.Open();
            string stmt = "select * from Angajati where Nume='" + AngajatCautat.Text + "'";
            SqlCommand com = new SqlCommand(stmt, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(com);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                infoNume.Text = dr["Nume"].ToString();
                infoID.Text = dr["Id"].ToString();
                infoAdresa.Text = dr["Adresa"].ToString();
                infoGen.Text= dr["Gen"].ToString();
                infoPozitie.Text= dr["Pozitie"].ToString();
                infoTelefon.Text= dr["Telefon"].ToString();
                infoDataNasterii.Text= dr["DataNasterii"].ToString();
                infoEducatie.Text= dr["Educatie"].ToString();
            }
            con.Close();
        }

        private void CautareAngajat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            afisareAngajat();
            if (AngajatCautat.Text == "")
                MessageBox.Show("Nu ati introdus numele angajatului!");
        }
    }
}
