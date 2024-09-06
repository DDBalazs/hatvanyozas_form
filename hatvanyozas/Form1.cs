using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hatvanyozas
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void form_Shown(object sender, EventArgs e)
        {
            lberedmeny.Visible = false;
        }

        private void btszamol_Click(object sender, EventArgs e)
        {
            if (txalap.TextLength == 0)
            {
                MessageBox.Show("Adja meg a hatványalapot!");
                txalap.Focus();
            }
            else if (txkitev.TextLength == 0)
            {
                MessageBox.Show("Adja meg a hatványkitevőt", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txkitev.Focus();
            }
            else if (txalap.Text.Length == 0 && txkitev.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a hatványalapot és a hatvány kitevőt!");
                txalap.Focus();
            }
            else
            {
                double eredmeny = Math.Pow(Convert.ToDouble(txalap.Text), Convert.ToDouble(txkitev.Text));
                lberedmeny.Text = "A hatványozás eredménye: "+ Convert.ToString(eredmeny);
                lberedmeny.Visible=true;
            }
        }
    }
}
