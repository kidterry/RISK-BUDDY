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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=1 and Impactfactor=1", con);
            var count1=cmd.ExecuteScalar();
            label46.Text = count1.ToString();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=1 and Impactfactor=2", con);
            var count2=cmd1.ExecuteScalar();
            label44.Text = count2.ToString();
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=1 and Impactfactor=3", con);
            var count3=cmd2.ExecuteScalar();
            label18.Text = count3.ToString();
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=1 and Impactfactor=4", con);
            var count4=cmd3.ExecuteScalar();
            label16.Text = count4.ToString();
            SqlCommand cmd4 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=1 and Impactfactor=5", con);
            var count5=cmd4.ExecuteScalar();
            label13.Text = count5.ToString();
            SqlCommand cmd5 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=2 and Impactfactor=1", con);
            var count6=cmd5.ExecuteScalar();
            label52.Text = count6.ToString();
            SqlCommand cmd6 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=2 and Impactfactor=2", con);
            var count7=cmd6.ExecuteScalar();
            label48.Text = count7.ToString();
            SqlCommand cmd7 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=2 and Impactfactor=3", con);
            var count8=cmd7.ExecuteScalar();
            label19.Text = count8.ToString();
            SqlCommand cmd8 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=2 and Impactfactor=4", con);
            var count9 =cmd8.ExecuteScalar();
            label17.Text = count9.ToString();
            SqlCommand cmd9 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=2 and Impactfactor=5", con);
            var count10 =cmd9.ExecuteScalar();
            label14.Text = count10.ToString();
            SqlCommand cmd10 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=3 and Impactfactor=1", con);
            var count11 =cmd10.ExecuteScalar();
            label54.Text = count11.ToString();
            SqlCommand cmd11 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=3 and Impactfactor=2", con);
            var count12 =cmd11.ExecuteScalar();
            label50.Text = count12.ToString();
            SqlCommand cmd12 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=3 and Impactfactor=3", con);
            var count13 =cmd12.ExecuteScalar();
            label34.Text = count13.ToString();
            SqlCommand cmd13 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=3 and Impactfactor=4", con);
            var count14 =cmd13.ExecuteScalar();
            label28.Text = count14.ToString();
            SqlCommand cmd14 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=3 and Impactfactor=5", con);
            var count15 =cmd14.ExecuteScalar();
            label22.Text = count15.ToString();
            SqlCommand cmd15 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=4 and Impactfactor=1", con);
            var count16 =cmd15.ExecuteScalar();
            label58.Text = count16.ToString();
            SqlCommand cmd16 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=4 and Impactfactor=2", con);
            var count17 =cmd16.ExecuteScalar();
            label56.Text = count17.ToString();
            SqlCommand cmd17 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=4 and Impactfactor=3", con);
            var count18=cmd17.ExecuteScalar();
            label36.Text = count18.ToString();
            SqlCommand cmd18 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=4 and Impactfactor=4", con);
            var count19 =cmd18.ExecuteScalar();
            label30.Text = count19.ToString();
            SqlCommand cmd19 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=4 and Impactfactor=5", con);
            var count20=cmd19.ExecuteScalar();
            label24.Text = count20.ToString();
            SqlCommand cmd20 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=5 and Impactfactor=1", con);
            var count21=cmd19.ExecuteScalar();
            label42.Text = count21.ToString();
            SqlCommand cmd21 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=5 and Impactfactor=2", con);
            var count22=cmd21.ExecuteScalar();
            label40.Text = count22.ToString();
            SqlCommand cmd22 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=5 and Impactfactor=3", con);
            var count23=cmd22.ExecuteScalar();
            label38.Text = count23.ToString();
            SqlCommand cmd23 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=5 and Impactfactor=4", con);
            var count24=cmd23.ExecuteScalar();
            label32.Text = count24.ToString();
            SqlCommand cmd24 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where status='Potential' OR status= 'Active' and Likelyfactor=5 and Impactfactor=5", con);
            var count25=cmd24.ExecuteScalar();
            label26.Text = count25.ToString();
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cm = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where  Totalscore>=1 and Totalscore<=5", con);
            var count21=cm.ExecuteScalar();
            label64.Text = count21.ToString();
            SqlCommand cm1 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where  Totalscore>=5 and Totalscore<=9", con);
            var count22=cm1.ExecuteScalar();
            label70.Text = count22.ToString();
            SqlCommand cm2 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where  Totalscore>=10 and Totalscore<=15", con);
            var count23=cm2.ExecuteScalar();
            label78.Text = count23.ToString();
            SqlCommand cm3 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where  Totalscore>=16 and Totalscore<=25", con);
            var count24=cm3.ExecuteScalar();
            label86.Text = count24.ToString();
            SqlCommand cm4 = new SqlCommand("SELECT COUNT(*) FROM Riskdata", con);
            var count25=cm4.ExecuteScalar();
            label104.Text = count25.ToString();

            //percentages
            //low
            SqlCommand cmd400 = new SqlCommand(cmdText: "(SELECT COUNT(*)*100 from Riskdata Where Totalscore>=1 and Totalscore<=4)", con);
            var countlow = cmd400.ExecuteScalar();
            double a = Convert.ToDouble(count25);
            double b = Convert.ToDouble(countlow);
            double c = b/a;
            label66.Text = c.ToString();
            //moderate
            SqlCommand cmd401 = new SqlCommand(cmdText: "(SELECT COUNT(*)*100 from Riskdata Where Totalscore>=5 and Totalscore<=9)", con);
            var countModerate = cmd401.ExecuteScalar();
            
            double f = Convert.ToDouble(countModerate);
            double g = f/ a;
            label68.Text = g.ToString();
            //high
            SqlCommand cmd402 = new SqlCommand(cmdText: "(SELECT COUNT(*)*100 from Riskdata Where Totalscore>=10 and Totalscore<=15)", con);
            var countHigh = cmd402.ExecuteScalar();
            double i = Convert.ToDouble(countHigh);
            double j = i/ a;
            label76.Text = j.ToString();
            //extreme
            SqlCommand cmd403 = new SqlCommand(cmdText: "(SELECT COUNT(*)*100 from Riskdata Where Totalscore>=16 and Totalscore<=25)", con);
            var countExtreme= cmd403.ExecuteScalar();
            double l = Convert.ToDouble(countExtreme);
            double m = l / a;
            label84.Text = m.ToString();



            con.Close();

            



        }

        private void label112_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(label112,0,0);
        }

        private void label113_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(label113,0,0);
        }

        private void label114_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(label114,0,0);
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void riskRegisterToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
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
    }
}
