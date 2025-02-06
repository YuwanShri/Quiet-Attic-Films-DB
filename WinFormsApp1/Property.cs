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
    public partial class Property : Form
    {
        public Property()
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
            SqlCommand cmd = new SqlCommand("insert into Property values (@Property_ID,@Property_Type)", con);
            cmd.Parameters.AddWithValue("@Property_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Property_Type", textBox2.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Inserted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Property set Property_Type=@Property_Type where Property_ID=@Property_ID", con);
            cmd.Parameters.AddWithValue("@Property_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Property_Type", textBox2.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Property where Property_ID=@Property_ID", con);
            cmd.Parameters.AddWithValue("@Property_ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
