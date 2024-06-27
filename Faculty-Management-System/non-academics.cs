using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Faculty_Management_System
{
    public partial class non_academics : Form
    {

        /*String conString = "server=localhost;uid=root;pwd=password;database=groupproject";
        MySqlConnection con = new MySqlConnection();*/

        public non_academics()
        {
            InitializeComponent();
            LoadData();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=FCT_DB;Integrated Security=True;Encrypt=False;");

        private void LoadData()
        {
            try
            {
                con.Open();
                // Open the connection if it's not already open
                /* if (con.State == ConnectionState.Closed)
                 {
                     con.Open();
                 }*/

                string? query = "SELECT * FROM NonAcademics";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                dataTable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection when done
                con.Close();
            }
        }

        private void non_academics_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string email = emailtxt.Text;
            string id = idtxt.Text;
            string phoneNumber = phonetxt.Text;
            DateTime dateOfBirth = datetxt.Value;

            // Now you can use the 'Con' object to perform database operations
            // For example, you can open the connection:
            try
            {
                //Open the connection if it's not already open
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "INSERT INTO NonAcademics (name, email, staff_id, phone_no, dob) VALUES(@name, @email, @staff_id, @phone_no, @dob)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters to the command to prevent SQL injection
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@staff_id", id);
                    cmd.Parameters.AddWithValue("@phone_no", phoneNumber);
                    cmd.Parameters.AddWithValue("@dob", dateOfBirth);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data added successfully!");

                // Clear the text boxes
                nametxt.Text = "";
                emailtxt.Text = "";
                idtxt.Text = "";
                phonetxt.Text = "";
                datetxt.Value = DateTime.Now;

                // Refresh the DataGridView
                LoadData();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection when done
                con.Close();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            // Check if there is a selected row
            if (dataTable.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataTable.SelectedRows[0];

                // Get the value of the primary key column (staff_id assuming it's unique)
                string? staffId = selectedRow.Cells["staff_id"].Value.ToString();

                try
                {
                    // Open the connection
                    con.Open();

                    // SQL query to delete the row with the specified staff_id
                    string? query = "DELETE FROM NonAcademics WHERE staff_id = @staffId";

                    // Create and execute the MySqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add the parameter for staffId
                        cmd.Parameters.AddWithValue("@staffId", staffId);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the deletion was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Row deletion failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    con.Close();

                    // Reload the data to reflect the changes
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
