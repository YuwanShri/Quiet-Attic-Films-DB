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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms;Integrated Security=True;Encrypt=False;");

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Select form2 = new Select();
                form2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Transactions values (@Transaction_ID,@Transaction_Type,@Transaction_Date, @Client_ID)", con);
            cmd.Parameters.AddWithValue("@Transaction_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Transaction_Type", textBox2.Text);
            cmd.Parameters.AddWithValue("@Transaction_Date", textBox3.Text);
            cmd.Parameters.AddWithValue("@Client_ID", textBox4.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Inserted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Transactions set Transaction_Type=@Transaction_Type, Transaction_Date=@Transaction_Date where Transaction_ID=@Transaction_ID", con);
            cmd.Parameters.AddWithValue("@Transaction_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Transaction_Type", textBox2.Text);
            cmd.Parameters.AddWithValue("@Transaction_Date", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Transactions where Transaction_ID=@Transaction_ID", con);
            cmd.Parameters.AddWithValue("@Transaction_ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
