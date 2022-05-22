using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_MTP_PIUG
{
    public partial class Acasa : Form
    {
        public Acasa()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CautareAngajat caut = new CautareAngajat();
            caut.ShowDialog();
            this.Show();
        }

        private void AngajatIcon_Click(object sender, EventArgs e)
        {
            ManagementAngajati man = new ManagementAngajati();
            man.ShowDialog();
            this.Show();
        }

        private void DelogareIcon_Click(object sender, EventArgs e)
        {
            Autentificare aut = new Autentificare();
            this.Hide();
            aut.Show();
            
        }
    }
}
