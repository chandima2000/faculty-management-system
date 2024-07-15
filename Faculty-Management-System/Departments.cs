using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace Faculty_Management_System
{
    public partial class Departments : Form
    {
        private SqlConnection conn;
        public Departments()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=LAPTOP-6PCEG0NK\\MSSQLSERVER01;Initial Catalog=FCT_DB;Integrated Security=True;Encrypt=False");
            // Add predefined items to the combo boxes
            InitializeComboBoxItems();
        }

        private void InitializeComboBoxItems()
        {
            // Departments
            comboBox1.Items.AddRange(new string[]
            {
                "Computer System Engineering",
                "Applied Computing",
                "Software Engineering"
            });

            // Degrees
            comboBox2.Items.AddRange(new string[]
            {
                "Computer Science",
                "Computing & Technology",
                "Engineering Technology"
            });

            // Levels
            comboBox4.Items.AddRange(new string[]
            {
                "Level 1",
                "Level 2",
                "Level 3",
                "Level 4"
            });

            // Ensure no default selection
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }


        private void Departments_Load(object sender, EventArgs e)
        {
            // Load department, degree, and level data into combo boxes
            LoadComboBoxData();
        }
        private void LoadComboBoxData()
        {
            try
            {
                conn.Open();

                // Load departments
                string deptQuery = "SELECT DISTINCT [Department] FROM [Undergraduates_1]";
                SqlDataAdapter deptAdapter = new SqlDataAdapter(deptQuery, conn);
                DataTable deptTable = new DataTable();
                deptAdapter.Fill(deptTable);
                comboBox1.DataSource = deptTable;
                comboBox1.DisplayMember = "Department";
                comboBox1.ValueMember = "Department";
                comboBox1.SelectedIndex = -1; // Ensure no default selection

                // Check department items
                Console.WriteLine("Departments loaded: " + deptTable.Rows.Count);
                foreach (DataRow row in deptTable.Rows)
                {
                    Console.WriteLine(row["Department"]);
                }

                // Load degrees
                string degreeQuery = "SELECT DISTINCT [Degree] FROM [Undergraduates_1]";
                SqlDataAdapter degreeAdapter = new SqlDataAdapter(degreeQuery, conn);
                DataTable degreeTable = new DataTable();
                degreeAdapter.Fill(degreeTable);
                comboBox2.DataSource = degreeTable;
                comboBox2.DisplayMember = "Degree";
                comboBox2.ValueMember = "Degree";
                comboBox2.SelectedIndex = -1; // Ensure no default selection

                // Check degree items
                Console.WriteLine("Degrees loaded: " + degreeTable.Rows.Count);
                foreach (DataRow row in degreeTable.Rows)
                {
                    Console.WriteLine(row["Degree"]);
                }

                // Load levels
                string levelQuery = "SELECT DISTINCT [E_Level] FROM [Undergraduates_1]";
                SqlDataAdapter levelAdapter = new SqlDataAdapter(levelQuery, conn);
                DataTable levelTable = new DataTable();
                levelAdapter.Fill(levelTable);
                comboBox4.DataSource = levelTable;
                comboBox4.DisplayMember = "E_Level";
                comboBox4.ValueMember = "E_Level";
                comboBox4.SelectedIndex = -1; // Ensure no default selection

                // Check level items
                Console.WriteLine("Levels loaded: " + levelTable.Rows.Count);
                foreach (DataRow row in levelTable.Rows)
                {
                    Console.WriteLine(row["E_Level"]);
                }

                // Ensure combo boxes are refreshed
                comboBox1.Refresh();
                comboBox2.Refresh();
                comboBox4.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void search_button_click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? deptName = comboBox1.SelectedValue?.ToString();
            string? degree = comboBox2.SelectedValue?.ToString();
            string? level = comboBox4.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(deptName) || string.IsNullOrEmpty(degree) || string.IsNullOrEmpty(level))
            {
                MessageBox.Show("Please select values for Department, Degree, and Level.");
                return;
            }

            try
            {
                conn.Open();
                string query = @"
                SELECT COUNT(*) AS student_count
                FROM [Undergraduates_1]
                WHERE [Department] = @deptName AND [Degree] = @degree AND [E_Level] = @level";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@deptName", deptName);
                cmd.Parameters.AddWithValue("@degree", degree);
                cmd.Parameters.AddWithValue("@level", level);

                int studentCount = (int)cmd.ExecuteScalar();

                deptLabel.Text = deptName;
                degreeLabel.Text = degree;
                acYearLabel.Text = level;
                stuCountLabel.Text = studentCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the combo boxes and labels
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

            deptLabel.Text = string.Empty;
            degreeLabel.Text = string.Empty;
            acYearLabel.Text = string.Empty;
            stuCountLabel.Text = string.Empty;
        }
    }
}
