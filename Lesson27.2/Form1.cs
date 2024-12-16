using Font = System.Drawing.Font;
using Word = Microsoft.Office.Interop.Word;
namespace Lesson27._2
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFile;
        private FontStyle fontStyle;
        private FontFamily fontFamily;
        private float size;
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
                    new Font(  fontFamily, size, fontStyle);
                textBoxFont.Text = fontFamily.Name;
                numericUpDownSize.Value = decimal.Parse(size.ToString());
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
                        new System.Drawing.Font("Verdana", 12, FontStyle.Bold);
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
                fontFamily = fontDialog.Font.FontFamily;
                fontStyle = fontDialog.Font.Style;
                size = fontDialog.Font.Size;
                numericUpDownSize.Value = decimal.Parse(size.ToString());
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word files(*.rtf)|*.rtf|All files(*.*)|*.*";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Word.Application wordApp = new Word.Application();
                Word.Document wordDoc = wordApp.Documents.Open(saveFileDialog.FileName);
                wordDoc.Content.Delete();
                string res=richTextBoxText.Text;
                string[] mas = res.Split("\n");
                for(int i=0;i<mas.Length;i++)
                {
                    Word.Paragraph heading = wordDoc.Paragraphs.Add();
                    heading.Range.Text += mas[i];
                }
                Word.Range range = wordDoc.Content;
                range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                wordDoc.SaveAs2(saveFileDialog.FileName,Word.WdSaveFormat.wdFormatRTF);
                wordDoc.Close();
                wordApp.Quit();
            }
        }

        private void numericUpDownSize_ValueChanged(object sender, EventArgs e)
        {
            richTextBoxText.SelectionFont =
                        new Font(fontFamily,
                        (float)numericUpDownSize.Value, fontStyle);
        }

        private void toolStripButtonJustify_Click(object sender, EventArgs e)
        {
            richTextBoxText.SelectionAlignment = HorizontalAlignment.Center;
        }

    }
}

