namespace Faculty_Management_System
{
    partial class Academic
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Academic));
            button5 = new Button();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel3 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(908, 216);
            button5.Name = "button5";
            button5.Size = new Size(68, 21);
            button5.TabIndex = 6;
            button5.Text = "SHOW";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(699, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(520, 201);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.ForeColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(3, -11);
            panel3.Name = "panel3";
            panel3.Size = new Size(569, 347);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(188, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(188, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(92, 43);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 13;
            label6.Text = "Name";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(81, 82);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 14;
            label7.Text = "Staff No";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(188, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(61, 128);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 16;
            label8.Text = "Department";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.Location = new Point(188, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(87, 170);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 18;
            label5.Text = "Degree";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 128, 255);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(227, 232);
            button3.Name = "button3";
            button3.Size = new Size(67, 24);
            button3.TabIndex = 21;
            button3.Text = "EDIT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(81, 232);
            button1.Name = "button1";
            button1.Size = new Size(61, 24);
            button1.TabIndex = 22;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(382, 232);
            button2.Name = "button2";
            button2.Size = new Size(68, 24);
            button2.TabIndex = 23;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 128, 255);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(227, 276);
            button4.Name = "button4";
            button4.Size = new Size(67, 24);
            button4.TabIndex = 24;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(45, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 343);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 20.25F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(545, 57);
            label4.Name = "label4";
            label4.Size = new Size(206, 33);
            label4.TabIndex = 3;
            label4.Text = "ACADEMIC STAFF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Text Semibold", 24F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(388, 10);
            label1.Name = "label1";
            label1.Size = new Size(549, 47);
            label1.TabIndex = 0;
            label1.Text = "FACULTY MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 107);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // Academic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1282, 604);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Academic";
            Text = "Academic";
            Load += Academic_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button5;
        private Panel panel3;
        private Button button4;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label label5;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox3;
        private Label label7;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel2;
        private Label label4;
        private Label label1;
        private Panel panel1;
    }
}