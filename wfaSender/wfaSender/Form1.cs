namespace wfaSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click +=Button1_Click; ;
            button2.Click += Button1_Click;
            checkBox1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            //MessageBox.Show(button1.Text);

            //Button? button = (Button)sender;
            //MessageBox.Show(button.Text);

            //if (sender is Button)
            //    MessageBox.Show(((Button)sender).Text);

            //if (sender is CheckBox)
            //    MessageBox.Show(((Button)sender).Text);


            //if(sender is Control)
            //{
            //    Control c = (Control)sender;
            //    MessageBox.Show(c.Text);
            //}
            if (sender is Control c)
                MessageBox.Show(c.Text);
            (sender as Button).Text += "*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(button1.Text);

            //Button? button = (Button)sender;
            //MessageBox.Show(button.Text);

            //if (sender is Button)
            //    MessageBox.Show(((Button)sender).Text);

            //if (sender is CheckBox)
            //    MessageBox.Show(((Button)sender).Text);


            //if(sender is Control)
            //{
            //    Control c = (Control)sender;
            //    MessageBox.Show(c.Text);
            //}
            if (sender is Control c)
                MessageBox.Show(c.Text);
            (sender as Button).Text += "*";
        }
    }
}