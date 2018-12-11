﻿namespace kliens
{
    partial class Chat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Send = new System.Windows.Forms.Button();
            this.messages = new System.Windows.Forms.RichTextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.userslist = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loadusers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(322, 165);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 0;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // messages
            // 
            this.messages.Location = new System.Drawing.Point(0, 2);
            this.messages.Name = "messages";
            this.messages.ReadOnly = true;
            this.messages.Size = new System.Drawing.Size(299, 151);
            this.messages.TabIndex = 2;
            this.messages.Text = "";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(0, 168);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(299, 20);
            this.message.TabIndex = 3;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(305, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 4;
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(305, 57);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(100, 20);
            this.ip.TabIndex = 5;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(305, 96);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 20);
            this.port.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Port";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(322, 122);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 10;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // userslist
            // 
            this.userslist.FormattingEnabled = true;
            this.userslist.Location = new System.Drawing.Point(411, 20);
            this.userslist.Name = "userslist";
            this.userslist.Size = new System.Drawing.Size(120, 134);
            this.userslist.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Users";
            // 
            // loadusers
            // 
            this.loadusers.Location = new System.Drawing.Point(430, 165);
            this.loadusers.Name = "loadusers";
            this.loadusers.Size = new System.Drawing.Size(75, 23);
            this.loadusers.TabIndex = 13;
            this.loadusers.Text = "Load";
            this.loadusers.UseVisualStyleBackColor = true;
            this.loadusers.Click += new System.EventHandler(this.loadusers_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 205);
            this.Controls.Add(this.loadusers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userslist);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.name);
            this.Controls.Add(this.message);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.messages);
            this.Name = "Chat";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.RichTextBox messages;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ListBox userslist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loadusers;
    }
}

