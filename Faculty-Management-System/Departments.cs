using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculty_Management_System
{

    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=FCT_DB;Integrated Security=True;Encrypt=False;");

        private void Departments_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void search_button_click(object sender, EventArgs e)
        {
            String? dept_name = comboBox1.SelectedItem.ToString();
            String? degree = comboBox2.SelectedItem.ToString();
            String? ac_year = comboBox3.SelectedItem.ToString();
            String? level = comboBox4.SelectedItem.ToString();
            int student_count = 0;

            try
            {
                conn.Open();
                String query = "SELECT * FROM departments WHERE name=@dept_name AND degree=@degree AND year=@ac_year AND level=@level";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@dept_name", dept_name);
                cmd.Parameters.AddWithValue("@degree", degree);
                cmd.Parameters.AddWithValue("@ac_year", ac_year);
                cmd.Parameters.AddWithValue("@level", level);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    deptLabel.Text = reader["name"].ToString();
                    degreeLabel.Text = reader["degree"].ToString();
                    acYearLabel.Text = reader["year"].ToString();
                    levelLabel.Text = reader["level"].ToString();
                    student_count = Convert.ToInt32(reader["student_count"]);
                    stuCountLabel.Text = student_count.ToString();
                }
                else
                {
                    MessageBox.Show("No records found.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
    }


