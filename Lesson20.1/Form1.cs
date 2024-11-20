namespace Lesson20._1
{
    public partial class Form1 : Form
    {
        private string pictureDirectory;
        private CancellationTokenSource cancelToken =
                        new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Поворот картинок";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureDirectory = folderBrowserDialog1.SelectedPath;
                label1.Text = pictureDirectory;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Task.Factory.StartNew(() => Process());
            Task.Factory.StartNew(() => Processfile());
        }
        private void Process()
        {
            var picturePath = Path.Combine(pictureDirectory, "TestPictures");
            var outPath = Path.Combine(pictureDirectory, "OutPutDirectory");
            if (Directory.Exists(outPath))
            {
                Directory.Delete(outPath, true);
            }
            Directory.CreateDirectory(outPath);
            string[] files = Directory.GetFiles(picturePath,
                "*.jpg", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                string filename = Path.GetFileName(file);
                this.Invoke(
                    new Action(() =>
                    {
                        this.Text = $"Выполняется поворот картинки {filename} " +
                    $" в потоке {Thread.CurrentThread.ManagedThreadId}";
                    }));

                using (Bitmap bitmap = new Bitmap(file))
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    bitmap.Save(Path.Combine(outPath, filename));
                }
            }
        }
        private void Processfile()
        {
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.CancellationToken = cancelToken.Token;
            parallelOptions.MaxDegreeOfParallelism =
                System.Environment.ProcessorCount;
            string[] files = Directory.
                GetFiles(pictureDirectory + @"\TestPictures", "*.jpg",
                SearchOption.AllDirectories);
            string outPut = pictureDirectory + @"\TestPictures";
            Directory.CreateDirectory(outPut);
            try
            {
                Parallel.ForEach(files, parallelOptions, curFile =>
                {
                    parallelOptions.CancellationToken.
                            ThrowIfCancellationRequested();
                    string fileName = Path.GetFileName(curFile);
                    this.Invoke(new Action(() =>
                    {
                        this.Text = $"Выполняется поворот картинки {fileName} " +
                    $" в потоке {Thread.CurrentThread.ManagedThreadId}";
                    }));
                    using (Bitmap bitmap = new Bitmap(curFile))
                    {
                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        bitmap.Save(Path.Combine(outPut, fileName));
                    }
                });
                this.Invoke(new Action(() =>
                {
                    this.Text = "Закончено";
                }));
            }
            catch (OperationCanceledException ex)
            {
                this.Invoke(new Action(() =>
                {
                    this.Text = ex.Message;
                }));
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cancelToken.Cancel();
        }
    }
}
