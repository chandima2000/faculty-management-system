namespace Faculty_Management_System
{
    partial class Undergraduate
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            button5 = new Button();
            leveltext = new ComboBox();
            degreetext = new ComboBox();
            departmenttext = new ComboBox();
            dobtext = new DateTimePicker();
            gendertext = new ComboBox();
            phonetext = new TextBox();
            emailtext = new TextBox();
            studentidtext = new TextBox();
            nametext = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(550, 29);
            label1.Name = "label1";
            label1.Size = new Size(366, 29);
            label1.TabIndex = 0;
            label1.Text = "FCT MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(639, 77);
            label2.Name = "label2";
            label2.Size = new Size(203, 25);
            label2.TabIndex = 1;
            label2.Text = "UNDERGRADUATE";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(leveltext);
            panel1.Controls.Add(degreetext);
            panel1.Controls.Add(departmenttext);
            panel1.Controls.Add(dobtext);
            panel1.Controls.Add(gendertext);
            panel1.Controls.Add(phonetext);
            panel1.Controls.Add(emailtext);
            panel1.Controls.Add(studentidtext);
            panel1.Controls.Add(nametext);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 698);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(551, 571);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(119, 33);
            button4.TabIndex = 26;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(197, 624);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(330, 44);
            button5.TabIndex = 24;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // leveltext
            // 
            leveltext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leveltext.FormattingEnabled = true;
            leveltext.Items.AddRange(new object[] { "Level 1", "Level 2", "Level 3", "Level 4" });
            leveltext.Location = new Point(240, 512);
            leveltext.Margin = new Padding(3, 4, 3, 4);
            leveltext.Name = "leveltext";
            leveltext.Size = new Size(430, 28);
            leveltext.TabIndex = 22;
            // 
            // degreetext
            // 
            degreetext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            degreetext.FormattingEnabled = true;
            degreetext.Items.AddRange(new object[] { "Computer Science", "Computing & Technology", "Engineering Technology" });
            degreetext.Location = new Point(240, 449);
            degreetext.Margin = new Padding(3, 4, 3, 4);
            degreetext.Name = "degreetext";
            degreetext.Size = new Size(430, 28);
            degreetext.TabIndex = 21;
            // 
            // departmenttext
            // 
            departmenttext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmenttext.FormattingEnabled = true;
            departmenttext.Items.AddRange(new object[] { "Computer System Engineering", "Applied Computing", "Software Engineering" });
            departmenttext.Location = new Point(240, 385);
            departmenttext.Margin = new Padding(3, 4, 3, 4);
            departmenttext.Name = "departmenttext";
            departmenttext.Size = new Size(430, 28);
            departmenttext.TabIndex = 20;
            // 
            // dobtext
            // 
            dobtext.CalendarFont = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dobtext.Location = new Point(240, 327);
            dobtext.Margin = new Padding(3, 4, 3, 4);
            dobtext.Name = "dobtext";
            dobtext.Size = new Size(430, 27);
            dobtext.TabIndex = 19;
            // 
            // gendertext
            // 
            gendertext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gendertext.FormattingEnabled = true;
            gendertext.Items.AddRange(new object[] { "Male", "Female" });
            gendertext.Location = new Point(240, 264);
            gendertext.Margin = new Padding(3, 4, 3, 4);
            gendertext.Name = "gendertext";
            gendertext.Size = new Size(430, 28);
            gendertext.TabIndex = 18;
            // 
            // phonetext
            // 
            phonetext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phonetext.Location = new Point(240, 207);
            phonetext.Margin = new Padding(3, 4, 3, 4);
            phonetext.Name = "phonetext";
            phonetext.Size = new Size(430, 27);
            phonetext.TabIndex = 17;
            // 
            // emailtext
            // 
            emailtext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailtext.Location = new Point(240, 144);
            emailtext.Margin = new Padding(3, 4, 3, 4);
            emailtext.Name = "emailtext";
            emailtext.Size = new Size(430, 27);
            emailtext.TabIndex = 16;
            // 
            // studentidtext
            // 
            studentidtext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentidtext.Location = new Point(240, 84);
            studentidtext.Margin = new Padding(3, 4, 3, 4);
            studentidtext.Name = "studentidtext";
            studentidtext.Size = new Size(430, 27);
            studentidtext.TabIndex = 15;
            // 
            // nametext
            // 
            nametext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametext.Location = new Point(240, 28);
            nametext.Margin = new Padding(3, 4, 3, 4);
            nametext.Name = "nametext";
            nametext.Size = new Size(430, 27);
            nametext.TabIndex = 14;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(387, 571);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(119, 33);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(225, 571);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(119, 33);
            button2.TabIndex = 11;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(42, 571);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(119, 33);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(42, 523);
            label11.Name = "label11";
            label11.Size = new Size(60, 20);
            label11.TabIndex = 8;
            label11.Text = "Level:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(42, 460);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 7;
            label10.Text = "Degree:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(42, 396);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 6;
            label9.Text = "Department:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(42, 335);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 5;
            label8.Text = "DOB:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 268);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 4;
            label7.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 215);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 3;
            label6.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 152);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 2;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 92);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 1;
            label4.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 36);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 0;
            label3.Text = "Name:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(743, 135);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(695, 467);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Undergraduate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1450, 841);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Undergraduate";
            Text = "Undergraduate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button1;
        private Button button2;
        private Button button3;
        private DateTimePicker dobtext;
        private ComboBox gendertext;
        private TextBox phonetext;
        private TextBox emailtext;
        private TextBox studentidtext;
        private TextBox nametext;
        private ComboBox leveltext;
        private ComboBox degreetext;
        private ComboBox departmenttext;
        private Button button5;
        private DataGridView dataGridView1;
        private Button button4;
    }
}