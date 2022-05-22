using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_MTP_PIUG
{
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
        }
        private int incercari = 0;
        private void Autentificare_Load(object sender, EventArgs e)
        {
            string[] utilizatori = File.ReadAllLines("utilizatori.txt");
            foreach (var line in utilizatori)
            {
                string[] inregistrare = line.Split(',');
                comboBoxUtilizator.Items.Add(inregistrare[0]);
            }
        }
        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            string[] utilizatori = File.ReadAllLines("utilizatori.txt");

            foreach (var line in utilizatori)
            {
                string[] inregistrare = line.Split(',');
                if ((comboBoxUtilizator.Text).Equals(inregistrare[0]))
                {
                    if ((txtParola.Text.Trim()).Equals(inregistrare[1].Trim()))
                    {
                        Acasa a = new Acasa();
                        this.Hide();
                        a.ShowDialog();                       
                    }
                    else
                    {
                        incercari++;
                        MessageBox.Show("Parola incorecta! Mai aveti " + (3 - incercari).ToString() + " incercari.");
                    }
                }
                if (incercari == 3)
                    Application.Exit();
            }
            if (comboBoxUtilizator.SelectedIndex == -1 && txtParola.Text == "")
                MessageBox.Show("Nu ati introdus datele de autentificare!");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
