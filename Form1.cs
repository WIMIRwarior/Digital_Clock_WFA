namespace Digital_Clock_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            lbl_seconds.Location = new Point(lbl_Time.Location.X+lbl_Time.Width, lbl_Time.Location.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("HH:mm");
            lbl_seconds.Text = DateTime.Now.ToString("ss");
            lbl_day.Text = DateTime.Now.ToString("dddd");
            lbl_date.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }
    }
}
