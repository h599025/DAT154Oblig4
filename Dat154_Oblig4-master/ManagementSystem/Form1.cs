namespace ManagementSystem
{
    public partial class Form1 : Form
    {
        dat154Context dx = new dat154Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reservation_button(object sender, EventArgs e)
        {
            Reservations r1 = new Reservations(dx);
            r1.Show();
        }

        private void tasks_button(object sender, EventArgs e)
        {
            Tasks t1 = new Tasks(dx);
            t1.Show();

        }
    }
}