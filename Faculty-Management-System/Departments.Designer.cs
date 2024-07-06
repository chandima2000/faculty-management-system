namespace Faculty_Management_System
{
    partial class Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label17 = new Label();
            stuCountLabel = new Label();
            levelLabel = new Label();
            acYearLabel = new Label();
            degreeLabel = new Label();
            deptLabel = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label4 = new Label();
            homeButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(603, 59);
            label1.Name = "label1";
            label1.Size = new Size(366, 29);
            label1.TabIndex = 0;
            label1.Text = "FCT MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(709, 113);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 1;
            label2.Text = "DEPARTMENTS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(137, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 427);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(250, 323);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += search_button_click;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Level I", "Level II", "Level III", "Level IV" });
            comboBox4.Location = new Point(250, 235);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(379, 28);
            comboBox4.TabIndex = 8;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "2018/2019", "2019/2020", "2020/2021", "2021/2022" });
            comboBox3.Location = new Point(250, 172);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(379, 28);
            comboBox3.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Computer Science", "Computing & Technology", "Engineering Technology" });
            comboBox2.Location = new Point(250, 109);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(379, 28);
            comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Computer System Engineering", "Applied Computing", "Software Engineering" });
            comboBox1.Location = new Point(250, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(379, 28);
            comboBox1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 109);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 4;
            label7.Text = "Degree";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 233);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 3;
            label6.Text = "Level";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 171);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 2;
            label5.Text = "Academic Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 44);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 0;
            label3.Text = "Department Name";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label17);
            panel2.Controls.Add(stuCountLabel);
            panel2.Controls.Add(levelLabel);
            panel2.Controls.Add(acYearLabel);
            panel2.Controls.Add(degreeLabel);
            panel2.Controls.Add(deptLabel);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(1013, 211);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 427);
            panel2.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(213, 29);
            label17.Name = "label17";
            label17.Size = new Size(236, 25);
            label17.TabIndex = 14;
            label17.Text = "Department Information";
            // 
            // stuCountLabel
            // 
            stuCountLabel.AutoSize = true;
            stuCountLabel.BackColor = SystemColors.Control;
            stuCountLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stuCountLabel.Location = new Point(245, 347);
            stuCountLabel.MaximumSize = new Size(101, 11);
            stuCountLabel.MinimumSize = new Size(350, 29);
            stuCountLabel.Name = "stuCountLabel";
            stuCountLabel.Size = new Size(350, 29);
            stuCountLabel.TabIndex = 13;
            stuCountLabel.Text = "   ";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.BackColor = SystemColors.Control;
            levelLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            levelLabel.Location = new Point(245, 277);
            levelLabel.MaximumSize = new Size(101, 11);
            levelLabel.MinimumSize = new Size(350, 29);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(350, 29);
            levelLabel.TabIndex = 12;
            levelLabel.Text = "   ";
            // 
            // acYearLabel
            // 
            acYearLabel.AutoSize = true;
            acYearLabel.BackColor = SystemColors.Control;
            acYearLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acYearLabel.Location = new Point(245, 225);
            acYearLabel.MaximumSize = new Size(101, 11);
            acYearLabel.MinimumSize = new Size(350, 29);
            acYearLabel.Name = "acYearLabel";
            acYearLabel.Size = new Size(350, 29);
            acYearLabel.TabIndex = 11;
            acYearLabel.Text = "   ";
            // 
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            degreeLabel.BackColor = SystemColors.Control;
            degreeLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            degreeLabel.Location = new Point(245, 159);
            degreeLabel.MaximumSize = new Size(101, 11);
            degreeLabel.MinimumSize = new Size(350, 29);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.Size = new Size(350, 29);
            degreeLabel.TabIndex = 10;
            degreeLabel.Text = "   ";
            // 
            // deptLabel
            // 
            deptLabel.AutoSize = true;
            deptLabel.BackColor = SystemColors.Control;
            deptLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deptLabel.Location = new Point(245, 97);
            deptLabel.MaximumSize = new Size(101, 11);
            deptLabel.MinimumSize = new Size(350, 29);
            deptLabel.Name = "deptLabel";
            deptLabel.Size = new Size(350, 29);
            deptLabel.TabIndex = 9;
            deptLabel.Text = "   ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(39, 163);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 8;
            label8.Text = "Degree";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(39, 285);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 7;
            label9.Text = "Level";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(39, 224);
            label10.Name = "label10";
            label10.Size = new Size(158, 25);
            label10.TabIndex = 6;
            label10.Text = "Academic Year";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(39, 97);
            label11.Name = "label11";
            label11.Size = new Size(185, 25);
            label11.TabIndex = 5;
            label11.Text = "Department Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 351);
            label4.Name = "label4";
            label4.Size = new Size(151, 25);
            label4.TabIndex = 2;
            label4.Text = "Student Count";
            // 
            // homeButton
            // 
            homeButton.BackColor = SystemColors.ActiveCaptionText;
            homeButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeButton.ForeColor = SystemColors.ButtonHighlight;
            homeButton.Location = new Point(1650, 32);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(94, 29);
            homeButton.TabIndex = 4;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += Departments_Load;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1735, 753);
            Controls.Add(homeButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Departments";
            Text = "Departments";
            Load += Departments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label5;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Button button1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Panel panel2;
        private Label stuCountLabel;
        private Label levelLabel;
        private Label acYearLabel;
        private Label degreeLabel;
        private Label deptLabel;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label4;
        private Label label17;
        private Button homeButton;
    }
}