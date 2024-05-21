namespace Faculty_Management_System
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        int startPos = 0;
        private void Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPos += 1;
            progressBar1.Value = startPos;
            if(progressBar1.Value == 100 )
            {
                progressBar1.Value = 0;
                timer1.Stop();
            }
        }
    }
}
