using System;
using System.IO;
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "텍스트 파일(*.txt)| *.txt|모든 파일(*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            switch(result)
            {
                case DialogResult.OK:
                    var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                    using(StreamReader reader = new StreamReader(fileStream))
                    {
                        textBox1.Text = reader.ReadToEnd();
                    }
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("취소했습니다.");
                    break;
            }
                
        }
    }
}
