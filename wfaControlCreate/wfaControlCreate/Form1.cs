namespace wfaControlCreate
{

    public partial class Form1 : Form
    {
       private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            this.MouseDown +=Form1_MouseDown;
        }

        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Label x = new Label();
                //var x = new Label();
                Label x = new();
                x.Location = e.Location;
                x.Text = $"( {x.Location.X}, {x.Location.Y})";
                x.BackColor = Color.HotPink;
                this.Controls.Add(x);
            }
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < 10; i++)
                {
                    Label x = new();
                    x.Location = new Point(
                        rnd.Next(this.ClientSize.Width),
                        rnd.Next(this.ClientSize.Width));
                    x.Text = $"( {x.Location.X}, {x.Location.Y})";
                    x.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(256)); 
                    this.Controls.Add(x);
                }
            }
            if(e.Button == MouseButtons.Middle)
            {
                this.Controls.Clear();
            }
            this.Text = $"{Application.ProductName}: Count={this.Controls.Count}";
        }
    }
}