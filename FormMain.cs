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

        

        private void button1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "쾅!";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // 모달창
            Form formAbout1 = new FormAbout();
            formAbout1.Text = "모달창 (Modal)";
            formAbout1.ShowDialog();

            // 모달리스창
            Form formAbout2 = new FormAbout();
            formAbout2.Text = "모달리스창 (Modeless)";
            formAbout2.ShowDialog();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
