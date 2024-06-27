using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;


namespace Faculty_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=FCT_DB;Integrated Security=True;Encrypt=True;");

        private void exit_login_form_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            String username, password;
            

            try
            {
                conn.Open();
                String query = "SELECT * FROM Login WHERE username = '"+textBox1.Text+"' AND password = '"+textBox2.Text+"'";
                SqlDataAdapter sda = new(query,conn);

                DataTable dtable = new();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0 )
                {
                    username = textBox1.Text;
                    password = textBox2.Text;

                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Something went Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
