using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Point MouseHook;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            else
            {
                Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
