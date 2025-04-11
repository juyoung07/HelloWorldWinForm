using System;
using System.Windows.Forms;

namespace HelloWorldWinForm
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "쾅!";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void exist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
