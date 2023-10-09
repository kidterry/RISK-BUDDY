using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RISK_BUDDY
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/Trrey81");
        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/terrence-murindi-66b8b123a/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/terry8x1/");
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/terry.murindi.5/");
        }

        private void label112_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(label112, 0, 0);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(label3, 0, 0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(label4, 0, 0);
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
    }
}
