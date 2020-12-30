
namespace LogTimelineTracker.Tracker
{
    partial class TrackerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_UpdateInterval = new System.Windows.Forms.Label();
            this.tb_UpdateInterval = new System.Windows.Forms.TrackBar();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLogFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxFilePattern = new System.Windows.Forms.TextBox();
            this.tbxLogPattern = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_UpdateInterval)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 71);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_UpdateInterval);
            this.panel1.Controls.Add(this.tb_UpdateInterval);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(672, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 71);
            this.panel1.TabIndex = 11;
            // 
            // lb_UpdateInterval
            // 
            this.lb_UpdateInterval.AutoSize = true;
            this.lb_UpdateInterval.Location = new System.Drawing.Point(93, 44);
            this.lb_UpdateInterval.Name = "lb_UpdateInterval";
            this.lb_UpdateInterval.Size = new System.Drawing.Size(33, 12);
            this.lb_UpdateInterval.TabIndex = 10;
            this.lb_UpdateInterval.Text = "0.1초";
            // 
            // tb_UpdateInterval
            // 
            this.tb_UpdateInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_UpdateInterval.LargeChange = 1;
            this.tb_UpdateInterval.Location = new System.Drawing.Point(0, 0);
            this.tb_UpdateInterval.Minimum = 1;
            this.tb_UpdateInterval.Name = "tb_UpdateInterval";
            this.tb_UpdateInterval.Size = new System.Drawing.Size(128, 71);
            this.tb_UpdateInterval.TabIndex = 9;
            this.tb_UpdateInterval.Value = 1;
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.SystemColors.WindowText;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbLog.Location = new System.Drawing.Point(0, 71);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(800, 379);
            this.rtbLog.TabIndex = 5;
            this.rtbLog.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.36336F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.63663F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbxLogFilePath, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbxFilePattern, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbxLogPattern, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(666, 65);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "로그 경로";
            // 
            // tbxLogFilePath
            // 
            this.tbxLogFilePath.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbxLogFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLogFilePath.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxLogFilePath.Location = new System.Drawing.Point(91, 3);
            this.tbxLogFilePath.Name = "tbxLogFilePath";
            this.tbxLogFilePath.Size = new System.Drawing.Size(572, 21);
            this.tbxLogFilePath.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "파일 패턴";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "로그 패턴";
            // 
            // tbxFilePattern
            // 
            this.tbxFilePattern.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbxFilePattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFilePattern.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxFilePattern.Location = new System.Drawing.Point(91, 25);
            this.tbxFilePattern.Name = "tbxFilePattern";
            this.tbxFilePattern.Size = new System.Drawing.Size(572, 21);
            this.tbxFilePattern.TabIndex = 22;
            // 
            // tbxLogPattern
            // 
            this.tbxLogPattern.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbxLogPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLogPattern.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxLogPattern.Location = new System.Drawing.Point(91, 47);
            this.tbxLogPattern.Name = "tbxLogPattern";
            this.tbxLogPattern.Size = new System.Drawing.Size(572, 21);
            this.tbxLogPattern.TabIndex = 23;
            // 
            // TrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TrackerForm";
            this.Text = "TrackerForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_UpdateInterval)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_UpdateInterval;
        private System.Windows.Forms.TrackBar tb_UpdateInterval;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxLogFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFilePattern;
        private System.Windows.Forms.TextBox tbxLogPattern;
    }
}