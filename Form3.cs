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

namespace RISK_BUDDY
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_MouseHover(object sender, EventArgs e)
        {
            int a =int.Parse(textBox3.Text);
            int b =int.Parse(textBox4.Text);
            int c = a * b;
            textBox5.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || comboBox1.Text.Length == 0 || textBox2.Text.Length == 0 || comboBox2.Text.Length == 0 || comboBox4.Text.Length == 0 || comboBox5.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox6.Text.Length == 0 || comboBox3.Text.Length == 0 || textBox7.Text.Length == 0 || textBox8.Text.Length == 0 || textBox5.Text.Length == 0) 
            {
                MessageBox.Show("Please make sure to fill all details on the form");
            }
            else 
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Riskdata values(@status,@riskreference,@riskdescription,@riskcategory,@likelihood,@impact,@Likelyfactor,@Impactfactor,@Totalscore,@riskimpactdescription,@risktreatment,@riskresponsestrategy,@owner,@lastupdated)",con);
                cmd.Parameters.AddWithValue("@status", comboBox1.Text);
                cmd.Parameters.AddWithValue("@riskreference", textBox1.Text);
                cmd.Parameters.AddWithValue("@riskdescription",textBox2.Text);
                cmd.Parameters.AddWithValue("@riskcategory", comboBox2.Text);
                cmd.Parameters.AddWithValue("@likelihood",comboBox4.Text);
                cmd.Parameters.AddWithValue("@impact",comboBox5.Text);
                cmd.Parameters.AddWithValue("@Likelyfactor",int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@Impactfactor",int.Parse( textBox4.Text));
                cmd.Parameters.AddWithValue("@Totalscore", int.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@riskimpactdescription", textBox6.Text);
                cmd.Parameters.AddWithValue("@risktreatment", comboBox3.Text);
                cmd.Parameters.AddWithValue("@riskresponsestrategy",textBox7.Text);
                cmd.Parameters.AddWithValue("@owner",textBox8.Text);
                cmd.Parameters.AddWithValue("@lastupdated", dateTimePicker1.Value);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved");
                textBox1.Clear();   
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();

            };
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Riskdata", con);
            SqlDataAdapter ad =new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || comboBox1.Text.Length == 0 || textBox2.Text.Length == 0 || comboBox2.Text.Length == 0 || comboBox4.Text.Length == 0 || comboBox5.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox6.Text.Length == 0 || comboBox3.Text.Length == 0 || textBox7.Text.Length == 0 || textBox8.Text.Length == 0)
            {
                MessageBox.Show("Please make sure to fill all details on the form");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Riskdata set status=@status,riskdescription=@riskdescription,riskcategory=@riskcategory,likelihood=@likelihood,impact=@impact,Likelyfactor=@Likelyfactor,Impactfactor=@Impactfactor,Totalscore=@Totalscore,riskimpactdescription=@riskimpactdescription,risktreatment=@risktreatment,riskresponsestrategy=@riskresponsestrategy,owner=@owner,lastupdated=@lastupdated where riskreference=@riskreference", con);
                cmd.Parameters.AddWithValue("@status", comboBox1.Text);
                cmd.Parameters.AddWithValue("@riskreference", textBox1.Text);
                cmd.Parameters.AddWithValue("@riskdescription", textBox2.Text);
                cmd.Parameters.AddWithValue("@riskcategory", comboBox2.Text);
                cmd.Parameters.AddWithValue("@likelihood", comboBox4.Text);
                cmd.Parameters.AddWithValue("@impact", comboBox5.Text);
                cmd.Parameters.AddWithValue("@Likelyfactor", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@Impactfactor", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@Totalscore", int.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@riskimpactdescription", textBox6.Text);
                cmd.Parameters.AddWithValue("@risktreatment", comboBox3.Text);
                cmd.Parameters.AddWithValue("@riskresponsestrategy", textBox7.Text);
                cmd.Parameters.AddWithValue("@owner", textBox8.Text);
                cmd.Parameters.AddWithValue("@lastupdated", dateTimePicker1.Value);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
            };

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Riskdata where riskreference=@riskreference",con);
            DialogResult Option = MessageBox.Show("Delete?", "You Are about to delete this data", MessageBoxButtons.YesNo);
            if (Option == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@riskreference", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted");

            }
            else
            {
                // idle;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from Riskdata where riskcategory=@riskcategory", con);
            cmd.Parameters.AddWithValue("riskcategory",textBox9.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);   
            dataGridView1.DataSource = dt;

        }
        private void label7_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(label7, 0, 0);
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(label12, 0, 0);
        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(label16, 0, 0);
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

        private void exitToolStripMenuItem_DoubleClick(object sender, EventArgs e)
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

        

        private void contextMenuStrip2_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length==0) 
            {
                MessageBox.Show("please enter a risk reference number");

            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;User Instance=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select *from Riskdata where riskreference=@riskreference", con);
                cmd.Parameters.AddWithValue("@riskreference", textBox1.Text);
                cmd.ExecuteNonQuery();

                SqlDataReader DR1 = cmd.ExecuteReader();
                if(DR1.Read())
                {
                    comboBox1.Text=DR1.GetValue(0).ToString();
                    textBox2.Text=DR1.GetValue(2).ToString();
                    textBox3.Text=DR1.GetValue(6).ToString();
                    //dateTimePicker1.Value=DR1.GetValue(13);
                }
                
                else
                {
                    MessageBox.Show("did not read data");
                }
                con.Close();
            }
        }
    }
}
