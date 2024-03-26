using WinFormsDraw;

namespace work2_var2
{
    public partial class Form1 : Form
    {
        Picture_list p2;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            p2.Paint(g);
        }
        public Form1()
        {
            InitializeComponent();
            p2 = new Picture_list(50, 50, 500, 400, this);
        }

    }
}
