using System.ComponentModel;

namespace chd.Tools.LogServer.Controls
{
    partial class HttpCallDtoControl
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

        private void InitializeComponent()
        {
            this.components = new Container();
            this.bindingSourceDto = new BindingSource(this.components);
            this.tableLayoutPanel = new TableLayoutPanel();
            this.lblTime = new Label();
            this.lblMethod = new Label();
            this.txtMethod = new TextBox();
            this.lblPath = new Label();
            this.txtPath = new TextBox();
            this.lblApiKey = new Label();
            this.txtApiKey = new TextBox();
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.txtForwardUrl = new TextBox();
            this.txtRemoteIp = new TextBox();
            this.lblResponseStatusCode = new Label();
            this.lblForwardUrl = new Label();
            this.txtResponseStatusCode = new TextBox();
            this.txtTime = new TextBox();
            this.txtHost = new TextBox();
            this.lblHost = new Label();
            this.txtQuery = new TextBox();
            this.cbIsWebSocket = new CheckBox();
            this.grpBody = new GroupBox();
            this.txtBody = new TextBox();
            this.grpResponseBody = new GroupBox();
            this.txtResponseBody = new TextBox();
            this.grpHeaders = new GroupBox();
            this.dgvHeaders = new DataGridView();
            ((ISupportInitialize)this.bindingSourceDto).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.grpBody.SuspendLayout();
            this.grpResponseBody.SuspendLayout();
            this.grpHeaders.SuspendLayout();
            ((ISupportInitialize)this.dgvHeaders).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceDto
            // 
            this.bindingSourceDto.DataSource = typeof(Model.HttpCallDto);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.lblTime, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblMethod, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.txtMethod, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblPath, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.txtPath, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.lblApiKey, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.txtApiKey, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.lblUsername, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.txtUsername, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.lblPassword, 0, 9);
            this.tableLayoutPanel.Controls.Add(this.txtPassword, 1, 9);
            this.tableLayoutPanel.Controls.Add(this.txtForwardUrl, 1, 10);
            this.tableLayoutPanel.Controls.Add(this.txtRemoteIp, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblResponseStatusCode, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.lblForwardUrl, 0, 10);
            this.tableLayoutPanel.Controls.Add(this.txtResponseStatusCode, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.txtTime, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.txtHost, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.lblHost, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtQuery, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.cbIsWebSocket, 2, 10);
            this.tableLayoutPanel.Dock = DockStyle.Top;
            this.tableLayoutPanel.Location = new Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new Padding(5);
            this.tableLayoutPanel.RowCount = 11;
            this.tableLayoutPanel.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel.Size = new Size(900, 381);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.Location = new Point(8, 5);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new Size(100, 38);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Zeit";
            // 
            // lblMethod
            // 
            this.lblMethod.Location = new Point(8, 87);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new Size(100, 38);
            this.lblMethod.TabIndex = 2;
            this.lblMethod.Text = "Method";
            // 
            // txtMethod
            // 
            this.txtMethod.DataBindings.Add(new Binding("Text", this.bindingSourceDto, "Method", true));
            this.txtMethod.Location = new Point(168, 90);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new Size(100, 35);
            this.txtMethod.TabIndex = 3;
            // 
            // lblPath
            // 
            this.lblPath.Location = new Point(8, 128);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new Size(134, 38);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Path / Query";
            // 
            // txtPath
            // 
            this.txtPath.DataBindings.Add(new Binding("Text", this.bindingSourceDto, "Path", true));
            this.txtPath.Location = new Point(168, 131);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new Size(100, 35);
            this.txtPath.TabIndex = 5;
            // 
            // lblApiKey
            // 
            this.lblApiKey.Location = new Point(8, 210);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new Size(100, 38);
            this.lblApiKey.TabIndex = 8;
            this.lblApiKey.Text = "Api Key";
            // 
            // txtApiKey
            // 
            this.txtApiKey.DataBindings.Add(new Binding("Text", this.bindingSourceDto, "ApiKey", true));
            this.txtApiKey.Location = new Point(168, 213);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new Size(100, 35);
            this.txtApiKey.TabIndex = 9;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new Point(8, 251);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new Size(100, 41);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Basic Username";
            // 
            // txtUsername
            // 
            this.txtUsername.DataBindings.Add(new Binding("Text", this.bindingSourceDto, "Username", true));
            this.txtUsername.Location = new Point(168, 254);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(100, 35);
            this.txtUsername.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new Point(8, 292);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(143, 41);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Basic Password";
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new Binding("Text", this.bindingSourceDto, "Password", true));
            this.txtPassword.Location = new Point(168, 295);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(100, 35);
            this.txtPassword.TabIndex = 9;
            // 
            // txtForwardUrl
            // 
            this.txtForwardUrl.DataBindings.Add(new Binding("Text", this.bindingSourceDto, "ForwardUrl", true));
            this.txtForwardUrl.Location = new Point(168, 336);
            this.txtForwardUrl.Name = "txtForwardUrl";
            this.txtForwardUrl.Size = new Size(100, 35);
            this.txtForwardUrl.TabIndex = 11;
            // 
            // txtRemoteIp
            // 
            this.txtRemoteIp.DataBindings.Add(new Binding("Text", this.bindingSourceDto, "RemoteIpAddress", true));
            this.txtRemoteIp.Location = new Point(168, 49);
            this.txtRemoteIp.Name = "txtRemoteIp";
            this.txtRemoteIp.Size = new Size(100, 35);
            this.txtRemoteIp.TabIndex = 13;
            // 
            // lblResponseStatusCode
            // 
            this.lblResponseStatusCode.Location = new Point(8, 169);
            this.lblResponseStatusCode.Name = "lblResponseStatusCode";
            this.lblResponseStatusCode.Size = new Size(154, 38);
            this.lblResponseStatusCode.TabIndex = 12;
            this.lblResponseStatusCode.Text = "Response HttpStatus";
            // 
            // lblForwardUrl
            // 
            this.lblForwardUrl.Location = new Point(8, 333);
            this.lblForwardUrl.Name = "lblForwardUrl";
            this.lblForwardUrl.Size = new Size(143, 38);
            this.lblForwardUrl.TabIndex = 12;
            this.lblForwardUrl.Text = "Forward Url";
            // 
            // txtResponseStatusCode
            // 
            this.txtResponseStatusCode.DataBindings.Add(new Binding("Text", this.bindingSourceDto, "ResponseStatusCodeText", true));
            this.txtResponseStatusCode.Location = new Point(168, 172);
            this.txtResponseStatusCode.Name = "txtResponseStatusCode";
            this.txtResponseStatusCode.Size = new Size(100, 35);
            this.txtResponseStatusCode.TabIndex = 5;
            // 
            // txtTime
            // 
            this.txtTime.DataBindings.Add(new Binding("Text", this.bindingSourceDto, "DateTimeOffset", true, DataSourceUpdateMode.Never, "HH:mm:ss,fff dd.MM.yyyy", "HH:mm:ss,fff dd.MM.yyyy"));
            this.txtTime.Location = new Point(168, 8);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new Size(100, 35);
            this.txtTime.TabIndex = 1;
            // 
            // txtHost
            // 
            this.txtHost.DataBindings.Add(new Binding("Text", this.bindingSourceDto, "Host", true));
            this.txtHost.Location = new Point(533, 49);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new Size(100, 35);
            this.txtHost.TabIndex = 11;
            // 
            // lblHost
            // 
            this.lblHost.Location = new Point(8, 46);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new Size(100, 38);
            this.lblHost.TabIndex = 10;
            this.lblHost.Text = "IP / Host";
            // 
            // txtQuery
            // 
            this.txtQuery.DataBindings.Add(new Binding("Text", this.bindingSourceDto, "Query", true));
            this.txtQuery.Location = new Point(533, 131);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new Size(100, 35);
            this.txtQuery.TabIndex = 7;
            // 
            // cbIsWebSocket
            // 
            this.cbIsWebSocket.DataBindings.Add(new Binding("Checked", this.bindingSourceDto, "IsWebSocket", true));
            this.cbIsWebSocket.Enabled = false;
            this.cbIsWebSocket.Location = new Point(533, 336);
            this.cbIsWebSocket.Name = "cbIsWebSocket";
            this.cbIsWebSocket.Size = new Size(200, 37);
            this.cbIsWebSocket.TabIndex = 11;
            this.cbIsWebSocket.Text = "Websocket";
            // 
            // grpBody
            // 
            this.grpBody.Controls.Add(this.txtBody);
            this.grpBody.Dock = DockStyle.Top;
            this.grpBody.Location = new Point(0, 561);
            this.grpBody.Name = "grpBody";
            this.grpBody.Size = new Size(900, 180);
            this.grpBody.TabIndex = 1;
            this.grpBody.TabStop = false;
            this.grpBody.Text = "Response Body";
            // 
            // txtBody
            // 
            this.txtBody.DataBindings.Add(new Binding("Text", this.bindingSourceDto, "ResponseBody", true));
            this.txtBody.Dock = DockStyle.Fill;
            this.txtBody.Font = new Font("Consolas", 9F);
            this.txtBody.Location = new Point(3, 31);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ReadOnly = true;
            this.txtBody.ScrollBars = ScrollBars.Both;
            this.txtBody.Size = new Size(894, 146);
            this.txtBody.TabIndex = 0;
            // 
            // grpResponseBody
            // 
            this.grpResponseBody.Controls.Add(this.txtResponseBody);
            this.grpResponseBody.Dock = DockStyle.Top;
            this.grpResponseBody.Location = new Point(0, 381);
            this.grpResponseBody.Name = "grpResponseBody";
            this.grpResponseBody.Size = new Size(900, 180);
            this.grpResponseBody.TabIndex = 1;
            this.grpResponseBody.TabStop = false;
            this.grpResponseBody.Text = "Body";
            // 
            // txtResponseBody
            // 
            this.txtResponseBody.DataBindings.Add(new Binding("Text", this.bindingSourceDto, "Body", true));
            this.txtResponseBody.Dock = DockStyle.Fill;
            this.txtResponseBody.Font = new Font("Consolas", 9F);
            this.txtResponseBody.Location = new Point(3, 31);
            this.txtResponseBody.Multiline = true;
            this.txtResponseBody.Name = "txtResponseBody";
            this.txtResponseBody.ReadOnly = true;
            this.txtResponseBody.ScrollBars = ScrollBars.Both;
            this.txtResponseBody.Size = new Size(894, 146);
            this.txtResponseBody.TabIndex = 0;
            // 
            // grpHeaders
            // 
            this.grpHeaders.Controls.Add(this.dgvHeaders);
            this.grpHeaders.Dock = DockStyle.Fill;
            this.grpHeaders.Location = new Point(0, 741);
            this.grpHeaders.Name = "grpHeaders";
            this.grpHeaders.Size = new Size(900, 0);
            this.grpHeaders.TabIndex = 0;
            this.grpHeaders.TabStop = false;
            this.grpHeaders.Text = "Headers";
            // 
            // dgvHeaders
            // 
            this.dgvHeaders.AllowUserToAddRows = false;
            this.dgvHeaders.AllowUserToDeleteRows = false;
            this.dgvHeaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHeaders.ColumnHeadersHeight = 40;
            this.dgvHeaders.Dock = DockStyle.Fill;
            this.dgvHeaders.Location = new Point(3, 31);
            this.dgvHeaders.Name = "dgvHeaders";
            this.dgvHeaders.ReadOnly = true;
            this.dgvHeaders.RowHeadersWidth = 72;
            this.dgvHeaders.Size = new Size(894, 0);
            this.dgvHeaders.TabIndex = 0;
            // 
            // HttpCallDtoControl
            // 
            this.Controls.Add(this.grpHeaders);
            this.Controls.Add(this.grpBody);
            this.Controls.Add(this.grpResponseBody);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "HttpCallDtoControl";
            this.Size = new Size(900, 700);
            ((ISupportInitialize)this.bindingSourceDto).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.grpBody.ResumeLayout(false);
            this.grpBody.PerformLayout();
            this.grpResponseBody.ResumeLayout(false);
            this.grpResponseBody.PerformLayout();
            this.grpHeaders.ResumeLayout(false);
            ((ISupportInitialize)this.dgvHeaders).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private BindingSource bindingSourceDto;

        private TableLayoutPanel tableLayoutPanel;

        private Label lblTime;
        private Label lblMethod;
        private Label lblPath;
        private Label lblApiKey;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblHost;
        private Label lblResponseStatusCode;
        private Label lblForwardUrl;

        private TextBox txtTime;
        private TextBox txtMethod;
        private TextBox txtPath;
        private TextBox txtQuery;
        private TextBox txtApiKey;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtHost;
        private TextBox txtRemoteIp;
        private TextBox txtResponseStatusCode;
        private TextBox txtForwardUrl;
        private CheckBox cbIsWebSocket;

        private GroupBox grpBody;
        private TextBox txtBody;

        private GroupBox grpResponseBody;
        private TextBox txtResponseBody;

        private GroupBox grpHeaders;
        private DataGridView dgvHeaders;
    }
}
