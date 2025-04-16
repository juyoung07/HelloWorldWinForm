using System;
using System.IO;
using System.Windows.Forms;

namespace HelloWorldWinForm
{
    public partial class FormMain: Form
    {
        private const string FILE_DEFAULT_NAME = "제목 없음";
        private const string FILENAME_FILTER = "텍스트 파일(*.txt)| *.txt|모든 파일(*.*)|*.*";
        private const string TEXTBOX_DEFAULT_TEXT = "문구를 입력하세요";
        
        public FormMain()
        {
            InitializeComponent();
            lblFileName.Text = FILE_DEFAULT_NAME;
            textBox1.Text = TEXTBOX_DEFAULT_TEXT;
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
            openFileDialog.Filter = FILENAME_FILTER;
            DialogResult result = openFileDialog.ShowDialog();

            switch(result)
            {
                case DialogResult.OK:
                    lblFileName.Text = openFileDialog.FileName;
                    var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                    using(StreamReader reader = new StreamReader(fileStream))
                    {
                        textBox1.Text = reader.ReadToEnd();
                    }
                    fileStream.Close();
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("취소했습니다.");
                    break;
            }
                
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblFileName.Text == "제목 없음")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = FILENAME_FILTER;
                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    return;
                }
                lblFileName.Text = saveFileDialog.FileName;
            }
            var fileStream = new FileStream(lblFileName.Text, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(textBox1.Text);
                writer.Close();
            }
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = FILENAME_FILTER;
            saveFileDialog.FileName = lblFileName.Text;
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
            lblFileName.Text = saveFileDialog.FileName;
            var fileStream = new FileStream(lblFileName.Text, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(textBox1.Text);
                writer.Close();
            }
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = TEXTBOX_DEFAULT_TEXT;
            lblFileName.Text = FILE_DEFAULT_NAME;
        }
    }
}
