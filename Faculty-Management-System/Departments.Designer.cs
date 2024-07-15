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
            label2 = new Label();
            panel1 = new Panel();
            button5 = new Button();
            button1 = new Button();
            comboBox4 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            stuCountLabel = new Label();
            acYearLabel = new Label();
            degreeLabel = new Label();
            deptLabel = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label4 = new Label();
            label1 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(25, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 355);
            panel1.TabIndex = 2;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(183, 279);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(330, 44);
            button5.TabIndex = 25;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(219, 230);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(119, 33);
            button1.TabIndex = 11;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Level 1", "Level 2", "Level 3", "Level 4" });
            comboBox4.Location = new Point(250, 175);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(379, 28);
            comboBox4.TabIndex = 8;
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
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 117);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 4;
            label7.Text = "Degree:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 183);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 3;
            label6.Text = "Level:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 52);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 0;
            label3.Text = "Department Name:";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(stuCountLabel);
            panel2.Controls.Add(acYearLabel);
            panel2.Controls.Add(degreeLabel);
            panel2.Controls.Add(deptLabel);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(724, 211);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 339);
            panel2.TabIndex = 3;
            // 
            // stuCountLabel
            // 
            stuCountLabel.AutoSize = true;
            stuCountLabel.BackColor = SystemColors.Control;
            stuCountLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stuCountLabel.Location = new Point(245, 234);
            stuCountLabel.MaximumSize = new Size(101, 11);
            stuCountLabel.MinimumSize = new Size(350, 29);
            stuCountLabel.Name = "stuCountLabel";
            stuCountLabel.Size = new Size(350, 29);
            stuCountLabel.TabIndex = 13;
            stuCountLabel.Text = "   ";
            // 
            // acYearLabel
            // 
            acYearLabel.AutoSize = true;
            acYearLabel.BackColor = SystemColors.Control;
            acYearLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acYearLabel.Location = new Point(245, 170);
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
            degreeLabel.Location = new Point(245, 105);
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
            deptLabel.Location = new Point(245, 43);
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
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(39, 117);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 8;
            label8.Text = "Degree";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(39, 183);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 6;
            label10.Text = "Level";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(39, 52);
            label11.Name = "label11";
            label11.Size = new Size(161, 20);
            label11.TabIndex = 5;
            label11.Text = "Department Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 243);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 2;
            label4.Text = "Student Count";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(603, 44);
            label1.Name = "label1";
            label1.Size = new Size(366, 29);
            label1.TabIndex = 7;
            label1.Text = "FCT MANAGEMENT SYSTEM";
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(356, 230);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(119, 33);
            button2.TabIndex = 26;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1416, 592);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
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
        private Label label2;
        private Panel panel1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private ComboBox comboBox4;
        private ComboBox comboBox2;
        private Panel panel2;
        private Label stuCountLabel;
        private Label acYearLabel;
        private Label degreeLabel;
        private Label deptLabel;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label4;
        private Label label1;
        private Button button1;
        private Button button5;
        private Button button2;
    }
}