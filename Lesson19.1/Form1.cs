namespace Lesson19._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
           Thread firstThread=new Thread(Loading);
           firstThread.Start();
        }
        private void buttonSecond_Click(object sender, EventArgs e)
        {
            Thread secondThread = new Thread(LaunchSecondThread);
            secondThread.Start();
        }
        private void Loading()
        {
            for (int i = 0; i <= 100; i++)
            {
                progressPB.Invoke(() => progressPB.Value = i);
                Thread.Sleep(250);
            }
        }
        private void LaunchSecondThread()
        {
            for (int i = 0; i <= 100; i++)
            {
                SecondThreadProcessPB.Invoke(()=> SecondThreadProcessPB.Value = i); ;
                Thread.Sleep(250);
            }
        }
       
    }
}
