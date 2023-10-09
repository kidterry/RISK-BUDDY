using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RISK_BUDDY
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void openRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void riskMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void riskRatingScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();

        }

        private void riskTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Option = MessageBox.Show("Exit app", "You Are about to exit this app", MessageBoxButtons.YesNo);
            if (Option == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // idle;
            }
        }

        private void riskBuddyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void contactSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void label112_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(label112,0,0);
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(label11,0,0);
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(label12,0,0);
        }
    }
}
