using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogTimelineTracker.Tracker
{
    public partial class TrackerForm : Form
    {
        public TrackerForm(Form mdiParent)
        {
            InitializeComponent();
            this.MdiParent = mdiParent;
        }
    }
}
