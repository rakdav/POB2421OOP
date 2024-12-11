using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace Lesson27._2
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFile;
        private FontStyle fontStyle;
        private FontFamily fontFamily;
        private int size;
        public Form1()
        {
            InitializeComponent();
            fontStyle = FontStyle.Regular;
            fontFamily = FontFamily.GenericMonospace;
            size = 14;
        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "Word files(*.docx)|*.docx|All files(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Word.Application wordApp = new Word.Application();
                Word.Document wordDoc = wordApp.Documents.Open(openFile.FileName);
                this.Text = openFile.FileName;
                Word.Range range = wordDoc.Content;
                string str = string.Empty;
                for (int i = 1; i <= wordDoc.Paragraphs.Count; i++)
                {
                    str += wordDoc.Paragraphs[i].Range.Text + "\n";
                }
                richTextBoxText.Text = str;
                richTextBoxText.SelectAll();
                richTextBoxText.SelectionFont =
                    new Font(fontFamily, size, fontStyle);
                wordDoc.Close();
                wordApp.Quit();
            }
        }

        private void checkBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBoxText.SelectedText.Length != 0)
            {
                if (checkBoxBold.Checked)
                {
                    richTextBoxText.SelectionFont =
                        new Font("Verdana", 12, FontStyle.Bold);
                }
                else
                {
                    richTextBoxText.SelectionFont =
                        new Font("Verdana", 12, FontStyle.Regular);
                }
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFont.Text = fontDialog.Font.FontFamily.Name;
                richTextBoxText.SelectionFont =
                        new Font(fontDialog.Font.FontFamily,
                        fontDialog.Font.Size, fontDialog.Font.Style);
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxText.SelectionColor = colorDialog.Color;
            }
        }

        private void ñîõðàíèòüÊàêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
