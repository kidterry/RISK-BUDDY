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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        private void label3_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(label3, 0, 0);
        }

        private void openRegisterToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            
         
            
        }

        private void openRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void riskMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();  
        }

        private void riskRatingScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void riskTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(label5, 0, 0);
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(label4, 0, 0);
        }

        private void riskRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
