using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatClient.ServiceChat;

namespace ChatClient
{
    public partial class Form1 : Form, IServiceChatCallback
    {
        bool isConnected;
        ServiceChatClient client;
        int userId;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void ConnectUser()
        {
            if (!isConnected)
            {
                client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
                userId = client.Connect(tbUserName.Text);
                lbMsgs.Items.Clear();
                lbMsgs.Items.AddRange(client.LoadHistory());
            }
        }

        void DisconnectUser()
        {
            if (isConnected)
            {
                client.Disconnect(userId);
                client = null;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (isConnected) DisconnectUser();
            else ConnectUser();

            tbUserName.Enabled = isConnected;
            isConnected = !isConnected;
            btnConnect.Text = isConnected ? "Disconnect" : "Connect";
        }

        public void MsgCallback(string msgText)
        {
            lbMsgs.Items.Add(msgText);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectUser();
        }

        private void tbMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && client != null)
            {
                client.SendMsg(tbMsg.Text, userId);
                tbMsg.Text = string.Empty;
            }
        }

    }
}
