using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleApp
{
    public partial class Form1 : Form
    {
        private int clicks;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicks++;
            if (clicks == 1)
                label1.Text = clicks + " Click!";
            else
                label1.Text = clicks + " Clicks!";
        }
    }
}
