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
    public partial class ManagementAngajati : Form
    {
        public ManagementAngajati()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\docs\Angajati.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdaugareAngajat_Click(object sender, EventArgs e)
        {
            if(id.Text == "" || Nume.Text == "" || Adresa.Text=="" || Telefon.Text=="")
            {
                MessageBox.Show("Nu au fost completate toate campurile!");
            }
            else
            {
                try
                {
                    con.Open();
                    string stmt = "insert into Angajati([id], [Nume], [Adresa], [Pozitie], [DataNasterii], [Telefon], [Educatie], [Gen]) values (@i, @n, @ad, @poz, @dn, @tel, @st, @g)";
                    SqlCommand com = new SqlCommand(stmt,con);
                    com.Parameters.AddWithValue("@i", id.Text);
                    com.Parameters.AddWithValue("@n", Nume.Text);
                    com.Parameters.AddWithValue("@ad", Adresa.Text);
                    com.Parameters.AddWithValue("@poz", Pozitie.Text);
                    com.Parameters.AddWithValue("@dn", DataNasterii.Value);
                    com.Parameters.AddWithValue("@tel", Telefon.Text);
                    com.Parameters.AddWithValue("@st", Educatie.Text);
                    com.Parameters.AddWithValue("@g", Gen.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Datele angajatului au fost adaugate cu succes!");
                    con.Close();
                    populare_dgv();
                }
                catch(Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
        }

        private void populare_dgv()
        {
            con.Open();
            string stmt = "select * from Angajati";
            SqlDataAdapter sda = new SqlDataAdapter(stmt, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DataGridViewAngajati.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ManagementAngajati_Load(object sender, EventArgs e)
        {
            populare_dgv();
        }

        private void StergereAngajat_Click(object sender, EventArgs e)
        {
            if(id.Text=="")
            {
                MessageBox.Show("Introduceti un ID");
            }
            else
            {
                try
                {
                    con.Open();
                    string stmt = "delete from Angajati where id='" + id.Text + "';";
                    SqlCommand com = new SqlCommand(stmt, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Datele angajatului au fost sterse cu succes!");                 
                    con.Close();
                    populare_dgv();
                }
                catch(Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Nume.Text = "";
            id.Text = "";
            Adresa.Text = "";
            Gen.SelectedIndex = -1;
            Pozitie.SelectedIndex = -1;
            Telefon.Text = "";
            DataNasterii.Format = DateTimePickerFormat.Custom;
            DataNasterii.CustomFormat = "";
            DataNasterii.ShowCheckBox = true;
            DataNasterii.Checked = false;
            Educatie.SelectedIndex = -1;
        }

        private void DataGridViewAngajati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
