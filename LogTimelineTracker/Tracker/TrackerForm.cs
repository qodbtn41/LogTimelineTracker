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

namespace LogTimelineTracker.Tracker
{
    public partial class TrackerForm : Form
    {
		private Thread thread							= null;
        private string logFilePath = string.Empty;
        private long prevFileSize = 0;

        private delegate void AppendTextCallback(Control control, string sText);
        private delegate void SetScrollBarCallback(Control contron);
        private object lock_updateLog = new object();

        public TrackerForm(Form mdiParent)
        {
            InitializeComponent();
            this.MdiParent = mdiParent;
            AddEventHandler();
        }

        private void AddEventHandler()
        {
            this.Load += TrackerForm_Load;
            this.tbxLogFilePath.Click += TbxLogFilePath_Click;
            this.tb_UpdateInterval.Scroll += Tb_UpdateInterval_Scroll;
            this.FormClosed += TrackerForm_FormClosed;
        }

        private void TrackerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            thread.Interrupt();
        }

        private void TrackerForm_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            thread = null;
            thread = new Thread(new ThreadStart(updateLog));
            thread.IsBackground = true;
            thread.Start();
        }

        private void updateLog()
        {
            lock (lock_updateLog)
            {
                try
                {
                    if (!string.Empty.Equals(logFilePath) && !"".Equals(logFilePath))
                    {
                        FileInfo fileInfo = new FileInfo(logFilePath);
                        FileStream fileStream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        long currentFileSize = fileInfo.Length;

                        if (prevFileSize != 0 && prevFileSize != currentFileSize)
                        {
                            fileStream.Seek(prevFileSize, SeekOrigin.Begin);
                            using (StreamReader streamReader = new StreamReader(fileStream, Encoding.GetEncoding("EUC-KR")))
                            {
                                while (!streamReader.EndOfStream)
                                {
                                    AppendText(rtbLog, streamReader.ReadLine());
                                }
                                SetScrollBar(rtbLog);
                            }
                        }
                        prevFileSize = currentFileSize;
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("뿅~~ IOException 출현!!");
                    Console.WriteLine(ex.ToString());
                    timer.Stop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("뿅~~ Exception 출현!!");
                    Console.WriteLine(ex.ToString());
                    timer.Stop();
                }
            }
        }
        private void SetScrollBar(Control control)
        {
            if (control.InvokeRequired)
            {
                SetScrollBarCallback callBack = new SetScrollBarCallback(SetScrollBar);
                this.Invoke(callBack, new object[] { control });
            }
            else
            {
                rtbLog.SelectionStart = rtbLog.TextLength;
                rtbLog.ScrollToCaret();
            }
        }

        private void TbxLogFilePath_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "로그파일 (*.log)|*.log";
            openFileDialog.ShowDialog();

            if (!string.Empty.Equals(openFileDialog.FileName) && !"".Equals(openFileDialog.FileName))
            {
                timer.Stop();

                if (thread != null)
                    thread.Interrupt();

                logFilePath = openFileDialog.FileName;
                tbxLogFilePath.Text = logFilePath;
                prevFileSize = 0;

                ClearLog();

                timer.Start();
            }

            openFileDialog.Dispose();
        }
        private void ClearLog()
        {
            rtbLog.Clear();
        }
        private void Tb_UpdateInterval_Scroll(object sender, EventArgs e)
        {
            lb_UpdateInterval.Text = "0." + tb_UpdateInterval.Value.ToString() + "초";
            timer.Interval = 100 * tb_UpdateInterval.Value;
        }

        private void AppendText(Control control, string sText)
        {
            if (control.InvokeRequired)
            {
                AppendTextCallback callBack = new AppendTextCallback(AppendText);
                this.Invoke(callBack, new object[] { control, sText });
            }
            else
            {
                (control as RichTextBox).AppendText(sText + "\n");
            }
        }
    }
}
