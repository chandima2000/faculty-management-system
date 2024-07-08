using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Faculty_Management_System
{
    public partial class Academic : Form
    {
       
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FCT_DB;Integrated Security=True;TrustServerCertificate=False;Encrypt=False");

        public Academic()
        {
            InitializeComponent();
           
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 50, 50, 50);
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
            panel2.BackColor = Color.FromArgb(160, 0, 0, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(80, 255, 255, 255);
        }

        // UPDATE ROW
        private void UpdateAcademic(string staffNo, string name, string dep, string degree)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }


                string query = "UPDATE academic SET name = @name, dep = @dep, degree = @degree WHERE staffNo = @staffNo";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@staffNo", staffNo);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@dep", dep);
                    cmd.Parameters.AddWithValue("@degree", degree);

                    // Debugging: Print the parameters to check if they match expected values
                    MessageBox.Show($"Updating record with staffNo: {staffNo}, name: {name}, dep: {dep}, degree: {degree}");

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully updated");
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated. Please check if the staff number exists.");
                    }

                    BindDataToDataGridView(); // Refresh the DataGridView
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

        }


        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to update row?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string staffNo = textBox2.Text;
                string name = textBox1.Text;
                string dep = textBox3.Text;
                string degree = textBox4.Text;

                if (string.IsNullOrWhiteSpace(staffNo) ||
                    string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(dep))
                {
                    MessageBox.Show("Please enter valid data.");
                    return;
                }

                UpdateAcademic(staffNo, name, dep, degree);
            }
            else if (dr == DialogResult.No)
            {
                // Nothing to do
            }
        }
        //END OF UPDATE ROW

        //RETURN TO HOME PAGE

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        //END OF RETURN TO HOME PAGE

        ////END OF DELETE ROW FROM THE TABLE
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete row?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string staffNo = textBox2.Text;

                if (string.IsNullOrWhiteSpace(staffNo))
                {
                    MessageBox.Show("Please enter a valid staff number.");
                    return;
                }

                try
                {
                    conn.Open();
                    string? query = "DELETE FROM academic WHERE staffNo = @staffNo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@staffNo", staffNo);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Successfully Deleted.");
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
            else if (dr == DialogResult.No)
            {
                // Nothing to do
            }
        }

        //END OF DELETE ROW FROM THE TABLE

        // SHOW ALL DATA

        private DataTable GetAcademicList()
        {
            DataTable dt = new DataTable();

            try
            {

                conn.Open();

                string? query = "SELECT * FROM academic";
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

        // END OF SHOW ALL DATA

        // INSERT OPERATION

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string staffNo = textBox2.Text;
            string dep = textBox3.Text;
            string degree = textBox4.Text;

            if (string.IsNullOrWhiteSpace(name) ||
               string.IsNullOrWhiteSpace(staffNo) ||
               string.IsNullOrWhiteSpace(dep))
            {
                MessageBox.Show("Please enter valid data.");
                return;
            }

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "INSERT INTO academic (name, staffNo, dep, degree) VALUES(@name, @staffNo, @dep, @degree)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@staffNo", staffNo);
                    cmd.Parameters.AddWithValue("@dep", dep);
                    cmd.Parameters.AddWithValue("@degree", degree);
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
            BindDataToDataGridView();
        }

        //CLOSE INSERT OPERATION

        private void BindDataToDataGridView()
        {

     
            DataTable dt = GetAcademicList();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
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
    }
}
