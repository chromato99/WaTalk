using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WaTalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {   
            string input = inputWindow.Text;
            if (input != null && input.Trim() != "")
            {
                using (var stream = new NetworkStream(Program.server))
                using (var writer = new StreamWriter(stream))
                    writer.WriteLine(input);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.loop = false;
        }

    }    
}