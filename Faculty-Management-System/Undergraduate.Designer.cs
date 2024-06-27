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

            button6 = new Button();
            button5 = new Button();
            photoControl = new PictureBox();
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
            label12 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)photoControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 21);
            label1.Name = "label1";
            label1.Size = new Size(293, 24);
            label1.TabIndex = 0;
            label1.Text = "FCT MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(420, 56);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 1;
            label2.Text = "UNDERGRADUATE";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(photoControl);
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
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(35, 101);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(563, 442);
            panel1.TabIndex = 2;
            // 

            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(472, 421);
            button6.Name = "button6";
            button6.Size = new Size(119, 33);
            button6.TabIndex = 25;
            button6.Text = "Browse";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(177, 537);
            button5.Name = "button5";
            button5.Size = new Size(289, 33);

            button5.TabIndex = 24;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 

            // photoControl
            // 
            photoControl.Location = new Point(210, 427);
            photoControl.Name = "photoControl";
            photoControl.Size = new Size(256, 26);
            photoControl.TabIndex = 23;
            photoControl.TabStop = false;
            // 
            // leveltext
            // 
            leveltext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leveltext.FormattingEnabled = true;
            leveltext.Items.AddRange(new object[] { "Level 1", "Level 2", "Level 3", "Level 4" });
            leveltext.Location = new Point(210, 384);
            leveltext.Name = "leveltext";
            leveltext.Size = new Size(377, 28);
            leveltext.TabIndex = 22;
            // 
            // degreetext
            // 
            degreetext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            degreetext.FormattingEnabled = true;
            degreetext.Items.AddRange(new object[] { "Computer Science", "Computing & Technology", "Engineering Technology" });
            degreetext.Location = new Point(210, 337);
            degreetext.Name = "degreetext";
            degreetext.Size = new Size(377, 28);
            degreetext.TabIndex = 21;
            // 
            // departmenttext
            // 
            departmenttext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmenttext.FormattingEnabled = true;
            departmenttext.Items.AddRange(new object[] { "Computer System Engineering", "Applied Computing", "Software Engineering" });
            departmenttext.Location = new Point(210, 289);
            departmenttext.Name = "departmenttext";
            departmenttext.Size = new Size(377, 28);
            departmenttext.TabIndex = 20;
            // 
            // dobtext
            // 
            dobtext.CalendarFont = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dobtext.Location = new Point(210, 245);
            dobtext.Name = "dobtext";
            dobtext.Size = new Size(377, 27);
            dobtext.TabIndex = 19;
            // 
            // gendertext
            // 
            gendertext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gendertext.FormattingEnabled = true;
            gendertext.Items.AddRange(new object[] { "Male", "Female" });
            gendertext.Location = new Point(210, 198);
            gendertext.Name = "gendertext";
            gendertext.Size = new Size(377, 28);
            gendertext.TabIndex = 18;
            // 
            // phonetext
            // 
            phonetext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phonetext.Location = new Point(210, 155);
            phonetext.Name = "phonetext";
            phonetext.Size = new Size(377, 27);
            phonetext.TabIndex = 17;
            // 
            // emailtext
            // 
            emailtext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailtext.Location = new Point(210, 108);
            emailtext.Name = "emailtext";
            emailtext.Size = new Size(377, 27);
            emailtext.TabIndex = 16;
            // 
            // studentidtext
            // 
            studentidtext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentidtext.Location = new Point(210, 63);
            studentidtext.Name = "studentidtext";
            studentidtext.Size = new Size(377, 27);
            studentidtext.TabIndex = 15;
            // 
            // nametext
            // 
            nametext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametext.Location = new Point(210, 21);
            nametext.Name = "nametext";
            nametext.Size = new Size(377, 27);
            nametext.TabIndex = 14;

            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);

            button3.Location = new Point(416, 483);

            button3.Name = "button3";
            button3.Size = new Size(104, 25);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);

            button2.Location = new Point(229, 483);

            button2.Name = "button2";
            button2.Size = new Size(104, 25);
            button2.TabIndex = 11;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);

            button1.Location = new Point(57, 483);

            button1.Name = "button1";
            button1.Size = new Size(104, 25);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(39, 320);
            label12.Name = "label12";
            label12.Size = new Size(55, 17);
            label12.TabIndex = 9;
            label12.Text = "Photo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(39, 288);
            label11.Name = "label11";
            label11.Size = new Size(52, 17);
            label11.TabIndex = 8;
            label11.Text = "Level:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(39, 253);
            label10.Name = "label10";
            label10.Size = new Size(66, 17);
            label10.TabIndex = 7;
            label10.Text = "Degree:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(39, 217);
            label9.Name = "label9";
            label9.Size = new Size(97, 17);
            label9.TabIndex = 6;
            label9.Text = "Department:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(39, 184);
            label8.Name = "label8";
            label8.Size = new Size(46, 17);
            label8.TabIndex = 5;
            label8.Text = "DOB:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 151);
            label7.Name = "label7";
            label7.Size = new Size(67, 17);
            label7.TabIndex = 4;
            label7.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 116);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 3;
            label6.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 81);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 2;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 50);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 1;
            label4.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 21);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 0;
            label3.Text = "Name:";
            // 

            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(744, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1155, 350);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            // 
            // Undergraduate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Stretch;

            ClientSize = new Size(1924, 773);
            Controls.Add(dataGridView1);

            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Undergraduate";
            Text = "Undergraduate";
            Load += Undergraduate_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)photoControl).EndInit();
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
        private Label label12;
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
        private PictureBox photoControl;
        private Button button6;
    }
}