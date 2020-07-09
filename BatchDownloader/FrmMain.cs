using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchDownloader
{
    public partial class FrmMain : Form
    {
        private static readonly object locker = new object();
        private Queue<string> queueUrl;
        private string localDir = string.Empty;
        private int sCount, fCount;
        private int tCount = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnOpenPage_Click(object sender, EventArgs e)
        {
            if (txtPage.Text != "")
                CreateUrlList(txtPage.Text, txtExt.Text, false);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog { Filter = "TXT File(*.txt)|*.txt|All files(*.*)|*.*" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = dlg.FileName;
                CreateUrlList(dlg.FileName, txtExt.Text, true);
            }
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlg.SelectedPath;
                localDir = dlg.SelectedPath;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (tCount == 0)
                return;
            var dlg = new SaveFileDialog { Filter = "TXT File(*.txt)|*.txt|All files(*.*)|*.*" };
            if (dlg.ShowDialog() == DialogResult.OK)
                SaveUrlList(dlg.FileName);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (tCount == 0 || localDir == "")
                return;
            AsyncDownload();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateUrlList(string path, string extStr, bool byFile)
        {
            rtxLog.Clear();
            var exts = new List<string>();
            exts.AddRange(Regex.Split(extStr, ";"));
            queueUrl = new Queue<string>();
            string read;
            try
            {
                if (byFile)
                {
                    rtxLog.AppendText($"{DateTime.Now}: Read File, {path}...\n\n");
                    using (var sr = new StreamReader(path))
                    {
                        read = sr.ReadToEnd();
                    }
                    string[] lines = Regex.Split(read, "\n");
                    foreach (var line in lines)
                    {
                        if (line.Length < 4 || !exts.Any(s => line.Contains(s)))
                            continue;
                        if (!queueUrl.Contains(line.Trim()))
                            queueUrl.Enqueue(line.Trim());
                    }
                }
                else
                {
                    rtxLog.AppendText($"{DateTime.Now}: View Source, {path}...\n\n");
                    var req = WebRequest.Create(path) as HttpWebRequest;
                    using (var rs = req.GetResponse().GetResponseStream())
                    {
                        using (var sr = new StreamReader(rs))
                        {
                            read = sr.ReadToEnd();
                        }
                    }
                    var ms = Regex.Matches(read, @"href\s*=\s*(?:[""'](?<href>[^""']*)[""']|(?<href>\S+))", RegexOptions.IgnoreCase);
                    foreach (Match m in ms)
                    {
                        string line = m.Groups["href"].Value;
                        if (line.Length < 4 || !exts.Any(s => line.Contains(s)))
                            continue;
                        if (line[0] == '/')
                            line = path.Remove(path.IndexOf("/", 8)) + line;
                        else
                            line = path.Remove(path.LastIndexOf("/") + 1) + line;
                        if (line.Contains("?"))
                            line = line.Remove(line.IndexOf("?"));
                        if (!queueUrl.Contains(line.Trim()))
                            queueUrl.Enqueue(line.Trim());
                    }
                }
            }
            catch (Exception ex) { rtxLog.AppendText($"{DateTime.Now}: Error, {ex.Message}\n"); }
            lstUrl.DataSource = queueUrl.ToArray();
            tCount = queueUrl.Count;
        }

        private void SaveUrlList(string path)
        {
            var sb = new StringBuilder();
            foreach (var item in lstUrl.Items)
                sb.Append("\n" + item.ToString());
            var text = sb.ToString().Substring(1);
            File.WriteAllText(path, text);
        }

        private void AsyncDownload()
        {
            rtxLog.Clear();
            rtxLog.AppendText($"Start download, {tCount} files totally...\n\n");
            sCount = 0;
            fCount = 0;
            for (var i = 0; i < nuTaskNum.Value; i++)
            {
                Task.Run(() => {
                    while (queueUrl.Count != 0)
                    {
                        string url = queueUrl.Dequeue();
                        DownloadFile(url, localDir);
                    }
                });
            }
        }

        private void DownloadFile(string url, string dir)
        {
            string file = url.Substring(url.LastIndexOf('/') + 1);
            lock (locker)
            {
                BeginInvoke(new Action(() => rtxLog.AppendText($"{DateTime.Now}: [{file}] is downloading...\n")));
            }
            try
            {
                new WebClient().DownloadFile(url, Path.Combine(dir, file));
                lock (locker)
                {
                    sCount++;
                    BeginInvoke(new Action(() => rtxLog.AppendText($"{DateTime.Now}: [{file}] successed.\n")));
                }
            }
            catch (Exception ex)
            {
                lock (locker)
                {
                    fCount++;
                    BeginInvoke(new Action(() => rtxLog.AppendText($"{DateTime.Now}: [{file}] failed, {ex.Message}\n")));
                }
            }
            finally
            {
                lock (locker)
                {
                    if (sCount + fCount == tCount)
                        BeginInvoke(new Action(() => rtxLog.AppendText($"\nFinish downloading, {sCount} succeeded, {fCount} failed")));
                }
            }
        }
    }
}