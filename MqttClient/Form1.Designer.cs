namespace MqttClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblClientId = new System.Windows.Forms.Label();
            this.lblTcpServer = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblCredential = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtboxCredential = new System.Windows.Forms.TextBox();
            this.txtboxClientId = new System.Windows.Forms.TextBox();
            this.txtboxTcpServer = new System.Windows.Forms.TextBox();
            this.txtboxPort = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtboxPublishTopic = new System.Windows.Forms.TextBox();
            this.txtboxPayload = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.lblPayload = new System.Windows.Forms.Label();
            this.lblPublishTopic = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtboxSubscribeTopic = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.lblSubscribeTopic = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridviewMessages = new System.Windows.Forms.DataGridView();
            this.Msg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QoS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(26, 29);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(69, 20);
            this.lblClientId.TabIndex = 0;
            this.lblClientId.Text = "Client ID:";
            // 
            // lblTcpServer
            // 
            this.lblTcpServer.AutoSize = true;
            this.lblTcpServer.Location = new System.Drawing.Point(26, 65);
            this.lblTcpServer.Name = "lblTcpServer";
            this.lblTcpServer.Size = new System.Drawing.Size(81, 20);
            this.lblTcpServer.TabIndex = 1;
            this.lblTcpServer.Text = "TCP Server:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(26, 102);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 20);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // lblCredential
            // 
            this.lblCredential.AutoSize = true;
            this.lblCredential.Location = new System.Drawing.Point(26, 136);
            this.lblCredential.Name = "lblCredential";
            this.lblCredential.Size = new System.Drawing.Size(80, 20);
            this.lblCredential.TabIndex = 3;
            this.lblCredential.Text = "Credential:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(26, 173);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // txtboxCredential
            // 
            this.txtboxCredential.Location = new System.Drawing.Point(112, 133);
            this.txtboxCredential.Name = "txtboxCredential";
            this.txtboxCredential.Size = new System.Drawing.Size(432, 27);
            this.txtboxCredential.TabIndex = 5;
            // 
            // txtboxClientId
            // 
            this.txtboxClientId.Location = new System.Drawing.Point(112, 26);
            this.txtboxClientId.Name = "txtboxClientId";
            this.txtboxClientId.Size = new System.Drawing.Size(432, 27);
            this.txtboxClientId.TabIndex = 6;
            // 
            // txtboxTcpServer
            // 
            this.txtboxTcpServer.Location = new System.Drawing.Point(113, 62);
            this.txtboxTcpServer.Name = "txtboxTcpServer";
            this.txtboxTcpServer.Size = new System.Drawing.Size(432, 27);
            this.txtboxTcpServer.TabIndex = 7;
            // 
            // txtboxPort
            // 
            this.txtboxPort.Location = new System.Drawing.Point(113, 99);
            this.txtboxPort.Name = "txtboxPort";
            this.txtboxPort.Size = new System.Drawing.Size(432, 27);
            this.txtboxPort.TabIndex = 8;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(112, 170);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.Size = new System.Drawing.Size(432, 27);
            this.txtboxPassword.TabIndex = 9;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(567, 45);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(182, 134);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtboxClientId);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.lblClientId);
            this.groupBox1.Controls.Add(this.lblTcpServer);
            this.groupBox1.Controls.Add(this.txtboxPassword);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.txtboxPort);
            this.groupBox1.Controls.Add(this.lblCredential);
            this.groupBox1.Controls.Add(this.txtboxTcpServer);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtboxCredential);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 211);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtboxPublishTopic);
            this.groupBox2.Controls.Add(this.txtboxPayload);
            this.groupBox2.Controls.Add(this.btnPublish);
            this.groupBox2.Controls.Add(this.lblPayload);
            this.groupBox2.Controls.Add(this.lblPublishTopic);
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 111);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Publish";
            // 
            // txtboxPublishTopic
            // 
            this.txtboxPublishTopic.Location = new System.Drawing.Point(111, 28);
            this.txtboxPublishTopic.Name = "txtboxPublishTopic";
            this.txtboxPublishTopic.Size = new System.Drawing.Size(432, 27);
            this.txtboxPublishTopic.TabIndex = 13;
            // 
            // txtboxPayload
            // 
            this.txtboxPayload.Location = new System.Drawing.Point(112, 64);
            this.txtboxPayload.Name = "txtboxPayload";
            this.txtboxPayload.Size = new System.Drawing.Size(432, 27);
            this.txtboxPayload.TabIndex = 14;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(567, 26);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(182, 65);
            this.btnPublish.TabIndex = 15;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // lblPayload
            // 
            this.lblPayload.AutoSize = true;
            this.lblPayload.Location = new System.Drawing.Point(25, 67);
            this.lblPayload.Name = "lblPayload";
            this.lblPayload.Size = new System.Drawing.Size(61, 20);
            this.lblPayload.TabIndex = 12;
            this.lblPayload.Text = "Payload";
            // 
            // lblPublishTopic
            // 
            this.lblPublishTopic.AutoSize = true;
            this.lblPublishTopic.Location = new System.Drawing.Point(25, 31);
            this.lblPublishTopic.Name = "lblPublishTopic";
            this.lblPublishTopic.Size = new System.Drawing.Size(48, 20);
            this.lblPublishTopic.TabIndex = 11;
            this.lblPublishTopic.Text = "Topic:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtboxSubscribeTopic);
            this.groupBox3.Controls.Add(this.btnSubscribe);
            this.groupBox3.Controls.Add(this.lblSubscribeTopic);
            this.groupBox3.Location = new System.Drawing.Point(12, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 68);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subscribe";
            // 
            // txtboxSubscribeTopic
            // 
            this.txtboxSubscribeTopic.Location = new System.Drawing.Point(111, 28);
            this.txtboxSubscribeTopic.Name = "txtboxSubscribeTopic";
            this.txtboxSubscribeTopic.Size = new System.Drawing.Size(432, 27);
            this.txtboxSubscribeTopic.TabIndex = 13;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(567, 26);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(182, 29);
            this.btnSubscribe.TabIndex = 15;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // lblSubscribeTopic
            // 
            this.lblSubscribeTopic.AutoSize = true;
            this.lblSubscribeTopic.Location = new System.Drawing.Point(25, 31);
            this.lblSubscribeTopic.Name = "lblSubscribeTopic";
            this.lblSubscribeTopic.Size = new System.Drawing.Size(48, 20);
            this.lblSubscribeTopic.TabIndex = 11;
            this.lblSubscribeTopic.Text = "Topic:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gridviewMessages);
            this.groupBox4.Location = new System.Drawing.Point(12, 420);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 209);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Messages";
            // 
            // gridviewMessages
            // 
            this.gridviewMessages.AllowUserToAddRows = false;
            this.gridviewMessages.AllowUserToDeleteRows = false;
            this.gridviewMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Msg,
            this.Topic,
            this.Payload,
            this.QoS});
            this.gridviewMessages.Location = new System.Drawing.Point(6, 26);
            this.gridviewMessages.Name = "gridviewMessages";
            this.gridviewMessages.ReadOnly = true;
            this.gridviewMessages.RowHeadersWidth = 51;
            this.gridviewMessages.RowTemplate.Height = 29;
            this.gridviewMessages.Size = new System.Drawing.Size(764, 177);
            this.gridviewMessages.TabIndex = 14;
            // 
            // Msg
            // 
            this.Msg.HeaderText = "Msg";
            this.Msg.MinimumWidth = 6;
            this.Msg.Name = "Msg";
            this.Msg.ReadOnly = true;
            this.Msg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Msg.Width = 40;
            // 
            // Topic
            // 
            this.Topic.HeaderText = "Topic";
            this.Topic.MinimumWidth = 6;
            this.Topic.Name = "Topic";
            this.Topic.ReadOnly = true;
            this.Topic.Width = 200;
            // 
            // Payload
            // 
            this.Payload.HeaderText = "Payload";
            this.Payload.MinimumWidth = 6;
            this.Payload.Name = "Payload";
            this.Payload.ReadOnly = true;
            this.Payload.Width = 400;
            // 
            // QoS
            // 
            this.QoS.HeaderText = "QoS";
            this.QoS.MinimumWidth = 6;
            this.QoS.Name = "QoS";
            this.QoS.ReadOnly = true;
            this.QoS.Width = 55;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MQTT Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblTcpServer;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblCredential;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtboxCredential;
        private System.Windows.Forms.TextBox txtboxClientId;
        private System.Windows.Forms.TextBox txtboxTcpServer;
        private System.Windows.Forms.TextBox txtboxPort;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtboxPublishTopic;
        private System.Windows.Forms.TextBox txtboxPayload;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Label lblPayload;
        private System.Windows.Forms.Label lblPublishTopic;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtboxSubscribeTopic;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Label lblSubscribeTopic;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView gridviewMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Msg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payload;
        private System.Windows.Forms.DataGridViewTextBoxColumn QoS;
        private System.Windows.Forms.Timer timer1;
    }
}
