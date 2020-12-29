using LogTimelineTracker.Tracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogTimelineTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddEventHandler();
        }

        private void AddEventHandler()
        {
            this.Load += MainForm_Load;
            this.btnNew.Click += BtnNew_Click;
            this.btnHorizontal.Click += BtnHorizontal_Click;
            this.btnVertical.Click += BtnVertical_Click;
        }

        private void BtnHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void BtnVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TrackerForm form = new TrackerForm(this);
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.timeline1.Setup(0, 60, 10, 150);
            this.timeline1.AddElement(13);
        }
    }
}
