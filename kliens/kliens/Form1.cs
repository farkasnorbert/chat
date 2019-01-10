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
using System.Threading;
using System.Diagnostics;

namespace kliens
{
    public partial class Chat : Form
    {
        private int Port;
        private String Ip;
        private String uName;
        private TcpClient socket=null;
        private int pm = 0;
        public Chat()
        {
            InitializeComponent();
        }
        private byte[] ReadBytes(int count)
        {
            NetworkStream networkStream = socket.GetStream();

            byte[] bytes = new byte[count]; // buffer to fill (and later return)
            int readCount = 0; // bytes is empty at the start

            // while the buffer is not full
            while (readCount < count)
            {
                // ask for no-more than the number of bytes left to fill our byte[]
                int left = count - readCount; // we will ask for `left` bytes
                int r = networkStream.Read(bytes, readCount, left); // but we are given `r` bytes (`r` <= `left`)

                if (r == 0)
                {
                    throw new Exception("Lost Connection during read");
                }

                readCount += r; // advance by however many bytes we read
            }

            return bytes;
        }
        private string ReadMessage()
        {
            // read length bytes, and flip if necessary
            byte[] lengthBytes = ReadBytes(sizeof(int)); // int is 4 bytes
            if (System.BitConverter.IsLittleEndian)
            {
                Array.Reverse(lengthBytes);
            }

            // decode length
            int length = System.BitConverter.ToInt32(lengthBytes, 0);

            // read message bytes
            byte[] messageBytes = ReadBytes(length);

            // decode the message
            string message = System.Text.Encoding.ASCII.GetString(messageBytes);

            return message;
        }
        private void read()
        {

            while (true)
            {
                string message = ReadMessage();
                if (message != "")
                {
                    if (message.Contains("\\listusers:"))
                    {
                        //usereket kapja meg
                        string[] users = message.Split(' ');
                        foreach (var user in users)
                        {
                            if (user != "\\listusers:")
                            {
                                Invoke(new Action(() =>
                                {
                                    userslist.Items.Add(user);
                                }));
                            }
                        }
                    }
                    else if(message.Contains("\\PMexit") == false && message.Contains("\\pm with")==false && message.Contains("\\listusers") == false)
                    {
                        //minki latja ezt az uzenetet
                        Invoke(new Action(() =>
                        {
                            messages.AppendText(message + "\r\n");
                        }));
                    }
                }
            }
        }
        private void send(String m)
        {
            if (socket == null)
            {
                MessageBox.Show("Not connected", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NetworkStream networkStream = socket.GetStream();
            byte[] messageBytes = Encoding.ASCII.GetBytes(m);
            int length = messageBytes.Length;
            byte[] lengthBytes = System.BitConverter.GetBytes(length);
            if (System.BitConverter.IsLittleEndian)
            {
                Array.Reverse(lengthBytes);
            }
            networkStream.Write(lengthBytes, 0, lengthBytes.Length);
            networkStream.Write(messageBytes, 0, length);
        }
        private void connect_Click(object sender, EventArgs e)
        {
            uName = name.Text;
            if (uName == "")
            {
                MessageBox.Show("No username", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Ip = "127.0.0.1";
            Port = 10013;
            try
            {
                socket = new TcpClient(Ip, Port);
            }
            catch(SocketException socketException)
            {
                Debug.WriteLine("Socket exception: " + socketException);
                socket = null;
                MessageBox.Show("Server error", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Sucesfuly connected", "Connected",
                MessageBoxButtons.OK, MessageBoxIcon.None);
            var t = new Thread(read);
            t.Start();
            send(uName);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            String text = message.Text;
            send(text);
        }

        private void loadusers_Click(object sender, EventArgs e)
        {
            send("\\listusers");
        }

        private void exitPm_Click(object sender, EventArgs e)
        {
            send("\\PMexit");
            pm = 0;
        }

        private void userslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string u = userslist.SelectedItem.ToString();
            pm = 1;
            send("\\pm with "+u);
            messages.AppendText("You are talking with "+u+"\n");
        }
    }
}
