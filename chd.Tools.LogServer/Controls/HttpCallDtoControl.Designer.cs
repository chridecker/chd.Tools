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
            components = new Container();
            bindingSourceDto = new BindingSource(components);
            tableLayoutPanel = new TableLayoutPanel();
            lblTime = new Label();
            txtTime = new TextBox();
            lblMethod = new Label();
            txtMethod = new TextBox();
            lblPath = new Label();
            txtPath = new TextBox();
            lblQuery = new Label();
            txtQuery = new TextBox();
            lblApiKey = new Label();
            txtApiKey = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblHost = new Label();
            txtHost = new TextBox();
            lblRemoteIp = new Label();
            txtRemoteIp = new TextBox();
            lblResponseStatusCode = new Label();
            txtResponseStatusCode = new TextBox();
            grpBody = new GroupBox();
            txtBody = new TextBox();
            grpResponseBody = new GroupBox();
            txtResponseBody = new TextBox();
            grpHeaders = new GroupBox();
            dgvHeaders = new DataGridView();
            ((ISupportInitialize)bindingSourceDto).BeginInit();
            tableLayoutPanel.SuspendLayout();
            grpBody.SuspendLayout();
            grpResponseBody.SuspendLayout();
            grpHeaders.SuspendLayout();
            ((ISupportInitialize)dgvHeaders).BeginInit();
            SuspendLayout();
            // 
            // bindingSourceDto
            // 
            bindingSourceDto.DataSource = typeof(Model.HttpCallDto);
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(lblTime, 0, 0);
            tableLayoutPanel.Controls.Add(txtTime, 1, 0);
            tableLayoutPanel.Controls.Add(lblMethod, 0, 3);
            tableLayoutPanel.Controls.Add(txtMethod, 1, 3);
            tableLayoutPanel.Controls.Add(lblPath, 0, 4);
            tableLayoutPanel.Controls.Add(txtPath, 1, 4);
            tableLayoutPanel.Controls.Add(lblQuery, 0, 5);
            tableLayoutPanel.Controls.Add(txtQuery, 1, 5);
            tableLayoutPanel.Controls.Add(lblApiKey, 0, 7);
            tableLayoutPanel.Controls.Add(txtApiKey, 1, 7);
            tableLayoutPanel.Controls.Add(lblUsername, 0, 8);
            tableLayoutPanel.Controls.Add(txtUsername, 1, 8);
            tableLayoutPanel.Controls.Add(lblPassword, 0, 9);
            tableLayoutPanel.Controls.Add(txtPassword, 1, 9);
            tableLayoutPanel.Controls.Add(lblHost, 0, 2);
            tableLayoutPanel.Controls.Add(txtHost, 1, 2);
            tableLayoutPanel.Controls.Add(lblRemoteIp, 0, 1);
            tableLayoutPanel.Controls.Add(txtRemoteIp, 1, 1);
            tableLayoutPanel.Controls.Add(lblResponseStatusCode, 0, 6);
            tableLayoutPanel.Controls.Add(txtResponseStatusCode, 1, 6);
            tableLayoutPanel.Dock = DockStyle.Top;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(5);
            tableLayoutPanel.RowCount = 9;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(900, 210);
            tableLayoutPanel.TabIndex = 2;
            // 
            // lblTime
            // 
            lblTime.Location = new Point(8, 5);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(100, 20);
            lblTime.TabIndex = 0;
            lblTime.Text = "Zeit";
            // 
            // txtTime
            // 
            txtTime.DataBindings.Add(new Binding("Text", bindingSourceDto, "DateTimeOffset", true, DataSourceUpdateMode.Never, "HH:mm:ss,fff dd.MM.yyyy", "HH:mm:ss,fff dd.MM.yyyy"));
            txtTime.Location = new Point(148, 8);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(100, 23);
            txtTime.TabIndex = 1;
            // 
            // lblMethod
            // 
            lblMethod.Location = new Point(8, 65);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(100, 20);
            lblMethod.TabIndex = 2;
            lblMethod.Text = "Method";
            // 
            // txtMethod
            // 
            txtMethod.DataBindings.Add(new Binding("Text", bindingSourceDto, "Method", true));
            txtMethod.Location = new Point(148, 68);
            txtMethod.Name = "txtMethod";
            txtMethod.Size = new Size(100, 23);
            txtMethod.TabIndex = 3;
            // 
            // lblPath
            // 
            lblPath.Location = new Point(8, 85);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(100, 20);
            lblPath.TabIndex = 4;
            lblPath.Text = "Path";
            // 
            // txtPath
            // 
            txtPath.DataBindings.Add(new Binding("Text", bindingSourceDto, "Path", true));
            txtPath.Location = new Point(148, 88);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(100, 23);
            txtPath.TabIndex = 5;
            // 
            // lblQuery
            // 
            lblQuery.Location = new Point(8, 105);
            lblQuery.Name = "lblQuery";
            lblQuery.Size = new Size(100, 20);
            lblQuery.TabIndex = 6;
            lblQuery.Text = "Query";
            // 
            // txtQuery
            // 
            txtQuery.DataBindings.Add(new Binding("Text", bindingSourceDto, "Query", true));
            txtQuery.Location = new Point(148, 108);
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(100, 23);
            txtQuery.TabIndex = 7;
            // 
            // lblApiKey
            // 
            lblApiKey.Location = new Point(8, 145);
            lblApiKey.Name = "lblApiKey";
            lblApiKey.Size = new Size(100, 20);
            lblApiKey.TabIndex = 8;
            lblApiKey.Text = "Api Key";
            // 
            // txtApiKey
            // 
            txtApiKey.DataBindings.Add(new Binding("Text", bindingSourceDto, "ApiKey", true));
            txtApiKey.Location = new Point(148, 148);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.Size = new Size(100, 23);
            txtApiKey.TabIndex = 9;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(8, 165);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 20);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Basic Username";
            // 
            // txtUsername
            // 
            txtUsername.DataBindings.Add(new Binding("Text", bindingSourceDto, "Username", true));
            txtUsername.Location = new Point(148, 168);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(8, 185);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Basic Password";
            // 
            // txtPassword
            // 
            txtPassword.DataBindings.Add(new Binding("Text", bindingSourceDto, "Password", true));
            txtPassword.Location = new Point(148, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 9;
            // 
            // lblHost
            // 
            lblHost.Location = new Point(8, 45);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(100, 20);
            lblHost.TabIndex = 10;
            lblHost.Text = "Host";
            // 
            // txtHost
            // 
            txtHost.DataBindings.Add(new Binding("Text", bindingSourceDto, "Host", true));
            txtHost.Location = new Point(148, 48);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(100, 23);
            txtHost.TabIndex = 11;
            // 
            // lblRemoteIp
            // 
            lblRemoteIp.Location = new Point(8, 25);
            lblRemoteIp.Name = "lblRemoteIp";
            lblRemoteIp.Size = new Size(100, 20);
            lblRemoteIp.TabIndex = 12;
            lblRemoteIp.Text = "Remote IP";
            // 
            // txtRemoteIp
            // 
            txtRemoteIp.DataBindings.Add(new Binding("Text", bindingSourceDto, "RemoteIpAddress", true));
            txtRemoteIp.Location = new Point(148, 28);
            txtRemoteIp.Name = "txtRemoteIp";
            txtRemoteIp.Size = new Size(100, 23);
            txtRemoteIp.TabIndex = 13;
            // 
            // lblResponseStatusCode
            // 
            lblResponseStatusCode.Location = new Point(8, 125);
            lblResponseStatusCode.Name = "lblResponseStatusCode";
            lblResponseStatusCode.Size = new Size(100, 20);
            lblResponseStatusCode.TabIndex = 12;
            lblResponseStatusCode.Text = "Response HttpStatus";
            // 
            // txtResponseStatusCode
            // 
            txtResponseStatusCode.DataBindings.Add(new Binding("Text", bindingSourceDto, "ResponseStatusCodeText", true));
            txtResponseStatusCode.Location = new Point(148, 128);
            txtResponseStatusCode.Name = "txtResponseStatusCode";
            txtResponseStatusCode.Size = new Size(100, 23);
            txtResponseStatusCode.TabIndex = 5;
            // 
            // grpBody
            // 
            grpBody.Controls.Add(txtBody);
            grpBody.Dock = DockStyle.Top;
            grpBody.Location = new Point(0, 390);
            grpBody.Name = "grpBody";
            grpBody.Size = new Size(900, 180);
            grpBody.TabIndex = 1;
            grpBody.TabStop = false;
            grpBody.Text = "Response Body";
            // 
            // txtBody
            // 
            txtBody.DataBindings.Add(new Binding("Text", bindingSourceDto, "ResponseBody", true));
            txtBody.Dock = DockStyle.Fill;
            txtBody.Font = new Font("Consolas", 9F);
            txtBody.Location = new Point(3, 19);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.ReadOnly = true;
            txtBody.ScrollBars = ScrollBars.Both;
            txtBody.Size = new Size(894, 158);
            txtBody.TabIndex = 0;
            // 
            // grpResponseBody
            // 
            grpResponseBody.Controls.Add(txtResponseBody);
            grpResponseBody.Dock = DockStyle.Top;
            grpResponseBody.Location = new Point(0, 210);
            grpResponseBody.Name = "grpResponseBody";
            grpResponseBody.Size = new Size(900, 180);
            grpResponseBody.TabIndex = 1;
            grpResponseBody.TabStop = false;
            grpResponseBody.Text = "Body";
            // 
            // txtResponseBody
            // 
            txtResponseBody.DataBindings.Add(new Binding("Text", bindingSourceDto, "Body", true));
            txtResponseBody.Dock = DockStyle.Fill;
            txtResponseBody.Font = new Font("Consolas", 9F);
            txtResponseBody.Location = new Point(3, 19);
            txtResponseBody.Multiline = true;
            txtResponseBody.Name = "txtResponseBody";
            txtResponseBody.ReadOnly = true;
            txtResponseBody.ScrollBars = ScrollBars.Both;
            txtResponseBody.Size = new Size(894, 158);
            txtResponseBody.TabIndex = 0;
            // 
            // grpHeaders
            // 
            grpHeaders.Controls.Add(dgvHeaders);
            grpHeaders.Dock = DockStyle.Fill;
            grpHeaders.Location = new Point(0, 570);
            grpHeaders.Name = "grpHeaders";
            grpHeaders.Size = new Size(900, 130);
            grpHeaders.TabIndex = 0;
            grpHeaders.TabStop = false;
            grpHeaders.Text = "Headers";
            // 
            // dgvHeaders
            // 
            dgvHeaders.AllowUserToAddRows = false;
            dgvHeaders.AllowUserToDeleteRows = false;
            dgvHeaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHeaders.Dock = DockStyle.Fill;
            dgvHeaders.Location = new Point(3, 19);
            dgvHeaders.Name = "dgvHeaders";
            dgvHeaders.ReadOnly = true;
            dgvHeaders.Size = new Size(894, 108);
            dgvHeaders.TabIndex = 0;
            // 
            // HttpCallDtoControl
            // 
            Controls.Add(grpHeaders);
            Controls.Add(grpBody);
            Controls.Add(grpResponseBody);
            Controls.Add(tableLayoutPanel);
            Name = "HttpCallDtoControl";
            Size = new Size(900, 700);
            ((ISupportInitialize)bindingSourceDto).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            grpBody.ResumeLayout(false);
            grpBody.PerformLayout();
            grpResponseBody.ResumeLayout(false);
            grpResponseBody.PerformLayout();
            grpHeaders.ResumeLayout(false);
            ((ISupportInitialize)dgvHeaders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private BindingSource bindingSourceDto;

        private TableLayoutPanel tableLayoutPanel;

        private Label lblTime;
        private Label lblMethod;
        private Label lblPath;
        private Label lblQuery;
        private Label lblApiKey;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblHost;
        private Label lblRemoteIp;
        private Label lblResponseStatusCode;

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

        private GroupBox grpBody;
        private TextBox txtBody;

        private GroupBox grpResponseBody;
        private TextBox txtResponseBody;

        private GroupBox grpHeaders;
        private DataGridView dgvHeaders;
    }
}
