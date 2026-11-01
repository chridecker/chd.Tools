using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Services;

namespace chd.Tools.LogServer
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            this.tabControl1 = new TabControl();
            this.tabPage2 = new TabPage();
            this.splitContainer1 = new SplitContainer();
            this.dataGridView1 = new DataGridView();
            this.dateTimeOffsetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.methodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.apiKeyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.queryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.bodyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.headersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.bindingSourceLogList = new BindingSource(this.components);
            this.httpCallDtoControl1 = new chd.Tools.LogServer.Controls.HttpCallDtoControl();
            this.tabPage3 = new TabPage();
            this.splitContainer2 = new SplitContainer();
            this.dataGridView2 = new DataGridView();
            this.pathDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dateTimeOffsetDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.connectedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            this.apiKeyDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.forwardUrlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.isWebSocketDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            this.methodDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.queryDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.headersDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.bindingSourceSignalRLog = new BindingSource(this.components);
            this.signalrCallDtoControl1 = new chd.Tools.LogServer.Controls.SignalRCallDtoControl();
            this.tabPage1 = new TabPage();
            this.groupBoxSettings = new GroupBox();
            this.buttonLogServer = new Button();
            this.textBoxLogPort = new TextBox();
            this.label3 = new Label();
            this.label2 = new Label();
            this.comboBoxIPs = new ComboBox();
            this.checkBoxUseSignalR = new CheckBox();
            this.bindingSourceAppsetting = new BindingSource(this.components);
            this.label1 = new Label();
            this.textBox2 = new TextBox();
            this.comboBox1 = new ComboBox();
            this.textBox1 = new TextBox();
            this.tabControl2 = new TabControl();
            this.groupBox1 = new GroupBox();
            this.labelPort = new Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.bindingSourceLogList).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.splitContainer2).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.bindingSourceSignalRLog).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.bindingSourceAppsetting).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = DockStyle.Fill;
            this.tabControl1.Location = new Point(0, 0);
            this.tabControl1.Margin = new Padding(5, 6, 5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(2427, 1604);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new Point(4, 39);
            this.tabPage2.Margin = new Padding(5, 6, 5, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new Padding(5, 6, 5, 6);
            this.tabPage2.Size = new Size(2419, 1561);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(5, 6);
            this.splitContainer1.Margin = new Padding(5, 6, 5, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.httpCallDtoControl1);
            this.splitContainer1.Size = new Size(2409, 1549);
            this.splitContainer1.SplitterDistance = 802;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.dateTimeOffsetDataGridViewTextBoxColumn, this.hostDataGridViewTextBoxColumn, this.methodDataGridViewTextBoxColumn, this.pathDataGridViewTextBoxColumn, this.apiKeyDataGridViewTextBoxColumn, this.queryDataGridViewTextBoxColumn, this.bodyDataGridViewTextBoxColumn, this.headersDataGridViewTextBoxColumn });
            this.dataGridView1.DataSource = this.bindingSourceLogList;
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new Point(0, 0);
            this.dataGridView1.Margin = new Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new Size(802, 1549);
            this.dataGridView1.TabIndex = 2;
            // 
            // dateTimeOffsetDataGridViewTextBoxColumn
            // 
            this.dateTimeOffsetDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dateTimeOffsetDataGridViewTextBoxColumn.DataPropertyName = "DateTimeOffset";
            dataGridViewCellStyle4.Format = "HH:mm:ss dd.MM.yyyy";
            this.dateTimeOffsetDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dateTimeOffsetDataGridViewTextBoxColumn.HeaderText = "Time";
            this.dateTimeOffsetDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.dateTimeOffsetDataGridViewTextBoxColumn.Name = "dateTimeOffsetDataGridViewTextBoxColumn";
            this.dateTimeOffsetDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeOffsetDataGridViewTextBoxColumn.Width = 99;
            // 
            // hostDataGridViewTextBoxColumn
            // 
            this.hostDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.hostDataGridViewTextBoxColumn.DataPropertyName = "Host";
            this.hostDataGridViewTextBoxColumn.HeaderText = "Host";
            this.hostDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            this.hostDataGridViewTextBoxColumn.ReadOnly = true;
            this.hostDataGridViewTextBoxColumn.Width = 97;
            // 
            // methodDataGridViewTextBoxColumn
            // 
            this.methodDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.methodDataGridViewTextBoxColumn.DataPropertyName = "Method";
            this.methodDataGridViewTextBoxColumn.HeaderText = "Method";
            this.methodDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.methodDataGridViewTextBoxColumn.Name = "methodDataGridViewTextBoxColumn";
            this.methodDataGridViewTextBoxColumn.ReadOnly = true;
            this.methodDataGridViewTextBoxColumn.Width = 127;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            this.pathDataGridViewTextBoxColumn.Width = 95;
            // 
            // apiKeyDataGridViewTextBoxColumn
            // 
            this.apiKeyDataGridViewTextBoxColumn.DataPropertyName = "ApiKey";
            this.apiKeyDataGridViewTextBoxColumn.HeaderText = "ApiKey";
            this.apiKeyDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.apiKeyDataGridViewTextBoxColumn.Name = "apiKeyDataGridViewTextBoxColumn";
            this.apiKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.apiKeyDataGridViewTextBoxColumn.Visible = false;
            this.apiKeyDataGridViewTextBoxColumn.Width = 175;
            // 
            // queryDataGridViewTextBoxColumn
            // 
            this.queryDataGridViewTextBoxColumn.DataPropertyName = "Query";
            this.queryDataGridViewTextBoxColumn.HeaderText = "Query";
            this.queryDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.queryDataGridViewTextBoxColumn.Name = "queryDataGridViewTextBoxColumn";
            this.queryDataGridViewTextBoxColumn.ReadOnly = true;
            this.queryDataGridViewTextBoxColumn.Visible = false;
            this.queryDataGridViewTextBoxColumn.Width = 175;
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            this.bodyDataGridViewTextBoxColumn.DataPropertyName = "Body";
            this.bodyDataGridViewTextBoxColumn.HeaderText = "Body";
            this.bodyDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            this.bodyDataGridViewTextBoxColumn.ReadOnly = true;
            this.bodyDataGridViewTextBoxColumn.Visible = false;
            this.bodyDataGridViewTextBoxColumn.Width = 175;
            // 
            // headersDataGridViewTextBoxColumn
            // 
            this.headersDataGridViewTextBoxColumn.DataPropertyName = "Headers";
            this.headersDataGridViewTextBoxColumn.HeaderText = "Headers";
            this.headersDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.headersDataGridViewTextBoxColumn.Name = "headersDataGridViewTextBoxColumn";
            this.headersDataGridViewTextBoxColumn.ReadOnly = true;
            this.headersDataGridViewTextBoxColumn.Visible = false;
            this.headersDataGridViewTextBoxColumn.Width = 175;
            // 
            // bindingSourceLogList
            // 
            this.bindingSourceLogList.DataSource = typeof(HttpCallDto);
            // 
            // httpCallDtoControl1
            // 
            this.httpCallDtoControl1.Dock = DockStyle.Fill;
            this.httpCallDtoControl1.Location = new Point(0, 0);
            this.httpCallDtoControl1.Margin = new Padding(5, 6, 5, 6);
            this.httpCallDtoControl1.Name = "httpCallDtoControl1";
            this.httpCallDtoControl1.Size = new Size(1600, 1549);
            this.httpCallDtoControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer2);
            this.tabPage3.Location = new Point(4, 39);
            this.tabPage3.Margin = new Padding(5, 6, 5, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new Padding(5, 6, 5, 6);
            this.tabPage3.Size = new Size(2419, 1561);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SignalR";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = DockStyle.Fill;
            this.splitContainer2.Location = new Point(5, 6);
            this.splitContainer2.Margin = new Padding(5, 6, 5, 6);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.signalrCallDtoControl1);
            this.splitContainer2.Size = new Size(2409, 1549);
            this.splitContainer2.SplitterDistance = 802;
            this.splitContainer2.SplitterWidth = 7;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new DataGridViewColumn[] { this.pathDataGridViewTextBoxColumn1, this.dateTimeOffsetDataGridViewTextBoxColumn1, this.hostDataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn1, this.connectedDataGridViewCheckBoxColumn, this.apiKeyDataGridViewTextBoxColumn1, this.forwardUrlDataGridViewTextBoxColumn, this.isWebSocketDataGridViewCheckBoxColumn, this.methodDataGridViewTextBoxColumn1, this.queryDataGridViewTextBoxColumn1, this.headersDataGridViewTextBoxColumn1 });
            this.dataGridView2.DataSource = this.bindingSourceSignalRLog;
            this.dataGridView2.Dock = DockStyle.Fill;
            this.dataGridView2.Location = new Point(0, 0);
            this.dataGridView2.Margin = new Padding(5, 6, 5, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 72;
            this.dataGridView2.Size = new Size(802, 1549);
            this.dataGridView2.TabIndex = 0;
            // 
            // pathDataGridViewTextBoxColumn1
            // 
            this.pathDataGridViewTextBoxColumn1.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn1.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.pathDataGridViewTextBoxColumn1.Name = "pathDataGridViewTextBoxColumn1";
            this.pathDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pathDataGridViewTextBoxColumn1.Width = 175;
            // 
            // dateTimeOffsetDataGridViewTextBoxColumn1
            // 
            this.dateTimeOffsetDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dateTimeOffsetDataGridViewTextBoxColumn1.DataPropertyName = "DateTimeOffset";
            this.dateTimeOffsetDataGridViewTextBoxColumn1.HeaderText = "DateTimeOffset";
            this.dateTimeOffsetDataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dateTimeOffsetDataGridViewTextBoxColumn1.Name = "dateTimeOffsetDataGridViewTextBoxColumn1";
            this.dateTimeOffsetDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dateTimeOffsetDataGridViewTextBoxColumn1.Width = 200;
            // 
            // hostDataGridViewTextBoxColumn1
            // 
            this.hostDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.hostDataGridViewTextBoxColumn1.DataPropertyName = "Host";
            this.hostDataGridViewTextBoxColumn1.HeaderText = "Host";
            this.hostDataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.hostDataGridViewTextBoxColumn1.Name = "hostDataGridViewTextBoxColumn1";
            this.hostDataGridViewTextBoxColumn1.ReadOnly = true;
            this.hostDataGridViewTextBoxColumn1.Width = 97;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RemoteIpAddress";
            this.dataGridViewTextBoxColumn1.HeaderText = "RemoteIpAddress";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 217;
            // 
            // connectedDataGridViewCheckBoxColumn
            // 
            this.connectedDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.connectedDataGridViewCheckBoxColumn.DataPropertyName = "Connected";
            this.connectedDataGridViewCheckBoxColumn.HeaderText = "Connected";
            this.connectedDataGridViewCheckBoxColumn.MinimumWidth = 9;
            this.connectedDataGridViewCheckBoxColumn.Name = "connectedDataGridViewCheckBoxColumn";
            this.connectedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.connectedDataGridViewCheckBoxColumn.Width = 119;
            // 
            // apiKeyDataGridViewTextBoxColumn1
            // 
            this.apiKeyDataGridViewTextBoxColumn1.DataPropertyName = "ApiKey";
            this.apiKeyDataGridViewTextBoxColumn1.HeaderText = "ApiKey";
            this.apiKeyDataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.apiKeyDataGridViewTextBoxColumn1.Name = "apiKeyDataGridViewTextBoxColumn1";
            this.apiKeyDataGridViewTextBoxColumn1.ReadOnly = true;
            this.apiKeyDataGridViewTextBoxColumn1.Visible = false;
            this.apiKeyDataGridViewTextBoxColumn1.Width = 175;
            // 
            // forwardUrlDataGridViewTextBoxColumn
            // 
            this.forwardUrlDataGridViewTextBoxColumn.DataPropertyName = "ForwardUrl";
            this.forwardUrlDataGridViewTextBoxColumn.HeaderText = "ForwardUrl";
            this.forwardUrlDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.forwardUrlDataGridViewTextBoxColumn.Name = "forwardUrlDataGridViewTextBoxColumn";
            this.forwardUrlDataGridViewTextBoxColumn.ReadOnly = true;
            this.forwardUrlDataGridViewTextBoxColumn.Visible = false;
            this.forwardUrlDataGridViewTextBoxColumn.Width = 175;
            // 
            // isWebSocketDataGridViewCheckBoxColumn
            // 
            this.isWebSocketDataGridViewCheckBoxColumn.DataPropertyName = "IsWebSocket";
            this.isWebSocketDataGridViewCheckBoxColumn.HeaderText = "IsWebSocket";
            this.isWebSocketDataGridViewCheckBoxColumn.MinimumWidth = 9;
            this.isWebSocketDataGridViewCheckBoxColumn.Name = "isWebSocketDataGridViewCheckBoxColumn";
            this.isWebSocketDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isWebSocketDataGridViewCheckBoxColumn.Visible = false;
            this.isWebSocketDataGridViewCheckBoxColumn.Width = 175;
            // 
            // methodDataGridViewTextBoxColumn1
            // 
            this.methodDataGridViewTextBoxColumn1.DataPropertyName = "Method";
            this.methodDataGridViewTextBoxColumn1.HeaderText = "Method";
            this.methodDataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.methodDataGridViewTextBoxColumn1.Name = "methodDataGridViewTextBoxColumn1";
            this.methodDataGridViewTextBoxColumn1.ReadOnly = true;
            this.methodDataGridViewTextBoxColumn1.Visible = false;
            this.methodDataGridViewTextBoxColumn1.Width = 175;
            // 
            // queryDataGridViewTextBoxColumn1
            // 
            this.queryDataGridViewTextBoxColumn1.DataPropertyName = "Query";
            this.queryDataGridViewTextBoxColumn1.HeaderText = "Query";
            this.queryDataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.queryDataGridViewTextBoxColumn1.Name = "queryDataGridViewTextBoxColumn1";
            this.queryDataGridViewTextBoxColumn1.ReadOnly = true;
            this.queryDataGridViewTextBoxColumn1.Visible = false;
            this.queryDataGridViewTextBoxColumn1.Width = 175;
            // 
            // headersDataGridViewTextBoxColumn1
            // 
            this.headersDataGridViewTextBoxColumn1.DataPropertyName = "Headers";
            this.headersDataGridViewTextBoxColumn1.HeaderText = "Headers";
            this.headersDataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.headersDataGridViewTextBoxColumn1.Name = "headersDataGridViewTextBoxColumn1";
            this.headersDataGridViewTextBoxColumn1.ReadOnly = true;
            this.headersDataGridViewTextBoxColumn1.Visible = false;
            this.headersDataGridViewTextBoxColumn1.Width = 175;
            // 
            // bindingSourceSignalRLog
            // 
            this.bindingSourceSignalRLog.DataSource = typeof(SignalRConnectionDto);
            // 
            // signalrCallDtoControl1
            // 
            this.signalrCallDtoControl1.Dock = DockStyle.Fill;
            this.signalrCallDtoControl1.Location = new Point(0, 0);
            this.signalrCallDtoControl1.Margin = new Padding(9, 12, 9, 12);
            this.signalrCallDtoControl1.Name = "signalrCallDtoControl1";
            this.signalrCallDtoControl1.Size = new Size(1600, 1549);
            this.signalrCallDtoControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBoxSettings);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new Point(4, 39);
            this.tabPage1.Margin = new Padding(5, 6, 5, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new Padding(5, 6, 5, 6);
            this.tabPage1.Size = new Size(2419, 1561);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.buttonLogServer);
            this.groupBoxSettings.Controls.Add(this.textBoxLogPort);
            this.groupBoxSettings.Controls.Add(this.checkBoxUseSignalR);
            this.groupBoxSettings.Controls.Add(this.label3);
            this.groupBoxSettings.Controls.Add(this.label1);
            this.groupBoxSettings.Controls.Add(this.label2);
            this.groupBoxSettings.Controls.Add(this.textBox2);
            this.groupBoxSettings.Controls.Add(this.comboBoxIPs);
            this.groupBoxSettings.Location = new Point(8, 15);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new Size(583, 212);
            this.groupBoxSettings.TabIndex = 13;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // buttonLogServer
            // 
            this.buttonLogServer.Location = new Point(477, 47);
            this.buttonLogServer.Name = "buttonLogServer";
            this.buttonLogServer.Size = new Size(90, 40);
            this.buttonLogServer.TabIndex = 4;
            this.buttonLogServer.Text = "Start";
            this.buttonLogServer.UseVisualStyleBackColor = true;
            this.buttonLogServer.Click += this.buttonLogServer_Click;
            // 
            // textBoxLogPort
            // 
            this.textBoxLogPort.Location = new Point(393, 47);
            this.textBoxLogPort.Name = "textBoxLogPort";
            this.textBoxLogPort.Size = new Size(78, 35);
            this.textBoxLogPort.TabIndex = 3;
            this.textBoxLogPort.Text = "5601";
            this.textBoxLogPort.TextChanged += this.textBoxLogPort_TextChanged;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(337, 47);
            this.label3.Name = "label3";
            this.label3.Size = new Size(50, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new Size(31, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // comboBoxIPs
            // 
            this.comboBoxIPs.FormattingEnabled = true;
            this.comboBoxIPs.Location = new Point(43, 44);
            this.comboBoxIPs.Name = "comboBoxIPs";
            this.comboBoxIPs.Size = new Size(279, 38);
            this.comboBoxIPs.TabIndex = 0;
            // 
            // checkBoxUseSignalR
            // 
            this.checkBoxUseSignalR.AutoSize = true;
            this.checkBoxUseSignalR.DataBindings.Add(new Binding("Checked", this.bindingSourceAppsetting, "UseSignalR", true, DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxUseSignalR.Location = new Point(6, 161);
            this.checkBoxUseSignalR.Margin = new Padding(5, 6, 5, 6);
            this.checkBoxUseSignalR.Name = "checkBoxUseSignalR";
            this.checkBoxUseSignalR.Size = new Size(148, 34);
            this.checkBoxUseSignalR.TabIndex = 12;
            this.checkBoxUseSignalR.Text = "Use SignalR";
            this.checkBoxUseSignalR.UseVisualStyleBackColor = true;
            // 
            // bindingSourceAppsetting
            // 
            this.bindingSourceAppsetting.DataSource = typeof(Settings.AppSettings);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(5, 120);
            this.label1.Margin = new Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(119, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Forward Url";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new Binding("Text", this.bindingSourceAppsetting, "ForwardUrl", true));
            this.textBox2.Location = new Point(132, 114);
            this.textBox2.Margin = new Padding(5, 6, 5, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(435, 35);
            this.textBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(157, 43);
            this.comboBox1.Margin = new Padding(5, 6, 5, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(357, 38);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new Binding("Text", this.bindingSourceAppsetting, "Response", true, DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new Point(8, 93);
            this.textBox1.Margin = new Padding(5, 6, 5, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = ScrollBars.Vertical;
            this.textBox1.Size = new Size(868, 751);
            this.textBox1.TabIndex = 8;
            // 
            // tabControl2
            // 
            this.tabControl2.Location = new Point(1615, 1138);
            this.tabControl2.Margin = new Padding(5, 6, 5, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new Size(14, 16);
            this.tabControl2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPort);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new Point(14, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(884, 852);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Response";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new Point(30, 43);
            this.labelPort.Margin = new Padding(5, 0, 5, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new Size(117, 30);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "StatusCode";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(12F, 30F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(2427, 1604);
            this.Controls.Add(this.tabControl1);
            this.Margin = new Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "chd Log Server";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.bindingSourceLogList).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.splitContainer2).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.bindingSourceSignalRLog).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.bindingSourceAppsetting).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabControl tabControl2;
        private TabPage tabPage2;
        private BindingSource bindingSourceAppsetting;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private BindingSource bindingSourceLogList;
        private Controls.HttpCallDtoControl httpCallDtoControl1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dateTimeOffsetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remoteIpAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn methodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apiKeyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn queryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn headersDataGridViewTextBoxColumn;
        private SplitContainer splitContainer1;
        private TextBox textBox2;
        private Label label1;
        private TabPage tabPage3;
        private SplitContainer splitContainer2;
        private BindingSource bindingSourceSignalRLog;
        private DataGridView dataGridView2;
        private Controls.SignalRCallDtoControl signalrCallDtoControl1;
        private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateTimeOffsetDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn connectedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn apiKeyDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn forwardUrlDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isWebSocketDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn methodDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn queryDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn headersDataGridViewTextBoxColumn1;
        private CheckBox checkBoxUseSignalR;
        private GroupBox groupBoxSettings;
        private TextBox textBoxLogPort;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxIPs;
        private Button buttonLogServer;
        private GroupBox groupBox1;
        private Label labelPort;
    }
}
