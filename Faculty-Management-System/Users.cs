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

namespace Faculty_Management_System
{
    public partial class Users : Form
    {
        private SqlConnection con;

        public Users()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.;Initial Catalog=FCT_DB;Integrated Security=True;Encrypt=False;");
            LoadData();
        }

        // Define text boxes
        private TextBox? UserIDTextBox;
        private TextBox? NameTextBox;
        private TextBox? PositionTextBox;
        private TextBox? PhoneTextBox;
        private TextBox? EmailTextBox;
        private TextBox? PasswordTextBox;

     

        private void LoadData()
        {
         
            try
            {
                con.Open();
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void AddRecord()
        {
         

            try
            {
                string query = "INSERT INTO Users (UserID, Name, Position, Phone, Email, Password) VALUES (@UserID, @Name, @Position, @Phone, @Email, @Password)";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@UserID", UserIDTextBox?.Text);
                    command.Parameters.AddWithValue("@Name", NameTextBox?.Text);
                    command.Parameters.AddWithValue("@Position", PositionTextBox?.Text);
                    command.Parameters.AddWithValue("@Phone", PhoneTextBox?.Text);
                    command.Parameters.AddWithValue("@Email", EmailTextBox?.Text);
                    command.Parameters.AddWithValue("@Password", PasswordTextBox?.Text);

                   
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Data added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            LoadData(); // Refresh the data grid view
        }

        private void EditRecord()
        {
            if (string.IsNullOrEmpty(UserIDTextBox?.Text))
            {
                MessageBox.Show("Please enter a UserID.");
                return;
            }

            try
            {
                string query = "UPDATE Users SET Name=@Name, Position=@Position, Phone=@Phone, Email=@Email, Password=@Password WHERE ID=@UserID";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@UserID", UserIDTextBox.Text);
                    command.Parameters.AddWithValue("@Name", NameTextBox?.Text);
                    command.Parameters.AddWithValue("@Position", PositionTextBox?.Text);
                    command.Parameters.AddWithValue("@Phone", PhoneTextBox?.Text);
                    command.Parameters.AddWithValue("@Email", EmailTextBox?.Text);
                    command.Parameters.AddWithValue("@Password", PasswordTextBox?.Text);
                  

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            LoadData(); // Refresh the data grid view
        }

        private void DeleteRecord()
        {
            if (string.IsNullOrEmpty(UserIDTextBox?.Text))
            {
                MessageBox.Show("Please enter a UserID.");
                return;
            }

            try
            {
                string query = "DELETE FROM Users WHERE ID=@UserID";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@UserID", UserIDTextBox.Text);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            LoadData(); // Refresh the data grid view
        }

        private void Users_Load(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EditRecord();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }


    }
}
