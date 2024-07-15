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
        private SqlConnection con;

        public Undergraduate()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=LAPTOP-6PCEG0NK\\MSSQLSERVER01;Initial Catalog=FCT_DB;Integrated Security=True;Encrypt=False");
            LoadData();
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
            string gender = gendertext.Text;
            string department = departmenttext.Text;
            string degree = degreetext.Text;
            string level = leveltext.Text;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = @"
                INSERT INTO [FCT_DB].[dbo].[Undergraduates_1] 
                ([Name], [Student_id], [Email], [Phone], [Gender], [DOB], [Department], [Degree], [E_Level])
                VALUES (@name, @studentId, @Email, @Phone, @Gender, @DOB, @Department, @Degree, @Level)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@studentId", id);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phoneNumber);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@DOB", dateOfBirth);
                    cmd.Parameters.AddWithValue("@Department", department);
                    cmd.Parameters.AddWithValue("@Degree", degree);
                    cmd.Parameters.AddWithValue("@Level", level);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data added successfully!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

       

        private void LoadData()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "SELECT [Name], [Student_id], [Email], [Phone], [Gender], [DOB], [Department], [Degree], [E_Level] FROM [FCT_DB].[dbo].[Undergraduates_1]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string studentId = selectedRow.Cells["Student_id"].Value.ToString();

                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    string query = "DELETE FROM [FCT_DB].[dbo].[Undergraduates_1] WHERE [Student_id] = @studentId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);

                        int rowsAffected = cmd.ExecuteNonQuery();

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
                    con.Close();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                nametext.Text = row.Cells["Name"].Value.ToString();
                studentidtext.Text = row.Cells["Student_id"].Value.ToString();
                emailtext.Text = row.Cells["Email"].Value.ToString();
                phonetext.Text = row.Cells["Phone"].Value.ToString();
                dobtext.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
                gendertext.Text = row.Cells["Gender"].Value.ToString();
                departmenttext.Text = row.Cells["Department"].Value.ToString();
                degreetext.Text = row.Cells["Degree"].Value.ToString();
                leveltext.Text = row.Cells["E_Level"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string studentId = selectedRow.Cells["Student_id"].Value.ToString();

                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    string query = @"
                    UPDATE [FCT_DB].[dbo].[Undergraduates_1] 
                    SET [Name] = @name, [Email] = @Email, [Phone] = @Phone, [Gender] = @Gender, [DOB] = @DOB, 
                    [Department] = @Department, [Degree] = @Degree, [E_Level] = @Level
                    WHERE [Student_id] = @studentId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", nametext.Text);
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@Email", emailtext.Text);
                        cmd.Parameters.AddWithValue("@Phone", phonetext.Text);
                        cmd.Parameters.AddWithValue("@Gender", gendertext.Text);
                        cmd.Parameters.AddWithValue("@DOB", dobtext.Value);
                        cmd.Parameters.AddWithValue("@Department", departmenttext.Text);
                        cmd.Parameters.AddWithValue("@Degree", degreetext.Text);
                        cmd.Parameters.AddWithValue("@Level", leveltext.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row updated successfully!");
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
                    con.Close();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Clear text fields
            nametext.Text = "";
            studentidtext.Text = "";
            emailtext.Text = "";
            phonetext.Text = "";
            dobtext.Value = DateTime.Today; // Reset date to today
            gendertext.Text = "";
            departmenttext.Text = "";
            degreetext.Text = "";
            leveltext.Text = "";

           
        }
    }
}
