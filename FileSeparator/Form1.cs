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

namespace FileSeparator
{
    public partial class Form1 : Form
    {
        private string sourceFolderName;
        string sendedFile = "";
        private Thread th;
        bool run;
        string[] selectedFileArr;
        FileInfo fi;
        int height = 0, width = 0;
        string selectedFileType = "";
        int fileSize = 0;
        public Form1()
        {
            InitializeComponent();
            run = false;
            sourceFolderName = "";
            selectFolderBtn.Enabled = false;
            startBtn.Enabled = false;
            startBtn.BackColor = Color.Tomato;
            fileTypeCombo.SelectedIndex = 0;
            inspectedCountLabel.Text = "0";
        }

        private void RecursiveFileFind()
        {
           

              /*  Task.Factory.StartNew(() =>
                {
                    
                });*/
            
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.ShowDialog();
                sourceFolderNameText.Text = dlg.SelectedPath;
                sourceFolderName = sourceFolderNameText.Text;
                if (sourceFolderName!="")
                {
                    startBtn.Enabled = true;                  
                    selectedFileArr = Directory.GetFiles(sourceFolderName, $"*{fileTypeCombo.SelectedItem}*", SearchOption.AllDirectories);
                    findedFileCountLabel.Text = selectedFileArr.Length.ToString();                                 
                }
                else
                {
                    startBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }


        private void button1_Click(object sender, EventArgs e)
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
            if (Directory.Exists(sourceFolderName) && th == null)
            {
                startBtn.Text = "Started separator";
                inspectedCountLabel.Text = "0";
                run = true;
                th = new Thread(new ThreadStart(Separator_thread));
                th.IsBackground = true;
                th.Start();
                selectFolderBtn.Enabled = false;
                startBtn.BackColor = Color.LightGreen;
                statusLabel.Text = "Started";
                fileTypeCombo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Source folder is empty or cannot find!\nPlease check it!");
            }
        }

        private void Stop()
        {
            if (th != null && th.IsAlive  && run)
            {
                Invoke((MethodInvoker)delegate 
                {
                    startBtn.Text = "Stoped separator";
                    run = false;
                    th = null;
                    selectFolderBtn.Enabled = true;
                    startBtn.Enabled = true;
                    startBtn.BackColor = Color.Tomato;
                    statusLabel.Text = "Stopped";
                    fileTypeCombo.Enabled = true;
                });
                
            }
        }


        private void FilePos(string side,string[] f)
        {
            

            try
            {
                if (!Directory.Exists(side + "\\" + f[5]))
                {
                    Directory.CreateDirectory(side + "\\" + f[5]);
                }

                if (!Directory.Exists(side + "\\" + f[5] + "\\" + width.ToString() + "x" + height.ToString()))
                {
                    Directory.CreateDirectory(side + "\\" + f[5] + "\\" + width.ToString() + "x" + height.ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("filepos: : " + ex.Message + "\n" + ex.StackTrace);
            }



        }

        private void Separator_thread()
        {
            List<string[]> splittedFileList = new List<string[]>();
            string[] elsofele = { };
            string[] masodikfele= { };
            FileInfo info;
            int counter = 0;
            string selectedLine = "";
            while (run)
            {
                try
                {
                    counter = 0;
                    foreach (var item in selectedFileArr)
                    {
                        try
                        {
                            sendedFile = item;
                            info = new FileInfo(item);
                            if (run && info.Extension == selectedFileType && info.Length > 10)
                            {

                                //1. fájlnév elejében megtalálja a sort. ->3607: 7-es sor ->3608:8-as sor, egyéb:other mappa
                                //1/b. ha nem létezik az adott típusú mappa, akkor létrehozás
                                //2.vizsgálni a kép poziját(top, botom,stb)-> ha nincs olvan mappa, akkor létrehozás
                                //3. vizsgálni a kép felbontását, és létrehozn egy mappát a méretével-> majd bemásolás
                                masodikfele = item.Split('_');//kisplitelli részekre
                                elsofele = masodikfele[0].Split('\\');

                                using (var fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.Read))
                                {
                                    using (var image = Image.FromStream(fileStream, false, false))
                                    {
                                        height = image.Height;
                                        width = image.Width;

                                    }
                                }
                                if (elsofele[elsofele.Length - 1][3] == '7')
                                {
                                    selectedLine = "3607";
                                    Directory.CreateDirectory(selectedLine);
                                    FilePos(selectedLine, masodikfele);
                                }
                                else if (elsofele[elsofele.Length - 1][3] == '8')
                                {
                                    selectedLine = "3608";
                                    Directory.CreateDirectory(selectedLine);
                                    FilePos(selectedLine, masodikfele);
                                }
                                else
                                {
                                    selectedLine = "other";
                                    Directory.CreateDirectory(selectedLine);
                                    FilePos(selectedLine, masodikfele);
                                }
                                File.Copy(item, selectedLine + "\\" + masodikfele[5] + "\\" + width.ToString() + "x" + height.ToString() + item.Substring(item.LastIndexOf("\\")), true);
                                counter++;
                                Invoke((MethodInvoker)delegate
                                {
                                    inspectedCountLabel.Text = counter.ToString();
                                });
                            }
                            else if (info.Length < 10)
                            {
                                
                            }
                            else break;
                        }
                        catch (Exception)
                        {

                            try
                            {
                                if (!Directory.Exists("ExceptionFiles"))
                                {
                                    Directory.CreateDirectory("ExceptionFiles");
                                }
                                File.Copy(sendedFile, "ExceptionFiles" + "\\" + sendedFile.Substring(sendedFile.LastIndexOf("\\")), true);
                                counter++;
                                Invoke((MethodInvoker)delegate
                                {
                                    inspectedCountLabel.Text = counter.ToString();
                                });
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                        
                    }

                    Stop();
                    Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show("Finished!");
                    });
                }
                catch (Exception)
                {
                    MessageBox.Show(sendedFile);
                }
                 Thread.Sleep(1000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Program description:\n" +
                "File separator is a file separator application that can sort files from a folder based on preset values and copy them to several separate folders next to the program.\n" +
                "1.The program examines the first 4 characters of the file name and separates it(7 or 8 or other).\n" +
                "2.examine the file size(width, height) and separate it.\n" +
                "3 Examine the position of the installer at the end of the file name and separate it(top, bottom, left, right, front).\n" +
                "Controls:\n" +
                "- Searched file type: searched file type we are working with.\n" +
                "- Source folder: the folder from which the images are separated.\n" +
                "- Status: displays the status of the program running.\n" +
                "- Finded file count: number of files found in the source folder.\n" +
                "- Inspected: number of files scanned","Help",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void fileTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (fileTypeCombo.SelectedIndex != -1)
                {
                    selectedFileType = fileTypeCombo.Text;
                    if (sourceFolderName != "")
                    {
                        selectedFileArr = Directory.GetFiles(sourceFolderName, $"*{fileTypeCombo.SelectedItem}*", SearchOption.AllDirectories);
                        findedFileCountLabel.Text = selectedFileArr.Length.ToString();
                    }
                    selectFolderBtn.Enabled = true;
                }
                else
                {
                    selectFolderBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("fileTypeCombo_SelectedIndexChanged: " + ex.Message + "\n" + ex.StackTrace);
            }
            
            
           
        }
    }
}
