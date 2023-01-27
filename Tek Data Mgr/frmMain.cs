using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Threading;

using System.IO;
using System.Collections;
using System.Reflection;

using System.Text.RegularExpressions;

using Microsoft.WindowsAPICodePack.Dialogs;

namespace Tek_Data_Mgr
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        string strIndex = "rb1";
        // 체크박스 값 ini에 저장. 
        string strTargetFolderPath1, strTargetFolderPath2, strTargetFolderPath3;
        string strResultFolderPath;
        int nRepeatCount, nCurrentCount;

        int nSetCheck, nResultCheck;
        string strFileText;
        public static string strAppPath = System.IO.Directory.GetCurrentDirectory();

        string strWorkPath, TargetPath, strWorkPath2;

        public static string[] scTekkenFilesOld = new string[6];
        public static string[] scTekkenFilesNew = new string[6];

        public static string[] strRepFileList
            =  {
            @"\replay_game_no1.sav",
            @"\replay_game_no2.sav",
            @"\replay_game_no3.sav",
            @"\replay_game_no4.sav",
            @"\replay_game_no5.sav",
            @"\replay_game_no6.sav"
        };


        public bool bThread = false;
        public Thread th;

        private void WriteIni(string section, string key, string val, string filePath)
        {
            WritePrivateProfileString(section, key, val, filePath);
        }
        private static string ReadIni(string section, string key, string filePath)
        {
            StringBuilder sb = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", sb, sb.Capacity, filePath);
            return sb.ToString();
        }


        private void btnFindPath_Click(object sender, EventArgs e)
        {

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            // 처음 보여줄 폴더 설정(안해도 됨)
            dialog.InitialDirectory = @"C:\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {

                switch (strIndex)
                {
                    case "rb1":
                        txtPath1.Text = dialog.FileName;
                        break;
                    case "rb2":
                        txtPath2.Text = dialog.FileName;
                        break;
                    case "rb3":
                        txtPath3.Text = dialog.FileName;
                        break;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteIni("TEKKEN", "FilePath_1", txtPath1.Text, strAppPath + @"\Setting.ini");
            WriteIni("TEKKEN", "FilePath_2", txtPath2.Text, strAppPath + @"\Setting.ini");
            WriteIni("TEKKEN", "FilePath_3", txtPath3.Text, strAppPath + @"\Setting.ini");
            WriteIni("TEKKEN", "FilePathResult", strResultFolderPath, strAppPath + @"\Setting.ini");


            var value = Convert.ToString(chkSetName.Checked ? 1 : 0);
            WriteIni("TEKKEN", "SetResultPath", value, strAppPath + @"\Setting.ini");

            value = Convert.ToString(numUD_Repeat.Value);
            WriteIni("TEKKEN", "CheckCount", value, strAppPath + @"\Setting.ini");

            WriteIni("TEKKEN", "SaveFilePath", txtResultFolderPath.Text, strAppPath + @"\Setting.ini");

            value = Convert.ToString(chkSetName.Checked ? 1 : 0);
            WriteIni("TEKKEN", "SetNameCheck", value, strAppPath + @"\Setting.ini");

            WriteIni("TEKKEN", "SetNameText", txtSetName.Text, strAppPath + @"\Setting.ini");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load_INI();
        }
        public string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_]+", "_", RegexOptions.Compiled);
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupFiles();
        }

        public void BackupFiles()
        {
            rbCheckPath();

            if (rtxtbox.InvokeRequired)
            {
                rtxtbox.BeginInvoke(new Action(() => rtxtbox.AppendText("File Copy Start..." + "\r\n")));
            }
            else
            {
                rtxtbox.AppendText("File Copy Start..." + "\r\n");
                rtxtbox.AppendText("\r\n");
            }
            string NowDateTime = DateTime.Now.ToString("yyyy_MMdd_HHmmss");

            if (rtxtbox.InvokeRequired)
            {
                rtxtbox.BeginInvoke(new Action(() => rtxtbox.AppendText("File Copy Date Info : " + NowDateTime.ToString()+ "\r\n")));
            }
            else
            {
                rtxtbox.AppendText("File Copy Date Info : " + NowDateTime.ToString() + "\r\n");
                rtxtbox.AppendText("\r\n");
            }

            TargetPath = strWorkPath;
            if (chkSetResultPath.Checked)
            {
                TargetPath = strWorkPath2;
            }
            
            if (chkSetName.Checked)
            {
                string strVar = RemoveSpecialCharacters(txtSetName.Text);
                TargetPath = TargetPath + strVar;
            }
            TargetPath = TargetPath + @"\" + NowDateTime;

            if (bThread)
            {
                TargetPath = TargetPath + "_" + "Repeat Count " + nCurrentCount.ToString();
            }


            if (Directory.Exists(TargetPath) == false)
            {
                Directory.CreateDirectory(TargetPath);

                if (rtxtbox.InvokeRequired)
                {
                    rtxtbox.BeginInvoke(new Action(() => rtxtbox.AppendText("Folder Create " + TargetPath + "\r\n")));
                }
                else
                {
                    rtxtbox.AppendText("Folder Create " + TargetPath + "\r\n");
                    rtxtbox.AppendText("\r\n");
                }
            }

            foreach (var file in Directory.GetFiles(strWorkPath))
            {
                File.Copy(file, Path.Combine(TargetPath, Path.GetFileName(file)));
            }

            if (!bThread)
            {
                System.Diagnostics.Process.Start(TargetPath);
            }

            if (rtxtbox.InvokeRequired)
            {
                rtxtbox.BeginInvoke(new Action(() => rtxtbox.AppendText("Backup Complete : " + NowDateTime.ToString() + "\r\n")));
            }
            else
            {
                rtxtbox.AppendText("Backup Complete : " + NowDateTime.ToString() + "\r\n");
                rtxtbox.AppendText("\r\n");
            }
            
        }

        public void thCheckFile()
        {
            while (bThread)
            {
                scTekkenFilesNew = new string[6];

                for (int i = 0; i < strRepFileList.Length; i++)
                {
                    string filename = strWorkPath + strRepFileList[i];
                    FileInfo fileInfoOld = new FileInfo(filename);
                    scTekkenFilesNew[i] = fileInfoOld.LastWriteTime.ToString();
                }


                for (int i = 0; i < scTekkenFilesNew.Length; i++)
                {
                    if (scTekkenFilesOld[i].ToString() != scTekkenFilesNew[i].ToString())
                    {
                        scTekkenFilesOld = scTekkenFilesNew;

                        if (nCurrentCount == 1)
                        {
                            if (rtxtbox.InvokeRequired)
                            {
                                rtxtbox.BeginInvoke(new Action(() => rtxtbox.AppendText("Count 0," + " ReStore Count, File Copy Start... " + "\r\n")));
                            }
                            else
                            {
                                rtxtbox.AppendText("Count 0," + " ReStore Count, File Copy Start... " + "\r\n");
                                rtxtbox.AppendText("\r\n");
                            }
                            nCurrentCount = nRepeatCount;
                            BackupFiles();
                            Thread.Sleep(3000);
                        }
                        else
                        {
                            nCurrentCount--;

                            if(rtxtbox.InvokeRequired)
                            {
                                rtxtbox.BeginInvoke(new Action(() => rtxtbox.AppendText("Count - 1, " + " Current Count: " + nCurrentCount.ToString()+ "\r\n")));
                            }
                            else
                            {
                                rtxtbox.AppendText("Count -1," + " Current Count : " + nCurrentCount.ToString());
                                rtxtbox.AppendText("\r\n");
                            }                           
                            Thread.Sleep(3000);
                        }
                    }
                }
                Thread.Sleep(3000);
            }
        }


        private void btnBackupThread_Click(object sender, EventArgs e)
        {
            rbCheckPath();
            for (int i = 0; i < strRepFileList.Length; i++)
            {
                string filename = strWorkPath + strRepFileList[i];
                FileInfo fileInfoOld = new FileInfo(filename);
                scTekkenFilesOld[i] = fileInfoOld.LastWriteTime.ToString();
            }
            nRepeatCount= Convert.ToInt32 (numUD_Repeat.Value);
            nCurrentCount = Convert.ToInt32(numUD_Repeat.Value);

            if (bThread == false)
            {
                bThread = true;
                nCurrentCount = nRepeatCount;
                th = new Thread(thCheckFile);
                th.Start();
                this.Text = "Working...";
            }
            else
            {
                MessageBox.Show("Tekken SaveFile Backup Check Mode off");
                bThread = false;
                th.Join();
                this.Text = "Tekken Data Manager";
            }

        }
        public void rbCheckPath()
        {   
            if (rb1.Checked)
            {
                strWorkPath = txtPath1.Text;
            }
            else if (rb2.Checked)
            {
                strWorkPath = txtPath2.Text;
            }
            else if (rb3.Checked)
            {
                strWorkPath = txtPath3.Text;
            }
        }
        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            rbCheckPath();
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            rbCheckPath();
        }
        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            rbCheckPath();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            // 처음 보여줄 폴더 설정(안해도 됨)
            dialog.InitialDirectory = @"C:\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtResultFolderPath.Text = dialog.FileName; // 테스트용, 폴더 선택이 완료되면 선택된 폴더를 label에 출력
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string rst = Path.GetFileName(Assembly.GetEntryAssembly().Location);
            string filepath;
            filepath = @"C:\Users";
            string tekkenpath = @"\AppData\Local\TekkenGame\Saved\SaveGames\TEKKEN7";

            string[] GetPath;
            List<string> lstPath = new List<string>();

            GetPath = Directory.GetDirectories(filepath);

            foreach (var i in GetPath)
            {
                if (Directory.Exists(i + @"\AppData\Local\TekkenGame\Saved\SaveGames\TEKKEN7"))
                {
                    lstPath.Add(i);
                }
            }

            try
            {
                string result = lstPath[0] + tekkenpath;
                GetPath = Directory.GetDirectories(result);

                txtPath1.Text = GetPath[0];
                txtPath2.Text = GetPath[1];
                txtPath3.Text = GetPath[2];
            }
            catch
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Load_INI();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int nvalue = 1;
            chkSetName.Checked = Convert.ToBoolean(nvalue == 0 ? true : false);
        }

        public void Load_INI()
        {
            strTargetFolderPath1 = ReadIni("TEKKEN", "FilePath_1", strAppPath + @"\Setting.ini");
            strTargetFolderPath2 = ReadIni("TEKKEN", "FilePath_2", strAppPath + @"\Setting.ini");
            strTargetFolderPath3 = ReadIni("TEKKEN", "FilePath_3", strAppPath + @"\Setting.ini");
            strResultFolderPath = ReadIni("TEKKEN", "SaveFilePath", strAppPath + @"\Setting.ini");

            var varResult = ReadIni("TEKKEN", "CheckCount", strAppPath + @"\Setting.ini");
            nRepeatCount = Convert.ToInt32(varResult);


            varResult = ReadIni("TEKKEN", "SetResultPath", strAppPath + @"\Setting.ini");
            nResultCheck = Convert.ToInt32(varResult);

            varResult = ReadIni("TEKKEN", "SetNameCheck", strAppPath + @"\Setting.ini");
            nSetCheck = Convert.ToInt32(varResult);

            strFileText = ReadIni("TEKKEN", "SetNameText", strAppPath + @"\Setting.ini");

            txtPath1.Text = strTargetFolderPath1;
            txtPath2.Text = strTargetFolderPath2;
            txtPath3.Text = strTargetFolderPath3;
            txtResultFolderPath.Text = strResultFolderPath;

            chkSetResultPath.Checked = Convert.ToBoolean(nResultCheck == 1 ? true : false);

            numUD_Repeat.Value = nRepeatCount;

            chkSetName.Checked = Convert.ToBoolean(nSetCheck == 1 ? true : false);

            txtSetName.Text = strFileText;
        }

        private void chkSetResultPath_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSetResultPath.Checked)
            {
                btnFileBrowser_ResultPath.Enabled = true;
                txtResultFolderPath.Enabled = true;
                strWorkPath2 = txtResultFolderPath.Text;
            }
            else
            {
                btnFileBrowser_ResultPath.Enabled = false;
                txtResultFolderPath.Enabled = false;
                strWorkPath2 = txtResultFolderPath.Text;
            }
        }


    }
}

