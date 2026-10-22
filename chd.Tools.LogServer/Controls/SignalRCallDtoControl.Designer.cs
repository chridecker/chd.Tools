using System.ComponentModel;

namespace chd.Tools.LogServer.Controls
{
    partial class SignalRCallDtoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            bindingSourceDto = new BindingSource(components);
            grpHeaders = new GroupBox();
            dgvHeaders = new DataGridView();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTime = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            grpMessages = new GroupBox();
            dgvMessages = new DataGridView();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            directionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSourceMessage = new BindingSource(components);
            messagesBindingSource = new BindingSource(components);
            ((ISupportInitialize)bindingSourceDto).BeginInit();
            grpHeaders.SuspendLayout();
            ((ISupportInitialize)dgvHeaders).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            grpMessages.SuspendLayout();
            ((ISupportInitialize)dgvMessages).BeginInit();
            ((ISupportInitialize)bindingSourceMessage).BeginInit();
            ((ISupportInitialize)messagesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // bindingSourceDto
            // 
            bindingSourceDto.DataSource = typeof(Model.SignalRConnectionDto);
            // 
            // grpHeaders
            // 
            grpHeaders.Controls.Add(dgvHeaders);
            grpHeaders.Dock = DockStyle.Top;
            grpHeaders.Location = new Point(0, 519);
            grpHeaders.Name = "grpHeaders";
            grpHeaders.Size = new Size(1086, 247);
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
            dgvHeaders.Size = new Size(1080, 225);
            dgvHeaders.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1086, 112);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "SignalR Connection";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtTime, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox4, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1080, 90);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTime
            // 
            txtTime.DataBindings.Add(new Binding("Text", bindingSourceDto, "DateTimeOffset", true));
            txtTime.Location = new Point(103, 3);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(100, 23);
            txtTime.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Zeit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "IP / Host";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 58);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Hub";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceDto, "RemoteIpAddress", true));
            textBox1.Location = new Point(103, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSourceDto, "Host", true));
            textBox2.Location = new Point(593, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSourceDto, "Path", true));
            textBox3.Location = new Point(103, 61);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSourceDto, "Query", true));
            textBox4.Location = new Point(593, 61);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // grpMessages
            // 
            grpMessages.Controls.Add(dgvMessages);
            grpMessages.Dock = DockStyle.Top;
            grpMessages.Location = new Point(0, 112);
            grpMessages.Name = "grpMessages";
            grpMessages.Size = new Size(1086, 407);
            grpMessages.TabIndex = 0;
            grpMessages.TabStop = false;
            grpMessages.Text = "Messages";
            // 
            // dgvMessages
            // 
            dgvMessages.AllowUserToAddRows = false;
            dgvMessages.AllowUserToDeleteRows = false;
            dgvMessages.AutoGenerateColumns = false;
            dgvMessages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMessages.Columns.AddRange(new DataGridViewColumn[] { timeDataGridViewTextBoxColumn, directionDataGridViewTextBoxColumn, dataDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn });
            dgvMessages.DataSource = bindingSourceMessage;
            dgvMessages.Dock = DockStyle.Fill;
            dgvMessages.Location = new Point(3, 19);
            dgvMessages.Name = "dgvMessages";
            dgvMessages.ReadOnly = true;
            dgvMessages.Size = new Size(1080, 385);
            dgvMessages.TabIndex = 0;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy HH:mm:ss,fff";
            timeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            timeDataGridViewTextBoxColumn.HeaderText = "Time";
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            timeDataGridViewTextBoxColumn.ReadOnly = true;
            timeDataGridViewTextBoxColumn.Width = 59;
            // 
            // directionDataGridViewTextBoxColumn
            // 
            directionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            directionDataGridViewTextBoxColumn.DataPropertyName = "Direction";
            directionDataGridViewTextBoxColumn.HeaderText = "Direction";
            directionDataGridViewTextBoxColumn.Name = "directionDataGridViewTextBoxColumn";
            directionDataGridViewTextBoxColumn.ReadOnly = true;
            directionDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataDataGridViewTextBoxColumn.DataPropertyName = "Value";
            dataDataGridViewTextBoxColumn.HeaderText = "Value";
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            dataDataGridViewTextBoxColumn.ReadOnly = true;
            dataDataGridViewTextBoxColumn.Width = 56;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            typeDataGridViewTextBoxColumn.Visible = false;
            typeDataGridViewTextBoxColumn.Width = 57;
            // 
            // bindingSourceMessage
            // 
            bindingSourceMessage.DataSource = messagesBindingSource;
            // 
            // messagesBindingSource
            // 
            messagesBindingSource.DataMember = "Messages";
            messagesBindingSource.DataSource = bindingSourceDto;
            // 
            // SignalRCallDtoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpHeaders);
            Controls.Add(grpMessages);
            Controls.Add(groupBox1);
            Name = "SignalRCallDtoControl";
            Size = new Size(1086, 769);
            ((ISupportInitialize)bindingSourceDto).EndInit();
            grpHeaders.ResumeLayout(false);
            ((ISupportInitialize)dgvHeaders).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            grpMessages.ResumeLayout(false);
            ((ISupportInitialize)dgvMessages).EndInit();
            ((ISupportInitialize)bindingSourceMessage).EndInit();
            ((ISupportInitialize)messagesBindingSource).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private BindingSource bindingSourceDto;
        private GroupBox grpHeaders;
        private DataGridView dgvHeaders;
        private GroupBox grpMessages;
        private DataGridView dgvMessages;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTime;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private BindingSource bindingSourceMessage;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn directionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private BindingSource messagesBindingSource;
    }
}
