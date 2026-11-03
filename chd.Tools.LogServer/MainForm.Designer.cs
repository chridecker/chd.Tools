using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;

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
            tabControl1 = new TabControl();
            tabPageServer = new TabPage();
            chooseIpComboBox1 = new chd.Base.Hosting.Forms.Controls.ChooseIpComboBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label3 = new Label();
            labelPort = new Label();
            textBox1 = new TextBox();
            bindingSourceHttpLogSetting = new BindingSource(components);
            comboBox1 = new ComboBox();
            label1 = new Label();
            checkBoxUseSignalR = new CheckBox();
            textBox2 = new TextBox();
            tabControl2 = new TabControl();
            webModuleHttpLog = new chd.Base.Hosting.Forms.Controls.WebModuleControl();
            tabPageHttpLog = new TabPage();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            bindingSourceLogList = new BindingSource(components);
            httpCallDtoControl1 = new chd.Tools.LogServer.Controls.HttpCallDtoControl();
            tabPageSignalR = new TabPage();
            splitContainer2 = new SplitContainer();
            dataGridView2 = new DataGridView();
            bindingSourceSignalRLog = new BindingSource(components);
            signalrCallDtoControl1 = new chd.Tools.LogServer.Controls.SignalRCallDtoControl();
            tabPageLog = new TabPage();
            channelLogControl1 = new chd.Base.Hosting.Forms.Controls.ChannelLogControl();
            tabControl1.SuspendLayout();
            tabPageServer.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceHttpLogSetting).BeginInit();
            tabPageHttpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceLogList).BeginInit();
            tabPageSignalR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceSignalRLog).BeginInit();
            tabPageLog.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageServer);
            tabControl1.Controls.Add(tabPageHttpLog);
            tabControl1.Controls.Add(tabPageSignalR);
            tabControl1.Controls.Add(tabPageLog);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1249, 821);
            tabControl1.TabIndex = 0;
            // 
            // tabPageServer
            // 
            tabPageServer.Controls.Add(chooseIpComboBox1);
            tabPageServer.Controls.Add(label2);
            tabPageServer.Controls.Add(groupBox1);
            tabPageServer.Controls.Add(label1);
            tabPageServer.Controls.Add(checkBoxUseSignalR);
            tabPageServer.Controls.Add(textBox2);
            tabPageServer.Controls.Add(tabControl2);
            tabPageServer.Controls.Add(webModuleHttpLog);
            tabPageServer.Location = new Point(4, 24);
            tabPageServer.Name = "tabPageServer";
            tabPageServer.Padding = new Padding(3);
            tabPageServer.Size = new Size(1241, 793);
            tabPageServer.TabIndex = 1;
            tabPageServer.Text = "Server";
            tabPageServer.UseVisualStyleBackColor = true;
            // 
            // chooseIpComboBox1
            // 
            chooseIpComboBox1.FormattingEnabled = true;
            chooseIpComboBox1.Location = new Point(26, 6);
            chooseIpComboBox1.Name = "chooseIpComboBox1";
            chooseIpComboBox1.Size = new Size(159, 23);
            chooseIpComboBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "IP";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelPort);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(18, 109);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(522, 432);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Response";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSourceHttpLogSetting, "ResponseContentType", true));
            textBox3.Location = new Point(342, 17);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 22);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 10;
            label3.Text = "Content Type";
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Location = new Point(6, 22);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(70, 15);
            labelPort.TabIndex = 2;
            labelPort.Text = "Status Code";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceHttpLogSetting, "Response", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.Location = new Point(5, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(508, 378);
            textBox1.TabIndex = 8;
            // 
            // bindingSourceHttpLogSetting
            // 
            bindingSourceHttpLogSetting.DataSource = typeof(HttpLogSettings);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(76, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 23);
            comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 84);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 11;
            label1.Text = "Forward Url";
            // 
            // checkBoxUseSignalR
            // 
            checkBoxUseSignalR.AutoSize = true;
            checkBoxUseSignalR.DataBindings.Add(new Binding("Checked", bindingSourceHttpLogSetting, "UseSignalR", true, DataSourceUpdateMode.OnPropertyChanged));
            checkBoxUseSignalR.Location = new Point(257, 84);
            checkBoxUseSignalR.Name = "checkBoxUseSignalR";
            checkBoxUseSignalR.Size = new Size(87, 19);
            checkBoxUseSignalR.TabIndex = 12;
            checkBoxUseSignalR.Text = "Use SignalR";
            checkBoxUseSignalR.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSourceHttpLogSetting, "ForwardUrl", true, DataSourceUpdateMode.Never));
            textBox2.Location = new Point(92, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // tabControl2
            // 
            tabControl2.Location = new Point(942, 569);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(8, 8);
            tabControl2.TabIndex = 0;
            // 
            // webModuleHttpLog
            // 
            webModuleHttpLog.Location = new Point(6, 35);
            webModuleHttpLog.ModuleDefaultPort = 5601;
            webModuleHttpLog.ModuleName = "HttpLogModule";
            webModuleHttpLog.Name = "webModuleHttpLog";
            webModuleHttpLog.Size = new Size(545, 519);
            webModuleHttpLog.TabIndex = 14;
            // 
            // tabPageHttpLog
            // 
            tabPageHttpLog.Controls.Add(splitContainer1);
            tabPageHttpLog.Location = new Point(4, 24);
            tabPageHttpLog.Name = "tabPageHttpLog";
            tabPageHttpLog.Padding = new Padding(3);
            tabPageHttpLog.Size = new Size(1241, 793);
            tabPageHttpLog.TabIndex = 0;
            tabPageHttpLog.Text = "Http Interception";
            tabPageHttpLog.UseVisualStyleBackColor = true;
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
            splitContainer1.Size = new Size(1235, 787);
            splitContainer1.SplitterDistance = 410;
            splitContainer1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn8 });
            dataGridView1.DataSource = bindingSourceLogList;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(410, 787);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "DateTimeOffset";
            dataGridViewTextBoxColumn7.HeaderText = "Time";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "RemoteIpAddress";
            dataGridViewTextBoxColumn11.HeaderText = "IP";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Host";
            dataGridViewTextBoxColumn3.HeaderText = "Host";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "ApiKey";
            dataGridViewTextBoxColumn4.HeaderText = "ApiKey";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Method";
            dataGridViewTextBoxColumn6.HeaderText = "Method";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Path";
            dataGridViewTextBoxColumn8.HeaderText = "Path";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
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
            httpCallDtoControl1.Size = new Size(821, 787);
            httpCallDtoControl1.TabIndex = 16;
            // 
            // tabPageSignalR
            // 
            tabPageSignalR.Controls.Add(splitContainer2);
            tabPageSignalR.Location = new Point(4, 24);
            tabPageSignalR.Name = "tabPageSignalR";
            tabPageSignalR.Padding = new Padding(3);
            tabPageSignalR.Size = new Size(1241, 793);
            tabPageSignalR.TabIndex = 2;
            tabPageSignalR.Text = "SignalR";
            tabPageSignalR.UseVisualStyleBackColor = true;
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
            splitContainer2.Size = new Size(1235, 787);
            splitContainer2.SplitterDistance = 410;
            splitContainer2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.DataSource = bindingSourceSignalRLog;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.Size = new Size(410, 787);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // signalrCallDtoControl1
            // 
            signalrCallDtoControl1.Dock = DockStyle.Fill;
            signalrCallDtoControl1.Location = new Point(0, 0);
            signalrCallDtoControl1.Name = "signalrCallDtoControl1";
            signalrCallDtoControl1.Size = new Size(821, 787);
            signalrCallDtoControl1.TabIndex = 0;
            // 
            // tabPageLog
            // 
            tabPageLog.Controls.Add(channelLogControl1);
            tabPageLog.Location = new Point(4, 24);
            tabPageLog.Name = "tabPageLog";
            tabPageLog.Padding = new Padding(3);
            tabPageLog.Size = new Size(1241, 793);
            tabPageLog.TabIndex = 3;
            tabPageLog.Text = "Log";
            tabPageLog.UseVisualStyleBackColor = true;
            // 
            // channelLogControl1
            // 
            channelLogControl1.Dock = DockStyle.Fill;
            channelLogControl1.Location = new Point(3, 3);
            channelLogControl1.Name = "channelLogControl1";
            channelLogControl1.Size = new Size(1235, 787);
            channelLogControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 821);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "chd Log Server";
            tabControl1.ResumeLayout(false);
            tabPageServer.ResumeLayout(false);
            tabPageServer.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceHttpLogSetting).EndInit();
            tabPageHttpLog.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceLogList).EndInit();
            tabPageSignalR.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceSignalRLog).EndInit();
            tabPageLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageServer;
        private TabControl tabControl2;
        private TabPage tabPageHttpLog;
        private BindingSource bindingSourceHttpLogSetting;
        private ComboBox comboBox1;
        private TextBox textBox1;
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
        private TabPage tabPageSignalR;
        private SplitContainer splitContainer2;
        private BindingSource bindingSourceSignalRLog;
        private DataGridView dataGridView2;
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
        private Label label2;
        private GroupBox groupBox1;
        private Label labelPort;
        private TabPage tabPageLog;
        private Base.Hosting.Forms.Controls.ChannelLogControl channelLogControl1;
        private Base.Hosting.Forms.Controls.WebModuleControl webModuleHttpLog;
        private Base.Hosting.Forms.Controls.ChooseIpComboBox chooseIpComboBox1;
        private Controls.HttpCallDtoControl httpCallDtoControl1;
        private Controls.SignalRCallDtoControl signalrCallDtoControl1;
        private BindingSource bindingSourceLogList;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private TextBox textBox3;
        private Label label3;
    }
}
