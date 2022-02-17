using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
            Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy");//tarikh feli ro mide
            label1.Text = DateTime.Now.ToString("HH:mm:ss tt");
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 800;
            timer.Start();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
    }
}
