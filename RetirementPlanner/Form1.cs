using System;
using System.Windows.Forms;

namespace RetirementPlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            float annInc = Convert.ToSingle(annIncome.Text);
            float Pct_annIncr = Convert.ToSingle(Pct_annIncrease.Text);

            float Pct_IncSaved = Convert.ToSingle(Pct_IncomeSaved.Text);
            float Pct_IncMatch = Convert.ToSingle(Pct_incomeMatch.Text);
            float Pct_IncSaved_incr = Convert.ToSingle(Pct_IncomeSaved_incr.Text);

            float Exp_ror = Convert.ToSingle(Expected_ror.Text);
            float yr_2_retire = Convert.ToSingle(year_2_retire.Text);
            float Curr_savings = Convert.ToSingle(Current_savings.Text);

            // Compute total savings upon retirement
            // Assume monthly salary
            float interest;
            float total_savings = 0;
            for(int i=1; i<=yr_2_retire;i++)
            {
                for(int j=1; j<=12; j++)
                {
                    interest = Curr_savings*Exp_ror/1200;
                    Curr_savings = Curr_savings + interest + Pct_IncSaved*annInc/1200 + Pct_IncMatch*annInc/1200;
                }
                annInc = annInc * (1 + Pct_annIncr / 100);
                Pct_IncSaved = Pct_IncSaved + Pct_IncSaved_incr;
                chart1.Series["Series1"].Points.AddXY (i,Curr_savings);
            }

            Results_text.Text = "Your total savings upon retirement will be " 
                                + "$" + Curr_savings.ToString("N") + "!";

            // MessageBox.Show(Convert.ToString(annInc));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            annIncome.Text = "95000";
            Pct_annIncrease.Text = "1";
            Pct_IncomeSaved.Text = "11";
            Pct_incomeMatch.Text = "5";
            Pct_IncomeSaved_incr.Text = "0.2";
            Expected_ror.Text = "7";
            year_2_retire.Text = "35";
            Current_savings.Text = "8000";
        }
    }
}
