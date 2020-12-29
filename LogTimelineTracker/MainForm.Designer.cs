
namespace LogTimelineTracker
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnDownload = new System.Windows.Forms.ToolStripButton();
            this.btnVertical = new System.Windows.Forms.ToolStripButton();
            this.btnHorizontal = new System.Windows.Forms.ToolStripButton();
            this.btnLive = new System.Windows.Forms.ToolStripButton();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.timeline1 = new TimelineFramework.Timeline();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoad,
            this.btnDownload,
            this.btnSaveAs,
            this.toolStripSeparator1,
            this.btnNew,
            this.btnVertical,
            this.btnHorizontal,
            this.btnLive});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::LogTimelineTracker.Properties.Resources.iconfinder_Plus_2202243;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(36, 36);
            this.btnNew.Text = "Open Tracker";
            // 
            // btnDownload
            // 
            this.btnDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDownload.Image = global::LogTimelineTracker.Properties.Resources.iconfinder_Download_2202271;
            this.btnDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(36, 36);
            this.btnDownload.Text = "Download";
            // 
            // btnVertical
            // 
            this.btnVertical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVertical.Image = global::LogTimelineTracker.Properties.Resources.iconfinder_arrow_vertical_direction_path_way_3209405;
            this.btnVertical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(36, 36);
            this.btnVertical.Text = "Vertical";
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHorizontal.Image = global::LogTimelineTracker.Properties.Resources.iconfinder_arrow_horizontal_direction_path_way_3209404;
            this.btnHorizontal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(36, 36);
            this.btnHorizontal.Text = "Horizontal";
            // 
            // btnLive
            // 
            this.btnLive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLive.Image = global::LogTimelineTracker.Properties.Resources.iconfinder_record_6586139;
            this.btnLive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(36, 36);
            this.btnLive.Text = "Follow Tail";
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementHost1.Location = new System.Drawing.Point(0, 39);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(800, 100);
            this.elementHost1.TabIndex = 3;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.timeline1;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAs.Image = global::LogTimelineTracker.Properties.Resources.iconfinder_save_compact_dist_keep_record_3209460;
            this.btnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(36, 36);
            this.btnSaveAs.Text = "SaveAs";
            // 
            // btnLoad
            // 
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoad.Image = global::LogTimelineTracker.Properties.Resources.iconfinder_folder_storage_organize_file_office_3209337;
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(36, 36);
            this.btnLoad.Text = "Load";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Log Timeline Tracker";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnDownload;
        private System.Windows.Forms.ToolStripButton btnVertical;
        private System.Windows.Forms.ToolStripButton btnHorizontal;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private TimelineFramework.Timeline timeline1;
        private System.Windows.Forms.ToolStripButton btnLive;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.ToolStripButton btnSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

