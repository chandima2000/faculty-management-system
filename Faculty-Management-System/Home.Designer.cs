namespace Faculty_Management_System
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exit_login_form = new Label();
            academic = new Button();
            non_academic = new Button();
            department = new Button();
            undergraduate = new Button();
            users = new Button();
            logout_btn = new Button();
            SuspendLayout();
            // 
            // exit_login_form
            // 
            exit_login_form.AutoSize = true;
            exit_login_form.BackColor = Color.Red;
            exit_login_form.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit_login_form.ForeColor = SystemColors.ControlLightLight;
            exit_login_form.Location = new Point(935, 12);
            exit_login_form.Name = "exit_login_form";
            exit_login_form.Size = new Size(28, 32);
            exit_login_form.TabIndex = 1;
            exit_login_form.Text = "X";
            exit_login_form.Click += exit_login_form_Click;
            // 
            // academic
            // 
            academic.BackColor = SystemColors.ActiveCaptionText;
            academic.FlatStyle = FlatStyle.Popup;
            academic.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            academic.ForeColor = SystemColors.ButtonFace;
            academic.Location = new Point(131, 155);
            academic.Margin = new Padding(3, 4, 3, 4);
            academic.Name = "academic";
            academic.Size = new Size(223, 57);
            academic.TabIndex = 2;
            academic.Text = "Academic";
            academic.UseVisualStyleBackColor = false;
            academic.Click += academic_Click;
            // 
            // non_academic
            // 
            non_academic.FlatStyle = FlatStyle.Popup;
            non_academic.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            non_academic.Location = new Point(131, 273);
            non_academic.Margin = new Padding(3, 4, 3, 4);
            non_academic.Name = "non_academic";
            non_academic.Size = new Size(223, 57);
            non_academic.TabIndex = 3;
            non_academic.Text = "Non-Academic";
            non_academic.UseVisualStyleBackColor = true;
            non_academic.Click += non_academic_Click;
            // 
            // department
            // 
            department.BackColor = SystemColors.ActiveCaptionText;
            department.FlatStyle = FlatStyle.Popup;
            department.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            department.ForeColor = SystemColors.ButtonHighlight;
            department.Location = new Point(357, 399);
            department.Margin = new Padding(3, 4, 3, 4);
            department.Name = "department";
            department.Size = new Size(223, 57);
            department.TabIndex = 4;
            department.Text = "Department";
            department.UseVisualStyleBackColor = false;
            department.Click += department_Click;
            // 
            // undergraduate
            // 
            undergraduate.BackColor = SystemColors.ActiveCaptionText;
            undergraduate.FlatStyle = FlatStyle.Popup;
            undergraduate.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            undergraduate.ForeColor = SystemColors.ButtonFace;
            undergraduate.Location = new Point(584, 155);
            undergraduate.Margin = new Padding(3, 4, 3, 4);
            undergraduate.Name = "undergraduate";
            undergraduate.Size = new Size(230, 57);
            undergraduate.TabIndex = 5;
            undergraduate.Text = "Undergraduate";
            undergraduate.UseVisualStyleBackColor = false;
            undergraduate.Click += undergraduate_Click;
            // 
            // users
            // 
            users.FlatStyle = FlatStyle.Popup;
            users.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            users.Location = new Point(584, 273);
            users.Margin = new Padding(3, 4, 3, 4);
            users.Name = "users";
            users.Size = new Size(230, 57);
            users.TabIndex = 6;
            users.Text = "Users";
            users.UseVisualStyleBackColor = true;
            users.Click += users_Click;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.Red;
            logout_btn.FlatStyle = FlatStyle.Popup;
            logout_btn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = SystemColors.ButtonHighlight;
            logout_btn.Location = new Point(399, 608);
            logout_btn.Margin = new Padding(3, 4, 3, 4);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(153, 57);
            logout_btn.TabIndex = 7;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.home;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(975, 776);
            Controls.Add(logout_btn);
            Controls.Add(users);
            Controls.Add(undergraduate);
            Controls.Add(department);
            Controls.Add(non_academic);
            Controls.Add(academic);
            Controls.Add(exit_login_form);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exit_login_form;
        private Button academic;
        private Button non_academic;
        private Button department;
        private Button undergraduate;
        private Button users;
        private Button logout_btn;
    }
}