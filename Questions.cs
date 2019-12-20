using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NavyPQS
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }

        private void AppExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetHighlightIcon(object sender, EventArgs e)
        {
            bExit.BackgroundImage = Properties.Resources.closeHighlight;
        }

        private void SetNormalIcon(object sender, EventArgs e)
        {
            bExit.BackgroundImage = Properties.Resources.icons8_close_window_100; 
        }

        private void SetMHicon(object sender, EventArgs e)
        {
            bMinimize.BackgroundImage = Properties.Resources.minimizeHighlight;
        }

        private void SetMNicon(object sender, EventArgs e)
        {
            bMinimize.BackgroundImage = Properties.Resources.minimizeNormal;
        }

        private void AppMinimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
