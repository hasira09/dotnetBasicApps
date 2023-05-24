using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalInterview
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        public Form1()
        {
            InitializeComponent();

            //Add your SQL Connection String here
            con = new SqlConnection("");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            //Creating the Insert Command
            string query = "INSERT INTO Birthday_Table VALUES (@Value1, @Value2)";
            SqlCommand command = new SqlCommand(query, con);

            //Setting Parameter Values
            command.Parameters.AddWithValue("@Value1", textBox1.Text);
            command.Parameters.AddWithValue("@Value2", dateTimePicker1.Value);

            command.ExecuteNonQuery();
            con.Close();

            //Calculate the Age
            DateTime currentDate = DateTime.Now;
            DateTime birthDate = dateTimePicker1.Value;

            int years = currentDate.Year - birthDate.Year;
            int months = currentDate.Month - birthDate.Month;
            int days = currentDate.Day - birthDate.Day;

            if (currentDate < birthDate.AddYears(years))
            {
                years--;
                months = 12 - birthDate.Month + currentDate.Month;
            }

            if (currentDate.Day < birthDate.Day)
            {
                months--;
                days = DateTime.DaysInMonth(birthDate.Year, birthDate.Month) - birthDate.Day + currentDate.Day;
            }

            string ageMessage = $"User's Current Age: {years} years, {months} months, {days} days";

            MessageBox.Show($"Successfully Inserted!\n{ageMessage}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
