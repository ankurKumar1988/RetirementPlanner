using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RetirementPlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private float Curr_savings;

        private void compute_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            float annInc = Convert.ToSingle(annIncome.Text);
            float Pct_annIncr = Convert.ToSingle(Pct_annIncrease.Text);

            float Pct_IncSaved = Convert.ToSingle(Pct_IncomeSaved.Text);
            float Pct_IncMatch = Convert.ToSingle(Pct_incomeMatch.Text);
            float Pct_IncSaved_incr = Convert.ToSingle(Pct_IncomeSaved_incr.Text);

            float Exp_ror = Convert.ToSingle(Expected_ror.Text);
            float yr_2_retire = Convert.ToSingle(year_2_retire.Text);
            Curr_savings = Convert.ToSingle(Current_savings.Text);

            // Compute total savings upon retirement
            // Assume monthly salary
            float interest;
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
            load_data_upon_startup();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(load_entry, "Load data from the selected row into the planner tab.");
        }

        private void save_data_Click(object sender, EventArgs e)
        {
            try
            {
                //Database settings  
                string MyConnection2 = "datasource=localhost;port=3306;username=<enter username>;password=<enter password>";
                //Frame SQL query  
                string Query = "insert into retirement_planner.plan_history(current_annual_income,pct_aanual_increase,pct_income_saved,pct_income_comatched,pct_income_saved_annual_increment,pct_expected_rate_of_return,years_to_retirement,current_savings,net_savings_upon_retirement) " +
                                                               "values('" + annIncome.Text + "','" + Pct_annIncrease.Text + "','" + Pct_IncomeSaved.Text + "','" + Pct_incomeMatch.Text + "','" + Pct_IncomeSaved_incr.Text + "','" + Expected_ror.Text + "','" + year_2_retire.Text + "','" + Current_savings.Text + "','" + Curr_savings.ToString() + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataReader MyReader2 = MyCommand2.ExecuteReader(); //Execute SQL query
                MessageBox.Show("Data Saved");
                MyConn2.Close();
                load_data_upon_startup(); //repopulate history table
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_entry_Click(object sender, EventArgs e)
        {
            //open database connection
            string MyConnection2 = "datasource=localhost;port=3306;username=<enter username>;password=<enter password>";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2;
            MySqlDataReader MyReader2;
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                //delete associated entries from mysql database
                string annInc = Convert.ToString(item.Cells["current_annual_income"].Value);
                string Pct_annIncr = Convert.ToString(item.Cells["pct_aanual_increase"].Value);
                string Pct_IncSaved = Convert.ToString(item.Cells["pct_income_saved"].Value);
                string Pct_IncMatch = Convert.ToString(item.Cells["pct_income_comatched"].Value);
                string Pct_IncSaved_incr = Convert.ToString(item.Cells["pct_income_saved_annual_increment"].Value);
                string Exp_ror = Convert.ToString(item.Cells["pct_expected_rate_of_return"].Value);
                string yr_2_retire = Convert.ToString(item.Cells["years_to_retirement"].Value);
                string Curr_savings = Convert.ToString(item.Cells["current_savings"].Value);
                string net_savings = Convert.ToString(item.Cells["net_savings_upon_retirement"].Value);
                try
                {
                    string Query = "delete from retirement_planner.plan_history where current_annual_income = " + annInc + " AND pct_aanual_increase = " + Pct_annIncr + " AND pct_income_saved = " + Pct_IncSaved +
                                   " AND pct_income_comatched = " + Pct_IncMatch + " AND pct_income_saved_annual_increment = " + Pct_IncSaved_incr + " AND pct_expected_rate_of_return = " + Exp_ror +
                                   " AND years_to_retirement = " + yr_2_retire + " AND current_savings = " + Curr_savings;
                    System.Console.WriteLine(Query);
                    MyConn2.Open();
                    MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MyReader2 = MyCommand2.ExecuteReader(); //Execute SQL query
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
            }
            MessageBox.Show("Entry/ies Deleted");
            load_data_upon_startup();
        }

        private void load_data_upon_startup()
        {
            try
            {
                //Database settings  
                string MyConnection2 = "datasource=localhost;port=3306;username=<enter username>;password=<enter password>";
                //Frame SQL query  
                string Query = "select * from retirement_planner.plan_history";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter2 = new MySqlDataAdapter(MyCommand2);
                DataTable dt = new DataTable();
                MyAdapter2.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void load_entry_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count ==1)
            {
                annIncome.Text = dataGridView1.SelectedRows[0].Cells["current_annual_income"].Value.ToString();
                Pct_annIncrease.Text = dataGridView1.SelectedRows[0].Cells["pct_aanual_increase"].Value.ToString();
                Pct_IncomeSaved.Text = dataGridView1.SelectedRows[0].Cells["pct_income_saved"].Value.ToString();
                Pct_incomeMatch.Text = dataGridView1.SelectedRows[0].Cells["pct_income_comatched"].Value.ToString();
                Pct_IncomeSaved_incr.Text = dataGridView1.SelectedRows[0].Cells["pct_income_saved_annual_increment"].Value.ToString();
                Expected_ror.Text = dataGridView1.SelectedRows[0].Cells["pct_expected_rate_of_return"].Value.ToString();
                year_2_retire.Text = dataGridView1.SelectedRows[0].Cells["years_to_retirement"].Value.ToString();
                Current_savings.Text = dataGridView1.SelectedRows[0].Cells["current_savings"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select only one row.");
            }
                
        }
    }
}
