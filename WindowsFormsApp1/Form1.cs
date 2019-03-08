using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private delegate void BeginInvoeDelegate();

        private int fileNumber;
        private int currentNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txtDestFolder.Text = path.SelectedPath;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txtSourceFolder.Text = path.SelectedPath;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string sourceFolder = this.txtSourceFolder.Text;
            string destFolder = this.txtDestFolder.Text;
            if (sourceFolder == null || destFolder == null)
            {
                MessageBox.Show("请选择源文件夹和目标文件夹");
                return;
            }
            if (!Directory.Exists(sourceFolder))
            {
                MessageBox.Show("源文件夹不存在");
                return;
            }
            if (!Directory.Exists(destFolder))
            {
                MessageBox.Show("目标文件夹不存在");
                return;
            }
            if (IsChildFolder(sourceFolder,destFolder))
            {
                MessageBox.Show("源文件夹和目标文件夹不能互相包含");
                return;
            }
            ClearStatus();
            this.btnStart.Enabled = false;
            StartCopy(sourceFolder, destFolder,true);
        }

        /// <summary>
        /// 多线程复制文件，不阻塞UI线程
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destFolder"></param>
        private void StartCopy(string sourceFolder, string destFolder,bool initStart)
        {

            Action action = () => {
                try
                {
                    string[] directories = Directory.GetDirectories(sourceFolder);
                    string[] files = Directory.GetFiles(sourceFolder);
                    if (initStart)
                    {
                        if (directories != null)
                        {
                            this.fileNumber = directories.Length;
                        }
                        else
                        {
                            this.fileNumber = 0;
                        }
                        if (files != null)
                        {
                            this.fileNumber += files.Length;
                        }
                        if (this.fileNumber == 0)
                        {
                            goto endLabel;
                        }
                    }
                    if (!Util.IsNullOrEmpty(files))
                    {
                        MoveFiles(files, destFolder);
                    }
                    if (!Util.IsNullOrEmpty(directories))
                    {
                        MoveDirectories(directories, destFolder, initStart);
                    }
                    endLabel:
                    if (initStart)
                    {
                        this.BeginInvoke(new BeginInvoeDelegate(() =>
                        {
                            this.btnStart.Enabled = true;
                            this.labCurrentCopy.Text = "复制完成";
                        }));
                    }

                }
                catch (Exception ex)
                {
                    HandleThreadException(ex);
                }
            };
            if (initStart)
            {
                Task.Run(action);
            }
            else
            {
                action.Invoke();
            }
           
        }

        private void MoveDirectories(string[] directories, string destFolder,bool initStart)
        {
            try
            {
                directories.ToList().ForEach(di=> {
                    DirectoryInfo directoryInfo = new DirectoryInfo(di);
                    string diName= directoryInfo.Name;
                    string newDiFullName = destFolder +"\\"+ diName;
                    if (!Directory.Exists(newDiFullName))
                    {
                        Directory.CreateDirectory(newDiFullName);
                        StartCopy(di, newDiFullName,false);
                    }
                });
            }
            catch (Exception ex)
            {
                HandleThreadException(ex);
            }
        }

        private void MoveFiles(string[] files, string destFolder)
        {
            try {
                files.ToList().ForEach(file => {
                    FileInfo fileInfo = new FileInfo(file);
                    string fileName= fileInfo.Name;
                    string newFullFilePath = destFolder +"\\"+ fileName;
                    if (!File.Exists(newFullFilePath))
                    {
                        this.BeginInvoke(new BeginInvoeDelegate(() => {
                            this.labCurrentCopy.Text = "正在复制："+file;
                        }));
                        File.Copy(file, newFullFilePath);
                    }
                });
            }
            catch (Exception ex)
            {
                HandleThreadException(ex);
            }
        }

        private void HandleThreadException(Exception ex)
        {
            this.BeginInvoke(new BeginInvoeDelegate(() => {
                MessageBox.Show("发生了异常：" + ex.Message);
            }));
        }

        private void ClearStatus()
        {
            this.fileNumber = 0;
            this.currentNumber = 0;
        }

        private bool IsChildFolder(string folderOne, string folderTwo)
        {
            if (folderOne.StartsWith(folderTwo) || folderTwo.StartsWith(folderOne))
            {
                DirectoryInfo directoryInfoOne = new DirectoryInfo(folderOne);
                DirectoryInfo directoryInfoTwo = new DirectoryInfo(folderTwo);
                if (directoryInfoOne.Parent.FullName.Equals(directoryInfoTwo.Parent.FullName) && (directoryInfoOne.Name != directoryInfoTwo.Name))
                {
                    return false;
                }
                return true;
            }
            else {
                return false;
            }
        }
    }
}
