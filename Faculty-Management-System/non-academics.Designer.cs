namespace Faculty_Management_System
{
    partial class non_academics
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
            panel1 = new Panel();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            gendertext = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            datetxt = new DateTimePicker();
            phonetxt = new TextBox();
            idtxt = new TextBox();
            emailtxt = new TextBox();
            nametxt = new TextBox();
            dataTable = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(gendertext);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(datetxt);
            panel1.Controls.Add(phonetxt);
            panel1.Controls.Add(idtxt);
            panel1.Controls.Add(emailtxt);
            panel1.Controls.Add(nametxt);
            panel1.Location = new Point(47, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 507);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(385, 376);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(105, 33);
            button4.TabIndex = 26;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(69, 427);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(330, 44);
            button5.TabIndex = 25;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(260, 376);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(119, 33);
            button3.TabIndex = 23;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(135, 376);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(119, 33);
            button2.TabIndex = 22;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(10, 376);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(119, 33);
            button1.TabIndex = 21;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gendertext
            // 
            gendertext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gendertext.FormattingEnabled = true;
            gendertext.Items.AddRange(new object[] { "Male", "Female" });
            gendertext.Location = new Point(135, 309);
            gendertext.Margin = new Padding(3, 4, 3, 4);
            gendertext.Name = "gendertext";
            gendertext.Size = new Size(338, 28);
            gendertext.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(33, 317);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 19;
            label8.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 261);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 18;
            label7.Text = "DOB:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 203);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 17;
            label6.Text = "Phone No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 152);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 16;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 95);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 15;
            label5.Text = "Staff ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 36);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 14;
            label3.Text = "Name:";
            // 
            // datetxt
            // 
            datetxt.Location = new Point(135, 254);
            datetxt.Name = "datetxt";
            datetxt.Size = new Size(338, 27);
            datetxt.TabIndex = 8;
            // 
            // phonetxt
            // 
            phonetxt.Location = new Point(135, 196);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new Size(338, 27);
            phonetxt.TabIndex = 6;
            // 
            // idtxt
            // 
            idtxt.Location = new Point(135, 88);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(338, 27);
            idtxt.TabIndex = 4;
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(135, 145);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(338, 27);
            emailtxt.TabIndex = 2;
            // 
            // nametxt
            // 
            nametxt.Location = new Point(135, 33);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(338, 27);
            nametxt.TabIndex = 0;
            // 
            // dataTable
            // 
            dataTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTable.BackgroundColor = SystemColors.ActiveCaption;
            dataTable.ColumnHeadersHeight = 29;
            dataTable.Location = new Point(571, 197);
            dataTable.Name = "dataTable";
            dataTable.RowHeadersWidth = 51;
            dataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTable.Size = new Size(759, 315);
            dataTable.TabIndex = 5;
            dataTable.CellContentClick += dataTable_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(591, 49);
            label1.Name = "label1";
            label1.Size = new Size(366, 29);
            label1.TabIndex = 7;
            label1.Text = "FCT MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(652, 96);
            label2.Name = "label2";
            label2.Size = new Size(256, 25);
            label2.TabIndex = 8;
            label2.Text = "NON ACADEMIC STAFF\r\n";
            // 
            // non_academics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1369, 773);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataTable);
            Controls.Add(panel1);
            Name = "non_academics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "non_academics";
            Load += non_academics_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DateTimePicker datetxt;
        private TextBox phonetxt;
        private TextBox idtxt;
        private TextBox emailtxt;
        private TextBox nametxt;
        private DataGridView dataTable;
        private Label label1;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label3;
        private ComboBox gendertext;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button4;
    }
}