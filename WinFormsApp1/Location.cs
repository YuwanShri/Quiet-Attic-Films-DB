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
    public partial class Location : Form
    {
        public Location()
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
            SqlCommand cmd = new SqlCommand("insert into Locations values (@Location_ID, @Locations, @Production_ID)", con);
            cmd.Parameters.AddWithValue("@Location_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Locations", textBox2.Text);
            cmd.Parameters.AddWithValue("@Production_ID", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Inserted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Locations set Locations=@Locations, Production_ID=@Production_ID where Location_ID=@Location_ID", con);
            cmd.Parameters.AddWithValue("@Location_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Locations", textBox2.Text);
            cmd.Parameters.AddWithValue("@Production_ID", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Locations where Location_ID=@Location_ID", con);
            cmd.Parameters.AddWithValue("@Location_ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
        }
    }
}
