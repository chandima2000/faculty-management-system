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
    public partial class non_academics : Form
    {


        public non_academics()
        {
            InitializeComponent();
            LoadData();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-6PCEG0NK\\MSSQLSERVER01;Initial Catalog=FCT_DB;Integrated Security=True;Encrypt=False");

        private void LoadData()
        {
            try
            {

                // Open the connection if it's not already open
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

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

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

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

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optionally, load selected row data into text boxes
            if (dataTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataTable.SelectedRows[0];
                nametxt.Text = selectedRow.Cells["name"].Value.ToString();
                emailtxt.Text = selectedRow.Cells["email"].Value.ToString();
                idtxt.Text = selectedRow.Cells["staff_id"].Value.ToString();
                phonetxt.Text = selectedRow.Cells["phone_no"].Value.ToString();
                datetxt.Value = Convert.ToDateTime(selectedRow.Cells["dob"].Value);
                gendertext.Text = selectedRow.Cells["gender"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string email = emailtxt.Text;
            string id = idtxt.Text;
            string phoneNumber = phonetxt.Text;
            DateTime dateOfBirth = datetxt.Value;
            string gender = gendertext.Text;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "INSERT INTO NonAcademics (name, email, staff_id, phone_no, dob, gender) VALUES(@name, @email, @staff_id, @phone_no, @dob, @gender)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@staff_id", id);
                    cmd.Parameters.AddWithValue("@phone_no", phoneNumber);
                    cmd.Parameters.AddWithValue("@dob", dateOfBirth);
                    cmd.Parameters.AddWithValue("@gender", gender);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data added successfully!");
                ClearFields();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataTable.SelectedRows[0];
                string staffId = selectedRow.Cells["staff_id"].Value.ToString();

                try
                {
                    con.Open();
                    string query = @"
                        UPDATE NonAcademics 
                        SET name = @name, email = @email,
                            phone_no = @phone_no, dob = @dob, gender = @gender
                        WHERE staff_id = @staffId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", nametxt.Text);
                        cmd.Parameters.AddWithValue("@email", emailtxt.Text);
                        cmd.Parameters.AddWithValue("@staffId", staffId);
                        cmd.Parameters.AddWithValue("@phone_no", phonetxt.Text);
                        cmd.Parameters.AddWithValue("@dob", datetxt.Value);
                        cmd.Parameters.AddWithValue("@gender", gendertext.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row updated successfully!");
                            UpdateDataGridViewRow(selectedRow);
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
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataTable.SelectedRows[0];
                string staffId = selectedRow.Cells["staff_id"].Value.ToString();

                try
                {
                    con.Open();
                    string query = "DELETE FROM NonAcademics WHERE staff_id = @staffId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@staffId", staffId);
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

        private void button4_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            nametxt.Text = "";
            emailtxt.Text = "";
            idtxt.Text = "";
            phonetxt.Text = "";
            gendertext.Text = "";
            datetxt.Value = DateTime.Now;
        }

        private void UpdateDataGridViewRow(DataGridViewRow selectedRow)
        {
            selectedRow.Cells["name"].Value = nametxt.Text;
            selectedRow.Cells["email"].Value = emailtxt.Text;
            selectedRow.Cells["phone_no"].Value = phonetxt.Text;
            selectedRow.Cells["dob"].Value = datetxt.Value;
            selectedRow.Cells["gender"].Value = gendertext.Text;
            dataTable.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        
    }
}
