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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client values (@Client_ID,@Client_Name,@Email_Address)", con);
            cmd.Parameters.AddWithValue("@Client_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Client_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Mobile_Number", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email_Address", textBox4.Text);
            cmd.ExecuteNonQuery();

            SqlCommand cmdClientContact = new SqlCommand("insert into Client_Contact values (@Mobile_Number, @Client_ID)", con);
            cmdClientContact.Parameters.AddWithValue("@Mobile_Number", textBox3.Text);
            cmdClientContact.Parameters.AddWithValue("@Client_ID", int.Parse(textBox1.Text));
            cmdClientContact.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Inserted");
        }

        private void Form3_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Client set Client_Name=@Client_Name, Email_Address=@Email_Address where Client_ID=@Client_ID", con);
            cmd.Parameters.AddWithValue("@Client_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Client_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Email_Address", textBox4.Text);
            cmd.ExecuteNonQuery();

            SqlCommand cmdClientContact = new SqlCommand("Update Client_Contact set Mobile_Number=@Mobile_Number where Client_ID=@Client_ID", con);
            cmdClientContact.Parameters.AddWithValue("@Mobile_Number", textBox3.Text);
            cmdClientContact.Parameters.AddWithValue("@Client_ID", int.Parse(textBox1.Text));
            cmdClientContact.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;Encrypt=False;");
            con.Open();

            SqlCommand cmdClientContact = new SqlCommand("DELETE FROM Client_Contact WHERE Client_ID = @Client_ID", con);
            cmdClientContact.Parameters.AddWithValue("@Client_ID", int.Parse(textBox1.Text));
            cmdClientContact.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand("Delete Client where Client_ID=@Client_ID", con);
            cmd.Parameters.AddWithValue("@Client_ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
