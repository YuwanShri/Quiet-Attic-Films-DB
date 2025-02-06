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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms;Integrated Security=True;Encrypt=False;");

        private void label4_Click(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("INSERT INTO Staff VALUES (@Staff_ID, @Roles, @Contact_Number, @Fee_per_day )", con);
            cmd.Parameters.AddWithValue("@Staff_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Roles", textBox6.Text);
            cmd.Parameters.AddWithValue("@Contact_Number", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Fee_per_day", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();

            SqlCommand cmdProductionStaff = new SqlCommand("insert into Production_Staff values (@First_Name, @Last_Name, @Production_ID, @Staff_ID)", con);
            cmdProductionStaff.Parameters.AddWithValue("@First_Name", textBox2.Text);
            cmdProductionStaff.Parameters.AddWithValue("@Last_Name", textBox5.Text);
            cmdProductionStaff.Parameters.AddWithValue("@Staff_ID", int.Parse(textBox1.Text));
            cmdProductionStaff.Parameters.AddWithValue("@Production_ID", int.Parse(textBox7.Text));
            cmdProductionStaff.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Inserted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Staff SET Roles=@Roles, Contact_Number=@Contact_Number, Fee_per_day=@Fee_per_day WHERE Staff_ID=@Staff_ID", con);
            cmd.Parameters.AddWithValue("@Staff_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Roles", textBox6.Text);
            cmd.Parameters.AddWithValue("@Contact_Number", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Fee_per_day", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();

            SqlCommand cmdProductionStaff = new SqlCommand("UPDATE Production_Staff SET First_Name=@First_Name, Last_Name=@Last_Name, Production_ID=@Production_ID, Staff_ID=@Staff_ID WHERE Staff_ID=@Staff_ID", con);

            cmdProductionStaff.Parameters.AddWithValue("@First_Name", textBox2.Text);
            cmdProductionStaff.Parameters.AddWithValue("@Last_Name", textBox5.Text);
            cmdProductionStaff.Parameters.AddWithValue("@Staff_ID", int.Parse(textBox1.Text));
            cmdProductionStaff.Parameters.AddWithValue("@Production_ID", int.Parse(textBox7.Text));
            cmdProductionStaff.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();

            SqlCommand cmdProductionStaff = new SqlCommand("Delete Production_Staff where Staff_ID=@Staff_ID", con);
            cmdProductionStaff.Parameters.AddWithValue("@Staff_ID", int.Parse(textBox1.Text));
            cmdProductionStaff.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand("Delete Staff where Staff_ID=@Staff_ID", con);
            cmd.Parameters.AddWithValue("@Staff_ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
