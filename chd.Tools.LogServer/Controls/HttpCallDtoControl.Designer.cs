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
            lblMethod = new Label();
            lblPath = new Label();
            lblQuery = new Label();
            lblApiKey = new Label();
            lblHost = new Label();
            lblRemoteIp = new Label();

            txtTime = new TextBox();
            txtMethod = new TextBox();
            txtPath = new TextBox();
            txtQuery = new TextBox();
            txtApiKey = new TextBox();
            txtHost = new TextBox();
            txtRemoteIp = new TextBox();

            grpBody = new GroupBox();
            txtBody = new TextBox();

            grpHeaders = new GroupBox();
            dgvHeaders = new DataGridView();

            ((ISupportInitialize)bindingSourceDto).BeginInit();
            ((ISupportInitialize)dgvHeaders).BeginInit();

            SuspendLayout();

            //
            // bindingSourceDto
            //
            bindingSourceDto.DataSource = typeof(Model.HttpCallDto);

            //
            // tableLayoutPanel
            //
            tableLayoutPanel.Dock = DockStyle.Top;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Padding = new Padding(5);
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.RowCount = 7;

            tableLayoutPanel.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 140));

            tableLayoutPanel.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100));

            //
            // labels
            //
            lblTime.Text = "Zeit";
            lblMethod.Text = "Method";
            lblPath.Text = "Path";
            lblQuery.Text = "Query";
            lblApiKey.Text = "Api Key";
            lblHost.Text = "Host";
            lblRemoteIp.Text = "Remote IP";

            //
            // textbox setup
            //
            ConfigureReadOnlyTextBox(txtTime);
            ConfigureReadOnlyTextBox(txtMethod);
            ConfigureReadOnlyTextBox(txtPath);
            ConfigureReadOnlyTextBox(txtQuery);
            ConfigureReadOnlyTextBox(txtApiKey);
            ConfigureReadOnlyTextBox(txtHost);
            ConfigureReadOnlyTextBox(txtRemoteIp);

            //
            // databindings
            //
            txtTime.DataBindings.Add(
                "Text",
                bindingSourceDto,
                nameof(Model.HttpCallDto.DateTimeOffset));

            txtMethod.DataBindings.Add(
                "Text",
                bindingSourceDto,
                nameof(Model.HttpCallDto.Method));

            txtPath.DataBindings.Add(
                "Text",
                bindingSourceDto,
                nameof(Model.HttpCallDto.Path));

            txtQuery.DataBindings.Add(
                "Text",
                bindingSourceDto,
                nameof(Model.HttpCallDto.Query));

            txtApiKey.DataBindings.Add(
                "Text",
                bindingSourceDto,
                nameof(Model.HttpCallDto.ApiKey));

            txtHost.DataBindings.Add(
                "Text",
                bindingSourceDto,
                nameof(Model.HttpCallDto.Host));

            txtRemoteIp.DataBindings.Add(
                "Text",
                bindingSourceDto,
                nameof(Model.HttpCallDto.RemoteIpAddress));

            //
            // layout rows
            //
            tableLayoutPanel.Controls.Add(lblTime, 0, 0);
            tableLayoutPanel.Controls.Add(txtTime, 1, 0);

            tableLayoutPanel.Controls.Add(lblMethod, 0, 1);
            tableLayoutPanel.Controls.Add(txtMethod, 1, 1);

            tableLayoutPanel.Controls.Add(lblPath, 0, 2);
            tableLayoutPanel.Controls.Add(txtPath, 1, 2);

            tableLayoutPanel.Controls.Add(lblQuery, 0, 3);
            tableLayoutPanel.Controls.Add(txtQuery, 1, 3);

            tableLayoutPanel.Controls.Add(lblApiKey, 0, 4);
            tableLayoutPanel.Controls.Add(txtApiKey, 1, 4);

            tableLayoutPanel.Controls.Add(lblHost, 0, 5);
            tableLayoutPanel.Controls.Add(txtHost, 1, 5);

            tableLayoutPanel.Controls.Add(lblRemoteIp, 0, 6);
            tableLayoutPanel.Controls.Add(txtRemoteIp, 1, 6);

            //
            // grpBody
            //
            grpBody.Text = "Body";
            grpBody.Dock = DockStyle.Top;
            grpBody.Height = 180;

            txtBody.Dock = DockStyle.Fill;
            txtBody.Multiline = true;
            txtBody.ScrollBars = ScrollBars.Both;
            txtBody.ReadOnly = true;
            txtBody.Font = new Font("Consolas", 9F);

            txtBody.DataBindings.Add(
                "Text",
                bindingSourceDto,
                nameof(Model.HttpCallDto.Body));

            grpBody.Controls.Add(txtBody);

            //
            // grpHeaders
            //
            grpHeaders.Text = "Headers";
            grpHeaders.Dock = DockStyle.Fill;

            dgvHeaders.Dock = DockStyle.Fill;
            dgvHeaders.ReadOnly = true;
            dgvHeaders.AllowUserToAddRows = false;
            dgvHeaders.AllowUserToDeleteRows = false;
            dgvHeaders.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            grpHeaders.Controls.Add(dgvHeaders);

            //
            // control
            //
            Controls.Add(grpHeaders);
            Controls.Add(grpBody);
            Controls.Add(tableLayoutPanel);

            Name = "HttpCallDtoControl";
            Size = new Size(900, 700);

            ((ISupportInitialize)dgvHeaders).EndInit();
            ((ISupportInitialize)bindingSourceDto).EndInit();

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
        private Label lblHost;
        private Label lblRemoteIp;

        private TextBox txtTime;
        private TextBox txtMethod;
        private TextBox txtPath;
        private TextBox txtQuery;
        private TextBox txtApiKey;
        private TextBox txtHost;
        private TextBox txtRemoteIp;

        private GroupBox grpBody;
        private TextBox txtBody;

        private GroupBox grpHeaders;
        private DataGridView dgvHeaders;

        private static void ConfigureReadOnlyTextBox(TextBox textBox)
        {
            textBox.Dock = DockStyle.Fill;
            textBox.ReadOnly = true;
        }
    }
}
