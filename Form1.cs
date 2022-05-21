namespace LB11
{
    public partial class Form1 : Form
    {
        private int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(new Pen(Color.Black, 4), 3 * x + 50, y + 50, 50, 50);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 1;
            y = (int)(25 * Math.Sin(180 * x / Math.PI));
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
