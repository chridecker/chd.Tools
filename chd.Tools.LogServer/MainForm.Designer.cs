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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            dateTimeOffsetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            methodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apiKeyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            queryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bodyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            headersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSourceLogList = new BindingSource(components);
            httpCallDtoControl1 = new chd.Tools.LogServer.Controls.HttpCallDtoControl();
            tabPage3 = new TabPage();
            splitContainer2 = new SplitContainer();
            dataGridView2 = new DataGridView();
            bindingSourceSignalRLog = new BindingSource(components);
            signalrCallDtoControl1 = new chd.Tools.LogServer.Controls.SignalRCallDtoControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            textBox2 = new TextBox();
            bindingSourceAppsetting = new BindingSource(components);
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBoxUrl = new TextBox();
            labelPort = new Label();
            tabControl2 = new TabControl();
            pathDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dateTimeOffsetDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            hostDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            connectedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            apiKeyDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            forwardUrlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isWebSocketDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            methodDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            queryDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            headersDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceLogList).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceSignalRLog).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAppsetting).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1416, 802);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1408, 774);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Log";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(httpCallDtoControl1);
            splitContainer1.Size = new Size(1402, 768);
            splitContainer1.SplitterDistance = 467;
            splitContainer1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dateTimeOffsetDataGridViewTextBoxColumn, hostDataGridViewTextBoxColumn, methodDataGridViewTextBoxColumn, pathDataGridViewTextBoxColumn, apiKeyDataGridViewTextBoxColumn, queryDataGridViewTextBoxColumn, bodyDataGridViewTextBoxColumn, headersDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSourceLogList;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(467, 768);
            dataGridView1.TabIndex = 2;
            // 
            // dateTimeOffsetDataGridViewTextBoxColumn
            // 
            dateTimeOffsetDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dateTimeOffsetDataGridViewTextBoxColumn.DataPropertyName = "DateTimeOffset";
            dataGridViewCellStyle1.Format = "HH:mm:ss dd.MM.yyyy";
            dateTimeOffsetDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            dateTimeOffsetDataGridViewTextBoxColumn.HeaderText = "Time";
            dateTimeOffsetDataGridViewTextBoxColumn.Name = "dateTimeOffsetDataGridViewTextBoxColumn";
            dateTimeOffsetDataGridViewTextBoxColumn.ReadOnly = true;
            dateTimeOffsetDataGridViewTextBoxColumn.Width = 59;
            // 
            // hostDataGridViewTextBoxColumn
            // 
            hostDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hostDataGridViewTextBoxColumn.DataPropertyName = "Host";
            hostDataGridViewTextBoxColumn.HeaderText = "Host";
            hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            hostDataGridViewTextBoxColumn.ReadOnly = true;
            hostDataGridViewTextBoxColumn.Width = 57;
            // 
            // methodDataGridViewTextBoxColumn
            // 
            methodDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            methodDataGridViewTextBoxColumn.DataPropertyName = "Method";
            methodDataGridViewTextBoxColumn.HeaderText = "Method";
            methodDataGridViewTextBoxColumn.Name = "methodDataGridViewTextBoxColumn";
            methodDataGridViewTextBoxColumn.ReadOnly = true;
            methodDataGridViewTextBoxColumn.Width = 74;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            pathDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            pathDataGridViewTextBoxColumn.HeaderText = "Path";
            pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            pathDataGridViewTextBoxColumn.ReadOnly = true;
            pathDataGridViewTextBoxColumn.Width = 56;
            // 
            // apiKeyDataGridViewTextBoxColumn
            // 
            apiKeyDataGridViewTextBoxColumn.DataPropertyName = "ApiKey";
            apiKeyDataGridViewTextBoxColumn.HeaderText = "ApiKey";
            apiKeyDataGridViewTextBoxColumn.Name = "apiKeyDataGridViewTextBoxColumn";
            apiKeyDataGridViewTextBoxColumn.ReadOnly = true;
            apiKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // queryDataGridViewTextBoxColumn
            // 
            queryDataGridViewTextBoxColumn.DataPropertyName = "Query";
            queryDataGridViewTextBoxColumn.HeaderText = "Query";
            queryDataGridViewTextBoxColumn.Name = "queryDataGridViewTextBoxColumn";
            queryDataGridViewTextBoxColumn.ReadOnly = true;
            queryDataGridViewTextBoxColumn.Visible = false;
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            bodyDataGridViewTextBoxColumn.DataPropertyName = "Body";
            bodyDataGridViewTextBoxColumn.HeaderText = "Body";
            bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            bodyDataGridViewTextBoxColumn.ReadOnly = true;
            bodyDataGridViewTextBoxColumn.Visible = false;
            // 
            // headersDataGridViewTextBoxColumn
            // 
            headersDataGridViewTextBoxColumn.DataPropertyName = "Headers";
            headersDataGridViewTextBoxColumn.HeaderText = "Headers";
            headersDataGridViewTextBoxColumn.Name = "headersDataGridViewTextBoxColumn";
            headersDataGridViewTextBoxColumn.ReadOnly = true;
            headersDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceLogList
            // 
            bindingSourceLogList.DataSource = typeof(HttpCallDto);
            // 
            // httpCallDtoControl1
            // 
            httpCallDtoControl1.Dock = DockStyle.Fill;
            httpCallDtoControl1.Location = new Point(0, 0);
            httpCallDtoControl1.Name = "httpCallDtoControl1";
            httpCallDtoControl1.Size = new Size(931, 768);
            httpCallDtoControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitContainer2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1408, 774);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "SignalR";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dataGridView2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(signalrCallDtoControl1);
            splitContainer2.Size = new Size(1402, 768);
            splitContainer2.SplitterDistance = 467;
            splitContainer2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { pathDataGridViewTextBoxColumn1, dateTimeOffsetDataGridViewTextBoxColumn1, hostDataGridViewTextBoxColumn1, dataGridViewTextBoxColumn1, connectedDataGridViewCheckBoxColumn, apiKeyDataGridViewTextBoxColumn1, forwardUrlDataGridViewTextBoxColumn, isWebSocketDataGridViewCheckBoxColumn, methodDataGridViewTextBoxColumn1, queryDataGridViewTextBoxColumn1, headersDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = bindingSourceSignalRLog;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(467, 768);
            dataGridView2.TabIndex = 0;
            // 
            // bindingSourceSignalRLog
            // 
            bindingSourceSignalRLog.DataSource = typeof(SignalRConnectionDto);
            // 
            // signalrCallDtoControl1
            // 
            signalrCallDtoControl1.Dock = DockStyle.Fill;
            signalrCallDtoControl1.Location = new Point(0, 0);
            signalrCallDtoControl1.Name = "signalrCallDtoControl1";
            signalrCallDtoControl1.Size = new Size(931, 768);
            signalrCallDtoControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(textBoxUrl);
            tabPage1.Controls.Add(labelPort);
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1408, 774);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Server";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 11;
            label1.Text = "Forward Url";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSourceAppsetting, "ForwardUrl", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox2.Location = new Point(440, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(273, 23);
            textBox2.TabIndex = 10;
            // 
            // bindingSourceAppsetting
            // 
            bindingSourceAppsetting.DataSource = typeof(Settings.AppSettings);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(229, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceAppsetting, "Response", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.Location = new Point(8, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(387, 246);
            textBox1.TabIndex = 8;
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(36, 6);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.ReadOnly = true;
            textBoxUrl.Size = new Size(187, 23);
            textBoxUrl.TabIndex = 4;
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Location = new Point(8, 11);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(22, 15);
            labelPort.TabIndex = 2;
            labelPort.Text = "Url";
            // 
            // tabControl2
            // 
            tabControl2.Location = new Point(942, 569);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(8, 8);
            tabControl2.TabIndex = 0;
            // 
            // pathDataGridViewTextBoxColumn1
            // 
            pathDataGridViewTextBoxColumn1.DataPropertyName = "Path";
            pathDataGridViewTextBoxColumn1.HeaderText = "Path";
            pathDataGridViewTextBoxColumn1.Name = "pathDataGridViewTextBoxColumn1";
            pathDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateTimeOffsetDataGridViewTextBoxColumn1
            // 
            dateTimeOffsetDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dateTimeOffsetDataGridViewTextBoxColumn1.DataPropertyName = "DateTimeOffset";
            dateTimeOffsetDataGridViewTextBoxColumn1.HeaderText = "DateTimeOffset";
            dateTimeOffsetDataGridViewTextBoxColumn1.Name = "dateTimeOffsetDataGridViewTextBoxColumn1";
            dateTimeOffsetDataGridViewTextBoxColumn1.ReadOnly = true;
            dateTimeOffsetDataGridViewTextBoxColumn1.Width = 115;
            // 
            // hostDataGridViewTextBoxColumn1
            // 
            hostDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hostDataGridViewTextBoxColumn1.DataPropertyName = "Host";
            hostDataGridViewTextBoxColumn1.HeaderText = "Host";
            hostDataGridViewTextBoxColumn1.Name = "hostDataGridViewTextBoxColumn1";
            hostDataGridViewTextBoxColumn1.ReadOnly = true;
            hostDataGridViewTextBoxColumn1.Width = 57;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.DataPropertyName = "RemoteIpAddress";
            dataGridViewTextBoxColumn1.HeaderText = "RemoteIpAddress";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // connectedDataGridViewCheckBoxColumn
            // 
            connectedDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            connectedDataGridViewCheckBoxColumn.DataPropertyName = "Connected";
            connectedDataGridViewCheckBoxColumn.HeaderText = "Connected";
            connectedDataGridViewCheckBoxColumn.Name = "connectedDataGridViewCheckBoxColumn";
            connectedDataGridViewCheckBoxColumn.ReadOnly = true;
            connectedDataGridViewCheckBoxColumn.Width = 71;
            // 
            // apiKeyDataGridViewTextBoxColumn1
            // 
            apiKeyDataGridViewTextBoxColumn1.DataPropertyName = "ApiKey";
            apiKeyDataGridViewTextBoxColumn1.HeaderText = "ApiKey";
            apiKeyDataGridViewTextBoxColumn1.Name = "apiKeyDataGridViewTextBoxColumn1";
            apiKeyDataGridViewTextBoxColumn1.ReadOnly = true;
            apiKeyDataGridViewTextBoxColumn1.Visible = false;
            // 
            // forwardUrlDataGridViewTextBoxColumn
            // 
            forwardUrlDataGridViewTextBoxColumn.DataPropertyName = "ForwardUrl";
            forwardUrlDataGridViewTextBoxColumn.HeaderText = "ForwardUrl";
            forwardUrlDataGridViewTextBoxColumn.Name = "forwardUrlDataGridViewTextBoxColumn";
            forwardUrlDataGridViewTextBoxColumn.ReadOnly = true;
            forwardUrlDataGridViewTextBoxColumn.Visible = false;
            // 
            // isWebSocketDataGridViewCheckBoxColumn
            // 
            isWebSocketDataGridViewCheckBoxColumn.DataPropertyName = "IsWebSocket";
            isWebSocketDataGridViewCheckBoxColumn.HeaderText = "IsWebSocket";
            isWebSocketDataGridViewCheckBoxColumn.Name = "isWebSocketDataGridViewCheckBoxColumn";
            isWebSocketDataGridViewCheckBoxColumn.ReadOnly = true;
            isWebSocketDataGridViewCheckBoxColumn.Visible = false;
            // 
            // methodDataGridViewTextBoxColumn1
            // 
            methodDataGridViewTextBoxColumn1.DataPropertyName = "Method";
            methodDataGridViewTextBoxColumn1.HeaderText = "Method";
            methodDataGridViewTextBoxColumn1.Name = "methodDataGridViewTextBoxColumn1";
            methodDataGridViewTextBoxColumn1.ReadOnly = true;
            methodDataGridViewTextBoxColumn1.Visible = false;
            // 
            // queryDataGridViewTextBoxColumn1
            // 
            queryDataGridViewTextBoxColumn1.DataPropertyName = "Query";
            queryDataGridViewTextBoxColumn1.HeaderText = "Query";
            queryDataGridViewTextBoxColumn1.Name = "queryDataGridViewTextBoxColumn1";
            queryDataGridViewTextBoxColumn1.ReadOnly = true;
            queryDataGridViewTextBoxColumn1.Visible = false;
            // 
            // headersDataGridViewTextBoxColumn1
            // 
            headersDataGridViewTextBoxColumn1.DataPropertyName = "Headers";
            headersDataGridViewTextBoxColumn1.HeaderText = "Headers";
            headersDataGridViewTextBoxColumn1.Name = "headersDataGridViewTextBoxColumn1";
            headersDataGridViewTextBoxColumn1.ReadOnly = true;
            headersDataGridViewTextBoxColumn1.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 802);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "chd Log Server";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceLogList).EndInit();
            tabPage3.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceSignalRLog).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAppsetting).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label labelPort;
        private TabControl tabControl2;
        private TabPage tabPage2;
        private BindingSource bindingSourceAppsetting;
        private TextBox textBoxUrl;
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
    }
}
