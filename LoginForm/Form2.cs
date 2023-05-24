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

namespace LoginForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HASIRAK\\SQLEXPRESS;Initial Catalog=burgerhut;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Registration]
            ([Username]
            ,[Password]
            ,[ConfirmPassword])

        VALUES
            ('" + RFName.Text + "','" + RPassword.Text + "', '" + RCPassword.Text + "')", con);
                con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registered Succefully!");

            this.Hide();
            new Login().Show();
        }

        private void RFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void RPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void RCPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
