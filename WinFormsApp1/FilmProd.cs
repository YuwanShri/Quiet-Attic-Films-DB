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

namespace WinFormsApp1
{
    public partial class FilmProd : Form
    {
        public FilmProd()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms;Integrated Security=True;Encrypt=False;");


        private void label2_Click(object sender, EventArgs e)
        {

        }

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

            SqlCommand cmd = new SqlCommand("INSERT INTO Film_Production (Production_ID, Production_Type, Number_of_days_spent, Release_Date) VALUES (@Production_ID, @Production_Type, @Number_of_days_spent, @Release_Date)", con);

            cmd.Parameters.AddWithValue("@Production_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Production_Type", textBox2.Text);
            cmd.Parameters.AddWithValue("@Number_of_days_spent", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Release_Date", textBox4.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Inserted");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Film_Production set Production_Type=@Production_Type, Number_of_days_spent=@Number_of_days_spent, Release_Date=@Release_Date where Production_ID=@Production_ID", con);
            cmd.Parameters.AddWithValue("@Production_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Production_Type", textBox2.Text);
            cmd.Parameters.AddWithValue("@Number_of_days_spent", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Release_Date", textBox4.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Film_Production where Production_ID=@Production_ID", con);
            cmd.Parameters.AddWithValue("@Production_ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
