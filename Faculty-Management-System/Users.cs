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
        private string connectionString = "Data Source=DESKTOP-ELFA8OA\\SQLEXPRESS;Initial Catalog=FacultyManagement;Integrated Security=True;TrustServerCertificate=True";

        public Users()
        {
            InitializeComponent();
            InitializeCustomComponents();
            LoadData();
        }

        // Define text boxes
        private TextBox UserIDTextBox;
        private TextBox NameTextBox;
        private TextBox PositionTextBox;
        private TextBox PhoneTextBox;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private TextBox PhotoTextBox;

        // Define the DataGridView for displaying users
        private DataGridView usersDataGridView;

        private void InitializeCustomComponents()
        {
            this.UserIDTextBox = new TextBox() { Location = new Point(100, 20), Size = new Size(200, 20), Name = "UserIDTextBox" };
            this.NameTextBox = new TextBox() { Location = new Point(100, 60), Size = new Size(200, 20), Name = "NameTextBox" };
            this.PositionTextBox = new TextBox() { Location = new Point(100, 100), Size = new Size(200, 20), Name = "PositionTextBox" };
            this.PhoneTextBox = new TextBox() { Location = new Point(100, 140), Size = new Size(200, 20), Name = "PhoneTextBox" };
            this.EmailTextBox = new TextBox() { Location = new Point(100, 180), Size = new Size(200, 20), Name = "EmailTextBox" };
            this.PasswordTextBox = new TextBox() { Location = new Point(100, 220), Size = new Size(200, 20), Name = "PasswordTextBox" };
            this.PhotoTextBox = new TextBox() { Location = new Point(100, 260), Size = new Size(200, 20), Name = "PhotoTextBox" };

            this.usersDataGridView = new DataGridView() { Location = new Point(320, 20), Size = new Size(400, 300), Name = "usersDataGridView" };

            this.Controls.Add(this.UserIDTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PhotoTextBox);
            this.Controls.Add(this.usersDataGridView);
        }

        private void LoadData()
        {
            if (usersDataGridView == null)
            {
                MessageBox.Show("DataGridView is not initialized.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                usersDataGridView.DataSource = dataTable;
            }
        }

        private void AddRecord()
        {
            // Check if any required fields are empty
            if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(PositionTextBox.Text) ||
                string.IsNullOrEmpty(PhoneTextBox.Text) || string.IsNullOrEmpty(EmailTextBox.Text) ||
                string.IsNullOrEmpty(PasswordTextBox.Text) || string.IsNullOrEmpty(PhotoTextBox.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Name, Position, Phone, Email, Password, Photo) VALUES (@Name, @Position, @Phone, @Email, @Password, @Photo)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", NameTextBox.Text);
                    command.Parameters.AddWithValue("@Position", PositionTextBox.Text);
                    command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
                    command.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                    command.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                    command.Parameters.AddWithValue("@Photo", PhotoTextBox.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            LoadData(); // Refresh the data grid view
        }

        private void EditRecord()
        {
            if (string.IsNullOrEmpty(UserIDTextBox.Text))
            {
                MessageBox.Show("Please enter a UserID.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Name=@Name, Position=@Position, Phone=@Phone, Email=@Email, Password=@Password, Photo=@Photo WHERE ID=@UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserIDTextBox.Text);
                    command.Parameters.AddWithValue("@Name", NameTextBox.Text);
                    command.Parameters.AddWithValue("@Position", PositionTextBox.Text);
                    command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
                    command.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                    command.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                    command.Parameters.AddWithValue("@Photo", PhotoTextBox.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            LoadData(); // Refresh the data grid view
        }

        private void DeleteRecord()
        {
            if (string.IsNullOrEmpty(UserIDTextBox.Text))
            {
                MessageBox.Show("Please enter a UserID.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Users WHERE ID=@UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserIDTextBox.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            LoadData(); // Refresh the data grid view
        }

        private void Users_Load(object sender, EventArgs e)
        {
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
    }
}
