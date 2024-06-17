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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(non_academics));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            homebtn = new Button();
            deletebtn = new Button();
            editbtn = new Button();
            addbtn = new Button();
            label7 = new Label();
            datetxt = new DateTimePicker();
            label6 = new Label();
            phonetxt = new TextBox();
            label5 = new Label();
            idtxt = new TextBox();
            label4 = new Label();
            emailtxt = new TextBox();
            label3 = new Label();
            nametxt = new TextBox();
            label8 = new Label();
            panel2 = new Panel();
            dataTable = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 35);
            label1.Name = "label1";
            label1.Size = new Size(766, 52);
            label1.TabIndex = 0;
            label1.Text = "FACULTY MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(442, 112);
            label2.Name = "label2";
            label2.Size = new Size(454, 42);
            label2.TabIndex = 1;
            label2.Text = "NON ACADEMIC STAFF";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(homebtn);
            panel1.Controls.Add(deletebtn);
            panel1.Controls.Add(editbtn);
            panel1.Controls.Add(addbtn);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(datetxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(phonetxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(idtxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(emailtxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(nametxt);
            panel1.Location = new Point(47, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 507);
            panel1.TabIndex = 2;
            // 
            // homebtn
            // 
            homebtn.BackColor = SystemColors.Highlight;
            homebtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            homebtn.ForeColor = SystemColors.ButtonHighlight;
            homebtn.Location = new Point(301, 440);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(95, 40);
            homebtn.TabIndex = 13;
            homebtn.Text = "HOME";
            homebtn.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = SystemColors.Highlight;
            deletebtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            deletebtn.ForeColor = SystemColors.ButtonHighlight;
            deletebtn.Location = new Point(80, 440);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(95, 40);
            deletebtn.TabIndex = 12;
            deletebtn.Text = "DELETE";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.BackColor = SystemColors.Highlight;
            editbtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            editbtn.ForeColor = SystemColors.ButtonHighlight;
            editbtn.Location = new Point(301, 389);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(95, 40);
            editbtn.TabIndex = 11;
            editbtn.Text = "EDIT";
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += editbtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = SystemColors.Highlight;
            addbtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            addbtn.ForeColor = SystemColors.ButtonHighlight;
            addbtn.Location = new Point(80, 389);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(95, 40);
            addbtn.TabIndex = 10;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 331);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 9;
            label7.Text = "DOB: ";
            // 
            // datetxt
            // 
            datetxt.Location = new Point(142, 325);
            datetxt.Name = "datetxt";
            datetxt.Size = new Size(289, 27);
            datetxt.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 259);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 7;
            label6.Text = "Phone No: ";
            // 
            // phonetxt
            // 
            phonetxt.Location = new Point(142, 256);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new Size(289, 27);
            phonetxt.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 116);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 5;
            label5.Text = "Staff Id: ";
            // 
            // idtxt
            // 
            idtxt.Location = new Point(142, 113);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(289, 27);
            idtxt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 191);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Email: ";
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(142, 188);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(289, 27);
            emailtxt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 48);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 1;
            label3.Text = "Name: ";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(142, 45);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(289, 27);
            nametxt.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(817, 197);
            label8.Name = "label8";
            label8.Size = new Size(140, 36);
            label8.TabIndex = 3;
            label8.Text = "Staff List";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(551, 234);
            panel2.Name = "panel2";
            panel2.Size = new Size(681, 3);
            panel2.TabIndex = 4;
            // 
            // dataTable
            // 
            dataTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataTable.ColumnHeadersHeight = 29;
            dataTable.Location = new Point(553, 260);
            dataTable.Name = "dataTable";
            dataTable.RowHeadersWidth = 51;
            dataTable.Size = new Size(679, 188);
            dataTable.TabIndex = 5;
            // 
            // non_academics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 773);
            Controls.Add(dataTable);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
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

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button homebtn;
        private Button deletebtn;
        private Button editbtn;
        private Button addbtn;
        private Label label7;
        private DateTimePicker datetxt;
        private Label label6;
        private TextBox phonetxt;
        private Label label5;
        private TextBox idtxt;
        private Label label4;
        private TextBox emailtxt;
        private Label label3;
        private TextBox nametxt;
        private Label label8;
        private Panel panel2;
        private DataGridView dataTable;
    }
}