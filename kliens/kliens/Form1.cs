using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;

namespace kliens
{
    public partial class Chat : Form
    {
        private int Port;
        private String Ip;
        private String uName;
        public Chat()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            uName = name.Text;
            Ip = ip.Text;
            Port = Convert.ToInt32(port.Text);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            String text = message.Text;

        }

        private void loadusers_Click(object sender, EventArgs e)
        {

        }
    }
}
