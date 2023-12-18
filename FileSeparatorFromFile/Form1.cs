using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSeparatorFromFile
{
    public partial class Form1 : Form
    {
        string allresultFileNames = "";
        bool run = false;
        private int copyFileCounter;
        private int fileCounter = 0;
        string FileCounterFormated = "0/0";
        string[] files = { };
        List<string> separationData = new List<string>();
        private Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void MainThread()
        {
            if (Directory.Exists(sourceFolderTextBox.Text) && Directory.Exists(targetFolderTextBox.Text) && File.Exists(separationFileTextBox.Text))
            {
                copyFileCounter = 0;
                fileCounter = 0;
                string source = "", target = "";
                while (run && files.Length > 0&&fileCounter!=files.Length)
                {
                    source = sourceFolderTextBox.Text;
                    target = targetFolderTextBox.Text;
                    try
                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            if (!run)
                            {
                                break;
                            }
                            foreach (var item in separationData)
                            {
                                if (!run)
                                {
                                    break;
                                }

                                if (files[i].Contains(item))
                                {
                                   
                                    try
                                    {
                                        File.Copy(files[i], target + "\\" + files[i].Substring(files[i].LastIndexOf("\\")+1), true);
                                        copyFileCounter++;
                                        allresultFileNames += files[i].Substring(files[i].LastIndexOf("\\") + 1,20)+"\n";
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"from: {sourceFolderTextBox.Text}\\{files[i]}\n"+ targetFolderTextBox.Text + "\\" + files[i]+ "\n" + ex.Message + "\n" + ex.StackTrace);
                                    }
                                   
                                }
                            }
                            fileCounter++;
                            FileCounterFormated = fileCounter + "/" + files.Length;
                            Invoke((MethodInvoker)delegate
                            {
                                fileCounterLabel.Text = FileCounterFormated;
                                copyFileCountLabel.Text = copyFileCounter.ToString();
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("\n"+ex.Message + "\n" + ex.StackTrace);
                    }
                    StreamWriter wr = new StreamWriter("result"+ DateTime.Now.ToString("HHmmss")+".txt");
                    wr.Write(allresultFileNames);
                    wr.Flush();
                    wr.Close();
                    MessageBox.Show("Done!");
                }
                Stop();
            }
            else
            {
                MessageBox.Show("please select seurce, destination folder, and select separation file.");
            }

        }


        private void sourceFolderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] tmp;
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    sourceFolderTextBox.Text = dlg.SelectedPath;
                    files = Directory.GetFiles(sourceFolderTextBox.Text, "*.*", SearchOption.AllDirectories);
                    tmp = new string[files.Length];
                    files.CopyTo(tmp, 0);
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        files[i] = tmp[i];
                    }
                    FileCounterFormated = fileCounter + "/" + files.Length;
                    fileCounterLabel.Text = FileCounterFormated;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"FolderBrowser error:\n{ex.Message}\n{ex.StackTrace}");
            }
        }

        private void targetFolderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    targetFolderTextBox.Text = dlg.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"FolderBrowser error:\n{ex.Message}\n{ex.StackTrace}");
            }
        }

        private void openSeparationFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        separationData.Clear();
                        separationFileTextBox.Text = openFileDialog.FileName;
                        using (StreamReader reader = new StreamReader(separationFileTextBox.Text))
                        {                          
                            string line = "";
                            while (!reader.EndOfStream)
                            {
                                line = reader.ReadLine();
                                if (line != null && line != "")
                                {
                                    separationData.Add(line);
                                }
                            }
                            separationListCountLabel.Text = separationData.Count.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"FolderBrowser error:\n{ex.Message}\n{ex.StackTrace}");
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!run)
                {
                    Start();
                }
                else
                {
                    Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }


        private void Start()
        {
            if (th == null&&sourceFolderTextBox.Text!=""&&targetFolderTextBox.Text!=""&&separationFileTextBox.Text!="")
            {
                startBtn.Text = "Started";
                run = true;
                th = new Thread(new ThreadStart(MainThread));
                th.IsBackground = true;
                th.Start();
                sourceFolderBtn.Enabled = false;
                targetFolderBtn.Enabled = false;
                openSeparationFileBtn.Enabled = false;
                startBtn.BackColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show("Source/destination/separation is empty or cannot find!\nPlease check it!");
            }
        }

        private void Stop()
        {
            if (th != null && th.IsAlive && run)
            {
                Invoke((MethodInvoker)delegate
                {
                    startBtn.Text = "Stoped";
                    run = false;
                    th = null;
                    sourceFolderBtn.Enabled = true;
                    targetFolderBtn.Enabled = true;
                    openSeparationFileBtn.Enabled = true;
                    startBtn.Enabled = true;
                    startBtn.BackColor = Color.Tomato;
                });

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(null, "What does this program do?\n" +
                "This program selects files from a specified folder based on the separation file and copies them to the destination folder.\n\n" +
                "How to use:\n" +
                "1.Select the folder from which to sort the images(source).\n" +
                "2.Select the folder where you want to place the selected images(destination).\n" +
                "3.Select the separation file to retrieve the files from the source folder.\n" +
                "4.Start the program.\n" +
                "- Checked file counter: total files / quantity checked\n" +
                "- Copied file counter: number of files copied\n" +
                "- Separation list counter: the size of the list of files to search", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
