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
    public partial class Information : Form
    {
        public Information(string title, string info)
        {
            InitializeComponent();
            this.Text = title;
            textBox1.Text = info;
        }

        private void Information_Load(object sender, EventArgs e)
        {

        }
    }
}
