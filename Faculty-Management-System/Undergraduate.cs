using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Faculty_Management_System
{
    public partial class Undergraduate : Form
    {
        // Define the SqlConnection as a class-level variable
        private SqlConnection con;

        public Undergraduate()
        {
            InitializeComponent();
            // Initialize the SqlConnection with your connection string
            con = new SqlConnection("Data Source=LAPTOP-6PCEG0NK\\MSSQLSERVER01;Initial Catalog=FCT_MANAGEMENT_SYSTEM;Integrated Security=True;Encrypt=False");
            LoadData(); // Load data when the form initializes
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nametext.Text;
            string id = studentidtext.Text;
            string email = emailtext.Text;
            string phoneNumber = phonetext.Text;
            DateTime dateOfBirth = dobtext.Value;
            string gender = gendertext.Text; // Assuming you have a text box or control for gender
            string department = departmenttext.Text; // Assuming you have a text box or control for department
            string degree = degreetext.Text; // Assuming you have a text box or control for degree
            string level = leveltext.Text; // Assuming you have a text box or control for level
            byte[] photo = GetPhotoFromControl(photoControl); // Assuming you have a method to get the photo as byte array from a control

            try
            {
                // Open the connection if it's not already open
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = @"
                INSERT INTO [FCT_MANAGEMENT_SYSTEM].[dbo].[Undergraduate] 
                ([Name], [Student-id], [Email], [Phone], [Gender], [DOB], [Department], [Degree], [Level], [Photo])
                VALUES (@name, @studentId, @Email, @Phone, @Gender, @DOB, @Department, @Degree, @Level, @Photo)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters to the command to prevent SQL injection
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@studentId", id);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phoneNumber);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@DOB", dateOfBirth);
                    cmd.Parameters.AddWithValue("@Department", department);
                    cmd.Parameters.AddWithValue("@Degree", degree);
                    cmd.Parameters.AddWithValue("@Level", level);
                    cmd.Parameters.AddWithValue("@Photo", photo);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data added successfully!");
                LoadData(); // Refresh data grid after insertion
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

        // Method to get the photo as byte array from the control (example implementation)
        private byte[] GetPhotoFromControl(Control photoControl)
        {
            if (photoControl is PictureBox pictureBox && pictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            return null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Open the connection if it's not already open
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "SELECT [Name], [Student-id], [Email], [Phone], [Gender], [DOB], [Department], [Degree], [Level], [Photo] FROM [FCT_MANAGEMENT_SYSTEM].[dbo].[Undergraduate]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Assuming you have a DataGridView control named dataGridView1 to display the data
                dataGridView1.DataSource = dt;
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

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the file dialog properties
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string selectedImagePath = openFileDialog1.FileName;

                // Display the selected image in the PictureBox
                photoControl.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Check if there is a selected row
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the value of the primary key column (assuming it's Student-id and it's unique)
                string studentId = selectedRow.Cells["Student-id"].Value.ToString();

                try
                {
                    // Open the connection
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    // SQL query to delete the row with the specified Student-id
                    string query = "DELETE FROM [FCT_MANAGEMENT_SYSTEM].[dbo].[Undergraduate] WHERE [Student-id] = @studentId";

                    // Create and execute the SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add the parameter for studentId
                        cmd.Parameters.AddWithValue("@studentId", studentId);

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
        private void button2_Click(object sender, EventArgs e)
        {
            // Check if there is a selected row
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the value of the primary key column (assuming it's Student-id and it's unique)
                string studentId = selectedRow.Cells["Student-id"].Value.ToString();

                try
                {
                    // Open the connection
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    // SQL query to update the row with the specified Student-id
                    string query = @"
            UPDATE [FCT_MANAGEMENT_SYSTEM].[dbo].[Undergraduate] 
            SET [Name] = @name, [Email] = @Email, [Phone] = @Phone, [Gender] = @Gender, [DOB] = @DOB, 
            [Department] = @Department, [Degree] = @Degree, [Level] = @Level
            WHERE [Student-id] = @studentId";

                    // Create and execute the SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add the parameters for the updated values
                        cmd.Parameters.AddWithValue("@name", nametext.Text);
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@Email", emailtext.Text);
                        cmd.Parameters.AddWithValue("@Phone", phonetext.Text);
                        cmd.Parameters.AddWithValue("@Gender", gendertext.Text);
                        cmd.Parameters.AddWithValue("@DOB", dobtext.Value);
                        cmd.Parameters.AddWithValue("@Department", departmenttext.Text);
                        cmd.Parameters.AddWithValue("@Degree", degreetext.Text);
                        cmd.Parameters.AddWithValue("@Level", leveltext.Text);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the update was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row updated successfully!");

                            // Update the corresponding DataRow in the DataTable
                            DataRow rowToUpdate = ((DataRowView)selectedRow.DataBoundItem).Row;
                            rowToUpdate["Name"] = nametext.Text;
                            rowToUpdate["Email"] = emailtext.Text;
                            rowToUpdate["Phone"] = phonetext.Text;
                            rowToUpdate["Gender"] = gendertext.Text;
                            rowToUpdate["DOB"] = dobtext.Value;
                            rowToUpdate["Department"] = departmenttext.Text;
                            rowToUpdate["Degree"] = degreetext.Text;
                            rowToUpdate["Level"] = leveltext.Text;

                            // Refresh the DataGridView to reflect the changes
                            dataGridView1.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Row update failed!");
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
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

    }
}
