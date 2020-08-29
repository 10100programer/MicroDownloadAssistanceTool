using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroDownloadAssistanceTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static System.Timers.Timer maintimer;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            textBox1.BackColor = Color.Lime;
            textBox1.Text = "Checking Clipboard";
            button2.Select();
            richTextBox1.AppendText("ClipboardCheck Enabled\n");
            Clipboard.Clear();//clear before checking
            maintimer.Start();
        }
        private static void SetTimer()
        {
            maintimer = new System.Timers.Timer(500);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.BackColor = Color.Red;
            textBox1.Text = "Not Checking Clipboard";
            button1.Select();
            richTextBox1.AppendText("ClipboardCheck Disabled\n");
            maintimer.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("CB:" + Clipboard.GetText() + "\n");

        }
    }
}
