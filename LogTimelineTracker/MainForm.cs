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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.timeline1.Setup(0, 60, 10, 150);
            this.timeline1.AddElement(13);
        }
    }
}
