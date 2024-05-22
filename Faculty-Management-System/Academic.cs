using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculty_Management_System
{
    public partial class Academic : Form
    {
        public Academic()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 50, 50, 50);
        }
    }
}
