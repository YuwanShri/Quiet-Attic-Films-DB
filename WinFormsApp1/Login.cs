using System;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VILJ0BO\\SQLEXPRESS;Initial Catalog=QuietAtticFilms1;Integrated Security=True;");

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter the Username");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter the Password");
            }
            else
            {
                try
                {
                    
                    SqlCommand cmd = new SqlCommand("select * from Login where Username = @Username and Password = @Password", conn);
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if(dt.Rows.Count > 0)
                    {
                        //MessageBox.Show("Login Successful");
                        Select form2 = new Select();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                        textBox1.Clear();
                        textBox2.Clear();
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
