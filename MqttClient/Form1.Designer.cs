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
            this.lblHost = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxClientId = new System.Windows.Forms.TextBox();
            this.txtboxTcpServer = new System.Windows.Forms.TextBox();
            this.txtboxPort = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbConnectionStatus = new System.Windows.Forms.ProgressBar();
            this.lblLwtMessage = new System.Windows.Forms.Label();
            this.txtboxLwtMessage = new System.Windows.Forms.TextBox();
            this.checkxoxLwtRetain = new System.Windows.Forms.CheckBox();
            this.lblLwtQoS = new System.Windows.Forms.Label();
            this.comboboxLwtQos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxLwtTopic = new System.Windows.Forms.TextBox();
            this.checkboxCleanSession = new System.Windows.Forms.CheckBox();
            this.lblKeepAlive = new System.Windows.Forms.Label();
            this.txtboxKeepAlive = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkboxPubRetain = new System.Windows.Forms.CheckBox();
            this.lblPubQoS = new System.Windows.Forms.Label();
            this.comboboxPubQoS = new System.Windows.Forms.ComboBox();
            this.txtboxPublishTopic = new System.Windows.Forms.TextBox();
            this.txtboxPayload = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.lblPayload = new System.Windows.Forms.Label();
            this.lblPublishTopic = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubSubscriptions = new System.Windows.Forms.Label();
            this.listviewSubSubscriptions = new System.Windows.Forms.ListView();
            this.lblSubQoS = new System.Windows.Forms.Label();
            this.comboboxSubQoS = new System.Windows.Forms.ComboBox();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtboxLog = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewMessages)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(573, 27);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(69, 20);
            this.lblClientId.TabIndex = 0;
            this.lblClientId.Text = "Client ID:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(34, 27);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(43, 20);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "Host:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(482, 27);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 20);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(34, 93);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(78, 20);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(482, 93);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(34, 116);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(442, 27);
            this.txtboxUsername.TabIndex = 5;
            // 
            // txtboxClientId
            // 
            this.txtboxClientId.Location = new System.Drawing.Point(573, 50);
            this.txtboxClientId.Name = "txtboxClientId";
            this.txtboxClientId.Size = new System.Drawing.Size(341, 27);
            this.txtboxClientId.TabIndex = 6;
            // 
            // txtboxTcpServer
            // 
            this.txtboxTcpServer.Location = new System.Drawing.Point(34, 50);
            this.txtboxTcpServer.Name = "txtboxTcpServer";
            this.txtboxTcpServer.Size = new System.Drawing.Size(442, 27);
            this.txtboxTcpServer.TabIndex = 7;
            // 
            // txtboxPort
            // 
            this.txtboxPort.Location = new System.Drawing.Point(482, 50);
            this.txtboxPort.Name = "txtboxPort";
            this.txtboxPort.Size = new System.Drawing.Size(85, 27);
            this.txtboxPort.TabIndex = 8;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(482, 116);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.Size = new System.Drawing.Size(331, 27);
            this.txtboxPassword.TabIndex = 9;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(1106, 50);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(165, 93);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pbConnectionStatus);
            this.groupBox1.Controls.Add(this.lblLwtMessage);
            this.groupBox1.Controls.Add(this.txtboxLwtMessage);
            this.groupBox1.Controls.Add(this.checkxoxLwtRetain);
            this.groupBox1.Controls.Add(this.lblLwtQoS);
            this.groupBox1.Controls.Add(this.comboboxLwtQos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtboxLwtTopic);
            this.groupBox1.Controls.Add(this.checkboxCleanSession);
            this.groupBox1.Controls.Add(this.lblKeepAlive);
            this.groupBox1.Controls.Add(this.txtboxKeepAlive);
            this.groupBox1.Controls.Add(this.txtboxClientId);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.lblClientId);
            this.groupBox1.Controls.Add(this.lblHost);
            this.groupBox1.Controls.Add(this.txtboxPassword);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.txtboxPort);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.txtboxTcpServer);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtboxUsername);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1308, 295);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1106, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Connection Status";
            // 
            // pbConnectionStatus
            // 
            this.pbConnectionStatus.Location = new System.Drawing.Point(1106, 187);
            this.pbConnectionStatus.Name = "pbConnectionStatus";
            this.pbConnectionStatus.Size = new System.Drawing.Size(165, 29);
            this.pbConnectionStatus.TabIndex = 20;
            // 
            // lblLwtMessage
            // 
            this.lblLwtMessage.AutoSize = true;
            this.lblLwtMessage.Location = new System.Drawing.Point(34, 230);
            this.lblLwtMessage.Name = "lblLwtMessage";
            this.lblLwtMessage.Size = new System.Drawing.Size(132, 20);
            this.lblLwtMessage.TabIndex = 18;
            this.lblLwtMessage.Text = "Last-Will Message:";
            // 
            // txtboxLwtMessage
            // 
            this.txtboxLwtMessage.Location = new System.Drawing.Point(34, 253);
            this.txtboxLwtMessage.Name = "txtboxLwtMessage";
            this.txtboxLwtMessage.Size = new System.Drawing.Size(1237, 27);
            this.txtboxLwtMessage.TabIndex = 19;
            // 
            // checkxoxLwtRetain
            // 
            this.checkxoxLwtRetain.AutoSize = true;
            this.checkxoxLwtRetain.Location = new System.Drawing.Point(941, 187);
            this.checkxoxLwtRetain.Name = "checkxoxLwtRetain";
            this.checkxoxLwtRetain.Size = new System.Drawing.Size(135, 24);
            this.checkxoxLwtRetain.TabIndex = 17;
            this.checkxoxLwtRetain.Text = "Last-Will Retain";
            this.checkxoxLwtRetain.UseVisualStyleBackColor = true;
            // 
            // lblLwtQoS
            // 
            this.lblLwtQoS.AutoSize = true;
            this.lblLwtQoS.Location = new System.Drawing.Point(673, 162);
            this.lblLwtQoS.Name = "lblLwtQoS";
            this.lblLwtQoS.Size = new System.Drawing.Size(102, 20);
            this.lblLwtQoS.TabIndex = 16;
            this.lblLwtQoS.Text = "Last-Will QoS:";
            // 
            // comboboxLwtQos
            // 
            this.comboboxLwtQos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxLwtQos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboboxLwtQos.FormattingEnabled = true;
            this.comboboxLwtQos.Location = new System.Drawing.Point(673, 185);
            this.comboboxLwtQos.Name = "comboboxLwtQos";
            this.comboboxLwtQos.Size = new System.Drawing.Size(241, 28);
            this.comboboxLwtQos.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Last-Will Topic:";
            // 
            // txtboxLwtTopic
            // 
            this.txtboxLwtTopic.Location = new System.Drawing.Point(34, 185);
            this.txtboxLwtTopic.Name = "txtboxLwtTopic";
            this.txtboxLwtTopic.Size = new System.Drawing.Size(633, 27);
            this.txtboxLwtTopic.TabIndex = 15;
            // 
            // checkboxCleanSession
            // 
            this.checkboxCleanSession.AutoSize = true;
            this.checkboxCleanSession.Location = new System.Drawing.Point(941, 118);
            this.checkboxCleanSession.Name = "checkboxCleanSession";
            this.checkboxCleanSession.Size = new System.Drawing.Size(121, 24);
            this.checkboxCleanSession.TabIndex = 13;
            this.checkboxCleanSession.Text = "Clean Session";
            this.checkboxCleanSession.UseVisualStyleBackColor = true;
            // 
            // lblKeepAlive
            // 
            this.lblKeepAlive.AutoSize = true;
            this.lblKeepAlive.Location = new System.Drawing.Point(819, 93);
            this.lblKeepAlive.Name = "lblKeepAlive";
            this.lblKeepAlive.Size = new System.Drawing.Size(83, 20);
            this.lblKeepAlive.TabIndex = 11;
            this.lblKeepAlive.Text = "Keep Alive:";
            // 
            // txtboxKeepAlive
            // 
            this.txtboxKeepAlive.Location = new System.Drawing.Point(819, 116);
            this.txtboxKeepAlive.Name = "txtboxKeepAlive";
            this.txtboxKeepAlive.Size = new System.Drawing.Size(95, 27);
            this.txtboxKeepAlive.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkboxPubRetain);
            this.groupBox2.Controls.Add(this.lblPubQoS);
            this.groupBox2.Controls.Add(this.comboboxPubQoS);
            this.groupBox2.Controls.Add(this.txtboxPublishTopic);
            this.groupBox2.Controls.Add(this.txtboxPayload);
            this.groupBox2.Controls.Add(this.btnPublish);
            this.groupBox2.Controls.Add(this.lblPayload);
            this.groupBox2.Controls.Add(this.lblPublishTopic);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 543);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Publish";
            // 
            // checkboxPubRetain
            // 
            this.checkboxPubRetain.AutoSize = true;
            this.checkboxPubRetain.Location = new System.Drawing.Point(418, 183);
            this.checkboxPubRetain.Name = "checkboxPubRetain";
            this.checkboxPubRetain.Size = new System.Drawing.Size(73, 24);
            this.checkboxPubRetain.TabIndex = 21;
            this.checkboxPubRetain.Text = "Retain";
            this.checkboxPubRetain.UseVisualStyleBackColor = true;
            // 
            // lblPubQoS
            // 
            this.lblPubQoS.AutoSize = true;
            this.lblPubQoS.Location = new System.Drawing.Point(11, 158);
            this.lblPubQoS.Name = "lblPubQoS";
            this.lblPubQoS.Size = new System.Drawing.Size(40, 20);
            this.lblPubQoS.TabIndex = 19;
            this.lblPubQoS.Text = "QoS:";
            // 
            // comboboxPubQoS
            // 
            this.comboboxPubQoS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxPubQoS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboboxPubQoS.FormattingEnabled = true;
            this.comboboxPubQoS.Location = new System.Drawing.Point(11, 181);
            this.comboboxPubQoS.Name = "comboboxPubQoS";
            this.comboboxPubQoS.Size = new System.Drawing.Size(279, 28);
            this.comboboxPubQoS.TabIndex = 20;
            // 
            // txtboxPublishTopic
            // 
            this.txtboxPublishTopic.Location = new System.Drawing.Point(11, 46);
            this.txtboxPublishTopic.Name = "txtboxPublishTopic";
            this.txtboxPublishTopic.Size = new System.Drawing.Size(480, 27);
            this.txtboxPublishTopic.TabIndex = 13;
            // 
            // txtboxPayload
            // 
            this.txtboxPayload.Location = new System.Drawing.Point(11, 108);
            this.txtboxPayload.Name = "txtboxPayload";
            this.txtboxPayload.Size = new System.Drawing.Size(480, 27);
            this.txtboxPayload.TabIndex = 14;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(497, 46);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(145, 94);
            this.btnPublish.TabIndex = 15;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // lblPayload
            // 
            this.lblPayload.AutoSize = true;
            this.lblPayload.Location = new System.Drawing.Point(11, 88);
            this.lblPayload.Name = "lblPayload";
            this.lblPayload.Size = new System.Drawing.Size(61, 20);
            this.lblPayload.TabIndex = 12;
            this.lblPayload.Text = "Payload";
            // 
            // lblPublishTopic
            // 
            this.lblPublishTopic.AutoSize = true;
            this.lblPublishTopic.Location = new System.Drawing.Point(11, 27);
            this.lblPublishTopic.Name = "lblPublishTopic";
            this.lblPublishTopic.Size = new System.Drawing.Size(48, 20);
            this.lblPublishTopic.TabIndex = 11;
            this.lblPublishTopic.Text = "Topic:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblSubSubscriptions);
            this.groupBox3.Controls.Add(this.listviewSubSubscriptions);
            this.groupBox3.Controls.Add(this.lblSubQoS);
            this.groupBox3.Controls.Add(this.comboboxSubQoS);
            this.groupBox3.Controls.Add(this.txtboxSubscribeTopic);
            this.groupBox3.Controls.Add(this.btnSubscribe);
            this.groupBox3.Controls.Add(this.lblSubscribeTopic);
            this.groupBox3.Location = new System.Drawing.Point(660, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 543);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subscribe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Double click in an item to copy it\'s topic.";
            // 
            // lblSubSubscriptions
            // 
            this.lblSubSubscriptions.AutoSize = true;
            this.lblSubSubscriptions.Location = new System.Drawing.Point(6, 158);
            this.lblSubSubscriptions.Name = "lblSubSubscriptions";
            this.lblSubSubscriptions.Size = new System.Drawing.Size(100, 20);
            this.lblSubSubscriptions.TabIndex = 16;
            this.lblSubSubscriptions.Text = "Subscriptions:";
            // 
            // listviewSubSubscriptions
            // 
            this.listviewSubSubscriptions.FullRowSelect = true;
            this.listviewSubSubscriptions.HideSelection = false;
            this.listviewSubSubscriptions.Location = new System.Drawing.Point(6, 181);
            this.listviewSubSubscriptions.Name = "listviewSubSubscriptions";
            this.listviewSubSubscriptions.Size = new System.Drawing.Size(642, 356);
            this.listviewSubSubscriptions.TabIndex = 19;
            this.listviewSubSubscriptions.UseCompatibleStateImageBehavior = false;
            this.listviewSubSubscriptions.View = System.Windows.Forms.View.Details;
            this.listviewSubSubscriptions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listviewSubSubscriptions_MouseDoubleClick);
            // 
            // lblSubQoS
            // 
            this.lblSubQoS.AutoSize = true;
            this.lblSubQoS.Location = new System.Drawing.Point(6, 85);
            this.lblSubQoS.Name = "lblSubQoS";
            this.lblSubQoS.Size = new System.Drawing.Size(40, 20);
            this.lblSubQoS.TabIndex = 17;
            this.lblSubQoS.Text = "QoS:";
            // 
            // comboboxSubQoS
            // 
            this.comboboxSubQoS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxSubQoS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboboxSubQoS.FormattingEnabled = true;
            this.comboboxSubQoS.Location = new System.Drawing.Point(6, 108);
            this.comboboxSubQoS.Name = "comboboxSubQoS";
            this.comboboxSubQoS.Size = new System.Drawing.Size(241, 28);
            this.comboboxSubQoS.TabIndex = 18;
            // 
            // txtboxSubscribeTopic
            // 
            this.txtboxSubscribeTopic.Location = new System.Drawing.Point(6, 46);
            this.txtboxSubscribeTopic.Name = "txtboxSubscribeTopic";
            this.txtboxSubscribeTopic.Size = new System.Drawing.Size(503, 27);
            this.txtboxSubscribeTopic.TabIndex = 13;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(515, 46);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(133, 94);
            this.btnSubscribe.TabIndex = 15;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // lblSubscribeTopic
            // 
            this.lblSubscribeTopic.AutoSize = true;
            this.lblSubscribeTopic.Location = new System.Drawing.Point(6, 27);
            this.lblSubscribeTopic.Name = "lblSubscribeTopic";
            this.lblSubscribeTopic.Size = new System.Drawing.Size(48, 20);
            this.lblSubscribeTopic.TabIndex = 11;
            this.lblSubscribeTopic.Text = "Topic:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gridviewMessages);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1311, 546);
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
            this.gridviewMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewMessages.Location = new System.Drawing.Point(3, 23);
            this.gridviewMessages.Name = "gridviewMessages";
            this.gridviewMessages.ReadOnly = true;
            this.gridviewMessages.RowHeadersWidth = 51;
            this.gridviewMessages.RowTemplate.Height = 29;
            this.gridviewMessages.Size = new System.Drawing.Size(1305, 520);
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
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1328, 588);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1320, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connect";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnClear);
            this.groupBox5.Controls.Add(this.txtboxLog);
            this.groupBox5.Location = new System.Drawing.Point(6, 308);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1302, 241);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Console Log";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1137, 26);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 29);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtboxLog
            // 
            this.txtboxLog.Location = new System.Drawing.Point(6, 26);
            this.txtboxLog.Multiline = true;
            this.txtboxLog.Name = "txtboxLog";
            this.txtboxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxLog.Size = new System.Drawing.Size(1092, 209);
            this.txtboxLog.TabIndex = 0;
            this.txtboxLog.TextChanged += new System.EventHandler(this.txtboxLog_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1320, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pub/Sub";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1320, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Messages";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 594);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtboxUsername;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtboxLog;
        private System.Windows.Forms.Label lblKeepAlive;
        private System.Windows.Forms.TextBox txtboxKeepAlive;
        private System.Windows.Forms.CheckBox checkboxCleanSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxLwtTopic;
        private System.Windows.Forms.Label lblLwtQoS;
        private System.Windows.Forms.ComboBox comboboxLwtQos;
        private System.Windows.Forms.CheckBox checkxoxLwtRetain;
        private System.Windows.Forms.Label lblLwtMessage;
        private System.Windows.Forms.TextBox txtboxLwtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbConnectionStatus;
        private System.Windows.Forms.Label lblSubSubscriptions;
        private System.Windows.Forms.ListView listviewSubSubscriptions;
        private System.Windows.Forms.Label lblSubQoS;
        private System.Windows.Forms.ComboBox comboboxSubQoS;
        private System.Windows.Forms.Label lblPubQoS;
        private System.Windows.Forms.ComboBox comboboxPubQoS;
        private System.Windows.Forms.CheckBox checkboxPubRetain;
        private System.Windows.Forms.Label label3;
    }
}
