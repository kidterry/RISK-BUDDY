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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //total risks
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='1-Strategic'", con);
            var count1 = cmd.ExecuteScalar();
            label22.Text=count1.ToString();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='2-Governance Organisation'", con);
            var count2 = cmd1.ExecuteScalar();
            label23.Text=count2.ToString();
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='3-Procurement'", con);
            var count3= cmd2.ExecuteScalar();
            label24.Text=count3.ToString();
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='4-Financial'", con);
            var count4 = cmd3.ExecuteScalar();
            label25.Text=count4.ToString();
            SqlCommand cmd4 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='5-Human Resources'", con);
            var count5 = cmd4.ExecuteScalar();
            label26.Text=count5.ToString();
            SqlCommand cmd5 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='6-Healthy & Safety'", con);
            var count6 = cmd5.ExecuteScalar();
            label27.Text=count6.ToString();
            SqlCommand cmd6 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='7-Campus Security'", con);
            var count =cmd6.ExecuteScalar();
            label28.Text=count6.ToString();
            SqlCommand cmd7= new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='8-ICT Risk'", con);
            var count8= cmd7.ExecuteScalar();
            label29.Text=count8.ToString();
            SqlCommand cmd8 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='9-Market Risks'", con);
            var count9 = cmd8.ExecuteScalar();
            label30.Text=count9.ToString();
            SqlCommand cmd9= new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='10-Credit Risks'", con);
            var count10 = cmd9.ExecuteScalar();
            label31.Text=count10.ToString();
            SqlCommand cmd10 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='11-Legal Risks'", con);
            var count11 = cmd10.ExecuteScalar();
            label32.Text=count11.ToString();
            SqlCommand cmd11 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='12-Liquidity Risks'", con);
            var count12 = cmd11.ExecuteScalar();
            label33.Text=count12.ToString();
            SqlCommand cmd12 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='13-Operational'", con);
            var count13 = cmd12.ExecuteScalar();
            label34.Text=count13.ToString();
            SqlCommand cmd14 = new SqlCommand("SELECT COUNT(*) FROM Riskdata ", con);
            var count15 = cmd14.ExecuteScalar();
            label35.Text=count15.ToString();
            //extreme risks
            SqlCommand cmd15 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='1-Strategic' and Totalscore>=16 and Totalscore<=25", con);
            var count16 = cmd15.ExecuteScalar();
            label46.Text=count16.ToString();
            SqlCommand cmd16 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='2-Governance Organisation' and Totalscore>=16 and Totalscore<=25", con);
            var count17 = cmd16.ExecuteScalar();
            label47.Text=count17.ToString();
            SqlCommand cmd17= new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='3-Procurement' and Totalscore>=16 and Totalscore<=25", con);
            var count18 = cmd17.ExecuteScalar();
            label48.Text=count18.ToString();
            SqlCommand cmd18 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='4-Financial' and Totalscore>=16 and Totalscore<=25", con);
            var count19 = cmd18.ExecuteScalar();
            label49.Text=count19.ToString();
            SqlCommand cmd19 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='5-Human Resources' and Totalscore>=16 and Totalscore<=25", con);
            var count20 = cmd19.ExecuteScalar();
            label50.Text=count20.ToString();
            SqlCommand cmd20 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='6-Healthy & Safety' and Totalscore>=16 and Totalscore<=25", con);
            var count21 = cmd20.ExecuteScalar();
            label51.Text=count21.ToString();
            SqlCommand cmd21 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='7-Campus Security' and Totalscore>=16 and Totalscore<=25", con);
            var count22=cmd21.ExecuteScalar();
            label52.Text=count22.ToString();
            SqlCommand cmd22 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='8-ICT Risk' and Totalscore>=16 and Totalscore<=25", con);
            var count23=cmd22.ExecuteScalar();
            label53.Text=count23.ToString();
            SqlCommand cmd23= new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='9-Market Risks' and Totalscore>=16 and Totalscore<=25", con);
            var count24=cmd23.ExecuteScalar();
            label54.Text=count24.ToString();
            SqlCommand cmd24 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='10-Credit Risks' and Totalscore>=16 and Totalscore<=25", con);
            var count25=cmd24.ExecuteScalar();
            label55.Text=count25.ToString();
            SqlCommand cmd25= new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='11-Liquidity Risks' and Totalscore>=16 and Totalscore<=25", con);
            var count26=cmd25.ExecuteScalar();
            label56.Text=count26.ToString();
            SqlCommand cmd26 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='12-Legal Risks' and Totalscore>=16 and Totalscore<=25", con);
            var count27=cmd26.ExecuteScalar();
            label57.Text=count27.ToString();
            SqlCommand cmd27 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='13-Operational' and Totalscore>=16 and Totalscore<=25", con);
            var count28=cmd27.ExecuteScalar();
            label58.Text=count28.ToString();
            SqlCommand cmd28= new SqlCommand("SELECT COUNT(*) FROM Riskdata Where  Totalscore>=16 and Totalscore<=25", con);
            var count29=cmd28.ExecuteScalar();
            label59.Text=count29.ToString();
            SqlCommand cmd300 = new SqlCommand("select count(*)from Riskdata", con);
            var countExtreme = cmd300.ExecuteScalar();
            SqlCommand cmd102 = new SqlCommand(cmdText: "(SELECT COUNT(*)*100 from Riskdata Where Totalscore>16 and Totalscore<=25)", con);
            var count200 = cmd102.ExecuteScalar();
            double a = Convert.ToDouble(count200);
            double b = Convert.ToDouble(countExtreme);
            double c=a/b;
            label42.Text=c.ToString();
            //label42.Text=e(total)/total*100;

            //high risks
            SqlCommand cmd29 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='1-Strategic' and Totalscore>=10 and Totalscore<=15", con);
            var count30 = cmd29.ExecuteScalar();
            label60.Text = count30.ToString();
            SqlCommand cmd30 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='2-Governance Organisation' and Totalscore>=10 and Totalscore<=15", con);
            var count31 = cmd30.ExecuteScalar();
            label61.Text = count31.ToString();
            SqlCommand cmd31 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='3-Procurement' and Totalscore>=10 and Totalscore<=15", con);
            var count32 = cmd31.ExecuteScalar();
            label62.Text = count32.ToString();
            SqlCommand cmd32 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='4-Financial' and Totalscore>=10 and Totalscore<=15", con);
            var count33 = cmd32.ExecuteScalar();
            label63.Text = count33.ToString();
            SqlCommand cmd33 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='5-Human Resources' and Totalscore>=10 and Totalscore<=15", con);
            var count34 = cmd33.ExecuteScalar();
            label64.Text = count34.ToString();
            SqlCommand cmd34 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='6-Healthy & Safety' and Totalscore>=10 and Totalscore<=15", con);
            var count35 = cmd34.ExecuteScalar();
            label65.Text = count35.ToString();
            SqlCommand cmd35 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='7-Campus Security' and Totalscore>=10 and Totalscore<=15", con);
            var count36 = cmd35.ExecuteScalar();
            label66.Text = count36.ToString();
            SqlCommand cmd36 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='8-ICT Risk' and Totalscore>=10 and Totalscore<=15", con);
            var count37 = cmd36.ExecuteScalar();
            label67.Text = count37.ToString();
            SqlCommand cmd37 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='9-Market Risks' and Totalscore>=10 and Totalscore<=15", con);
            var count38 = cmd37.ExecuteScalar();
            label68.Text = count38.ToString();
            SqlCommand cmd38= new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='10-Credit Risks' and Totalscore>=10 and Totalscore<=15", con);
            var count39 = cmd38.ExecuteScalar();
            label69.Text = count39.ToString();
            SqlCommand cmd39 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='11-Liquidity Risks' and Totalscore>=10 and Totalscore<=15", con);
            var count40 = cmd39.ExecuteScalar();
            label70.Text = count40.ToString();
            SqlCommand cmd40 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='12-Legal Risks' and Totalscore>=10 and Totalscore<=15", con);
            var count41 = cmd40.ExecuteScalar();
            label71.Text = count41.ToString();
            SqlCommand cmd41 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='13-Operational' and Totalscore>=10 and Totalscore<=15", con);
            var count42 = cmd41.ExecuteScalar();
            label72.Text = count42.ToString();
            SqlCommand cmd42 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where  Totalscore>=10 and Totalscore<=15", con);
            var count43 = cmd42.ExecuteScalar();
            label73.Text = count43.ToString();

            SqlCommand cmd301 = new SqlCommand("select count(*)from Riskdata", con);
            var countHigh = cmd301.ExecuteScalar();
            SqlCommand cmd105 = new SqlCommand(cmdText: "(SELECT COUNT(*)*100 from Riskdata Where Totalscore>=10 and Totalscore<=15)", con);
            var count201 = cmd105.ExecuteScalar();
            double d = Convert.ToDouble(count201);
            double g = Convert.ToDouble(countHigh);
            double f = d / g;
            label43.Text= f.ToString();

            //label43.Text=h(total)/total risks*100%;

            //moderate risks
            SqlCommand cmd43 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='1-Strategic' and Totalscore>=5 and Totalscore<=9", con);
            var count44 = cmd43.ExecuteScalar();
            label74.Text = count44.ToString();
            SqlCommand cmd44 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='2-Governance Organisation' and Totalscore>=5 and Totalscore<=9", con);
            var count45 = cmd44.ExecuteScalar();
            label75.Text = count45.ToString();
            SqlCommand cmd45 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='3-Procurement' and Totalscore>=5 and Totalscore<=9", con);
            var count46= cmd45.ExecuteScalar();
            label76.Text = count46.ToString();
            SqlCommand cmd46 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='4-Financial' and Totalscore>=5 and Totalscore<=9", con);
            var count47 = cmd46.ExecuteScalar();
            label77.Text = count47.ToString();
            SqlCommand cmd47 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='5-Human Resources' and Totalscore>=5 and Totalscore<=9", con);
            var count48 = cmd47.ExecuteScalar();
            label78.Text = count48.ToString();
            SqlCommand cmd48 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='6-Healthy & Safety' and Totalscore>=5 and Totalscore<=9", con);
            var count49 = cmd48.ExecuteScalar();
            label79.Text = count49.ToString();
            SqlCommand cmd49 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='7-Campus Security' and Totalscore>=5 and Totalscore<=9", con);
            var count50 = cmd49.ExecuteScalar();
            label80.Text = count50.ToString();
            SqlCommand cmd50 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='8-ICT Risk' and Totalscore>=5 and Totalscore<=9", con);
            var count51 = cmd50.ExecuteScalar();
            label81.Text = count51.ToString();
            SqlCommand cmd51 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='9-Market Risks' and Totalscore>=5 and Totalscore<=9", con);
            var count52 = cmd51.ExecuteScalar();
            label82.Text = count52.ToString();
            SqlCommand cmd52= new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='10-Credit Risks' and Totalscore>=5 and Totalscore<=9", con);
            var count53 = cmd52.ExecuteScalar();
            label83.Text = count53.ToString();
            SqlCommand cmd53 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='11-Liquidity Risks' and Totalscore>=5 and Totalscore<=9", con);
            var count54 = cmd53.ExecuteScalar();
            label84.Text = count54.ToString();
            SqlCommand cmd54 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='12-Legal Risks' and Totalscore>=5 and Totalscore<=9", con);
            var count55 = cmd54.ExecuteScalar();
            label85.Text = count55.ToString();
            SqlCommand cmd55 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='13-Operational' and Totalscore>=5 and Totalscore<=9", con);
            var count56 = cmd55.ExecuteScalar();
            label86.Text = count56.ToString();
            SqlCommand cmd56 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where  Totalscore>=5 and Totalscore<=9", con);
            var count57= cmd56.ExecuteScalar();
            label87.Text = count57.ToString();

            SqlCommand cmd302 = new SqlCommand("select count(*)from Riskdata", con);
            var countModerate = cmd302.ExecuteScalar();
            SqlCommand cmd106 = new SqlCommand(cmdText: "(SELECT COUNT(*)*100 from Riskdata Where Totalscore>=5 and Totalscore<=9)", con);
            var count202= cmd106.ExecuteScalar();
            double h= Convert.ToDouble(count202);
            double i = Convert.ToDouble(countModerate);
            double j = h / i;
            label44.Text = j.ToString();
            //label44.Text=m(total)/total*100;

            //low risks
            SqlCommand cmd57 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='1-Strategic' and Totalscore>=1 and Totalscore<=4", con);
            var count58 = cmd57.ExecuteScalar();
            label88.Text = count58.ToString();
            SqlCommand cmd58 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='2-Governance Organisation' and Totalscore>=1 and Totalscore<=4", con);
            var count59 = cmd58.ExecuteScalar();
            label89.Text = count59.ToString();
            SqlCommand cmd59 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='3-Procurement' and Totalscore>=1 and Totalscore<=4", con);
            var count60 = cmd59.ExecuteScalar();
            label90.Text = count60.ToString();
            SqlCommand cmd60 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='4-Financial' and Totalscore>=1 and Totalscore<=4", con);
            var count61 = cmd60.ExecuteScalar();
            label91.Text = count61.ToString();
            SqlCommand cmd61 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='5-Human Resources' and Totalscore>=1 and Totalscore<=4", con);
            var count62 = cmd61.ExecuteScalar();
            label92.Text = count62.ToString();
            SqlCommand cmd62 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='6-Healthy & Safety' and Totalscore>=1 and Totalscore<=4", con);
            var count63 = cmd62.ExecuteScalar();
            label93.Text = count63.ToString();
            SqlCommand cmd63 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='7-Campus Security' and Totalscore>=1 and Totalscore<=4", con);
            var count64 = cmd63.ExecuteScalar();
            label94.Text = count64.ToString();
            SqlCommand cmd64 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='8-ICT Risk' and Totalscore>=1 and Totalscore<=4", con);
            var count65 = cmd64.ExecuteScalar();
            label95.Text = count65.ToString();
            SqlCommand cmd65 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='9-Market Risks' and Totalscore>=1 and Totalscore<=4", con);
            var count66 = cmd65.ExecuteScalar();
            label96.Text = count66.ToString();
            SqlCommand cmd66 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='10-Credit Risks' and Totalscore>=1 and Totalscore<=4", con);
            var count67 = cmd66.ExecuteScalar();
            label97.Text = count67.ToString();
            SqlCommand cmd67 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='11-Liquidity Risks' and Totalscore>=1 and Totalscore<=4", con);
            var count68 = cmd67.ExecuteScalar();
            label98.Text = count68.ToString();
            SqlCommand cmd68 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='12-Legal Risks' and Totalscore>=1 and Totalscore<=4", con);
            var count69 = cmd68.ExecuteScalar();
            label99.Text = count69.ToString();
            SqlCommand cmd69 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where riskcategory='13-Operational' and Totalscore>=1 and Totalscore<=4", con);
            var count70 = cmd69.ExecuteScalar();
            label100.Text = count70.ToString();
            SqlCommand cmd70 = new SqlCommand("SELECT COUNT(*) FROM Riskdata Where  Totalscore>=1 and Totalscore<=4", con);
            var count71 = cmd70.ExecuteScalar();
            label101.Text = count71.ToString();

            SqlCommand cmd303 = new SqlCommand("select count(*)from Riskdata", con);
            var countLow= cmd301.ExecuteScalar();
            SqlCommand cmd107= new SqlCommand(cmdText: "(SELECT COUNT(*)*100 from Riskdata Where Totalscore>=1 and Totalscore<=4)", con);
            var count203 = cmd107.ExecuteScalar();
            double k = Convert.ToDouble(count203);
            double l = Convert.ToDouble(countLow);
            double m = k/ l;
            label45.Text = m.ToString();
            //lable45.Text=l(total)/total*100;

            con.Close();






        }

        private void label112_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(label112, 0, 0);
        }

        private void label103_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(label103, 0, 0);
        }

        private void label104_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(label104, 0, 0);
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
