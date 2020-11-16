namespace ChatClient
{
    partial class Form1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbMsgs = new System.Windows.Forms.ListBox();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.lableUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(238, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(147, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(75, 15);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(131, 20);
            this.tbUserName.TabIndex = 1;
            // 
            // lbMsgs
            // 
            this.lbMsgs.FormattingEnabled = true;
            this.lbMsgs.Location = new System.Drawing.Point(12, 41);
            this.lbMsgs.Name = "lbMsgs";
            this.lbMsgs.Size = new System.Drawing.Size(373, 147);
            this.lbMsgs.TabIndex = 2;
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(12, 194);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(373, 51);
            this.tbMsg.TabIndex = 1;
            this.tbMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMsg_KeyDown);
            // 
            // lableUserName
            // 
            this.lableUserName.AutoSize = true;
            this.lableUserName.Location = new System.Drawing.Point(12, 18);
            this.lableUserName.Name = "lableUserName";
            this.lableUserName.Size = new System.Drawing.Size(57, 13);
            this.lableUserName.TabIndex = 3;
            this.lableUserName.Text = "UserName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 257);
            this.Controls.Add(this.lableUserName);
            this.Controls.Add(this.lbMsgs);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.ListBox lbMsgs;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Label lableUserName;
    }
}

