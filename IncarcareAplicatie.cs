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
    public partial class IncarcareAplicatie : Form
    {
        public IncarcareAplicatie()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            ProgressCircle.Value = startpoint;
            if(ProgressCircle.Value==100)
            {
                ProgressCircle.Value = 0;
                timer1.Stop();              
                Autentificare aut = new Autentificare();
                aut.Show();
                this.Hide();
            }
        }

        private void IncarcareAplicatie_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void ProgressCircle_Click(object sender, EventArgs e)
        {

        }
    }
}
