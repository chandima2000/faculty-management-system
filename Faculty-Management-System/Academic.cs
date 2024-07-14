using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Faculty_Management_System
{
    public partial class Academic : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-6PCEG0NK\\MSSQLSERVER01;Initial Catalog=FCT_DB;Integrated Security=True;Encrypt=False");

        public Academic()
        {
            InitializeComponent();
            dataGridView1.Hide(); // Initially hide the DataGridView
            BindDataToDataGridView(); // Load data into the DataGridView

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Academic_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            BindDataToDataGridView();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        

        // UPDATE ROW
        private void UpdateAcademic(string staffNo, string name, string dep, string degree, string phone, string email)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "UPDATE academic SET name = @name, dep = @dep, degree = @degree, phone = @phone, email = @email WHERE staffNo = @staffNo";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@dep", dep);
                    cmd.Parameters.AddWithValue("@degree", degree);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@staffNo", staffNo);

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
                conn.Close();
                BindDataToDataGridView();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        //END OF UPDATE ROW

        //RETURN TO HOME PAGE

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        //END OF RETURN TO HOME PAGE

        ////DELETE ROW FROM THE TABLE
        // DELETE ROW
        private void DeleteAcademic(string staffNo)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "DELETE FROM academic WHERE staffNo = @staffNo";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@staffNo", staffNo);

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
                conn.Close();
                BindDataToDataGridView();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        // SHOW ALL DATA

        private DataTable GetAcademicList()
        {
            DataTable dt = new DataTable();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM academic";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return dt;
        }

        // INSERT OPERATION
        private void InsertAcademic(string name, string staffNo, string dep, string degree, string phone, string email)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "INSERT INTO academic (name, staffNo, dep, degree, phone, email) VALUES(@name, @staffNo, @dep, @degree, @phone, @email)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@staffNo", staffNo);
                    cmd.Parameters.AddWithValue("@dep", dep);
                    cmd.Parameters.AddWithValue("@degree", degree);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Successfully inserted");
                BindDataToDataGridView(); // Refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BindDataToDataGridView()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM academic";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                            dataGridView1.Show(); // Show the DataGridView after data binding
                        }
                        else
                        {
                            MessageBox.Show("No data found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            dataGridView1.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string staffNo = textBox2.Text;
            string dep = departmenttext.Text; // Assuming departmenttext is your ComboBox for department
            string degree = degreetext.Text; // Assuming degreetext is your ComboBox for degree
            string phone = textBox3.Text;
            string email = textBox4.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(staffNo) || string.IsNullOrWhiteSpace(dep))
            {
                MessageBox.Show("Please enter valid data.");
                return;
            }

            InsertAcademic(name, staffNo, dep, degree, phone, email);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string staffNo = selectedRow.Cells["staffNo"].Value.ToString();

                string name = textBox1.Text;
                string dep = departmenttext.Text; // Assuming departmenttext is your ComboBox for department
                string degree = degreetext.Text; // Assuming degreetext is your ComboBox for degree
                string phone = textBox3.Text;
                string email = textBox4.Text;

                UpdateAcademic(staffNo, name, dep, degree, phone, email);
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string staffNo = selectedRow.Cells["staffNo"].Value.ToString();

                DeleteAcademic(staffNo);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            departmenttext.SelectedIndex = -1; // Clear selection in department combo box
            degreetext.SelectedIndex = -1; // Clear selection in degree combo box
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
