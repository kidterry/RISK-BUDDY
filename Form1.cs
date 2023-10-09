using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RISK_BUDDY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string user = textBox1.Text;
                string pass = textBox2.Text;
                if (user == "admin" && pass == "risk123")
                {
                    this.Hide();
                    Form2 tf = new Form2();
                    tf.Show();
                }
                else
                {
                    MessageBox.Show("invalid credentials,try again");
                    textBox1.Focus();
                    textBox1.Clear();
                    textBox2.Clear();


                }
            }
            catch (Exception) 
            {
                MessageBox.Show("make sure to enter correct details");           
            }
        }
    }
}
