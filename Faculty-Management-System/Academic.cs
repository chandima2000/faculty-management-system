using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Faculty_Management_System
{
    public partial class Academic : Form
    {
        private SqlConnection conn;

        public Academic()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FCT_DB;Integrated Security=True;TrustServerCertificate=False;Encrypt=False");
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

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

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
                    using (SqlCommand cmd = new SqlCommand("DeleteAcademic", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
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
                    conn.Close();
                }
            }
            else if (dr == DialogResult.No)
            {
                // Nothing to do
            }
        }

        private DataTable GetAcademicList()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("listAcademic", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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
                conn.Close();
            }

            return dt;
        }

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
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("insertAcademic", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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
                conn.Close();
            }
        }

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
