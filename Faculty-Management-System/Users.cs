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
            con = new SqlConnection("Data Source=LAPTOP-6PCEG0NK\\MSSQLSERVER01;Initial Catalog=FCT_DB;Integrated Security=True;Encrypt=False");
            // Assign the form's text boxes to the variables
            UserIDTextBox = textBox1;
            NameTextBox = textBox2;
            PositionTextBox = textBox3;
            PhoneTextBox = textBox4;
            UsernameTextBox = textBox5;
            PasswordTextBox = textBox6;

            LoadData();


        }

        // Define text boxes
        private TextBox UserIDTextBox;
        private TextBox NameTextBox;
        private TextBox PositionTextBox;
        private TextBox PhoneTextBox;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;



        private void LoadData()
        {
            try
            {
                con.Open();
                string query = "SELECT UserID, Name, Position, Phone, Username, Password FROM Users_1";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable; // Bind data to the DataGridView
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
                string query = "INSERT INTO Users_1 (UserID, Name, Position, Phone, Username, Password) " +
                               "VALUES (@UserID, @Name, @Position, @Phone, @Username, @Password)";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@UserID", UserIDTextBox.Text);
                    command.Parameters.AddWithValue("@Name", NameTextBox.Text);
                    command.Parameters.AddWithValue("@Position", PositionTextBox.Text);
                    command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
                    command.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                    command.Parameters.AddWithValue("@Password", PasswordTextBox.Text);

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data added successfully!");
                        LoadData(); // Refresh the data grid view
                        ClearFields(); // Clear the fields after adding
                    }
                    else
                    {
                        MessageBox.Show("Data not added. No rows affected.");
                    }
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

        }

        private void EditRecord()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string userId = selectedRow.Cells["UserID"].Value.ToString();

            try
            {
                string query = "UPDATE Users_1 SET Name=@Name, Position=@Position, Phone=@Phone, Username=@Username, Password=@Password WHERE UserID=@UserID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@Name", NameTextBox.Text);
                    command.Parameters.AddWithValue("@Position", PositionTextBox.Text);
                    command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
                    command.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                    command.Parameters.AddWithValue("@Password", PasswordTextBox.Text);

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data updated successfully!");

                        // After updating, reload the data into the DataGridView
                        LoadData();

                        // Clear the fields after updating
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Data update failed. No rows affected.");
                    }
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
        }

        private void DeleteRecord()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string userId = selectedRow.Cells["UserID"].Value.ToString();

            try
            {
                string query = "DELETE FROM Users_1 WHERE UserID=@UserID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@UserID", userId);

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data deleted successfully!");
                        LoadData(); // Refresh the data grid view
                        ClearFields(); // Clear the fields after deleting
                    }
                    else
                    {
                        MessageBox.Show("Data deletion failed. No rows affected.");
                    }
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
        }
        private void ClearFields()
        {
            UserIDTextBox.Text = "";
            NameTextBox.Text = "";
            PositionTextBox.Text = "";
            PhoneTextBox.Text = "";
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void Users_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                UserIDTextBox.Text = row.Cells["UserID"].Value.ToString();
                NameTextBox.Text = row.Cells["Name"].Value.ToString();
                PositionTextBox.Text = row.Cells["Position"].Value.ToString();
                PhoneTextBox.Text = row.Cells["Phone"].Value.ToString();
                UsernameTextBox.Text = row.Cells["Username"].Value.ToString();
                PasswordTextBox.Text = row.Cells["Password"].Value.ToString();
            }
        }
    }
}
