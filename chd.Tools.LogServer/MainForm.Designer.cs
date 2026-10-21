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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            bindingSourceAppsetting = new BindingSource(components);
            label1 = new Label();
            numericUpDownmaxEntries = new NumericUpDown();
            textBoxUrl = new TextBox();
            labelPort = new Label();
            tabControl2 = new TabControl();
            bindingSourceCache = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAppsetting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownmaxEntries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCache).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1408, 774);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Log";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(numericUpDownmaxEntries);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(403, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceAppsetting, "Response", true));
            textBox1.Location = new Point(8, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(387, 246);
            textBox1.TabIndex = 8;
            // 
            // bindingSourceAppsetting
            // 
            bindingSourceAppsetting.DataSource = typeof(Settings.AppSettings);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 11);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 7;
            label1.Text = "Max Log";
            // 
            // numericUpDownmaxEntries
            // 
            numericUpDownmaxEntries.DataBindings.Add(new Binding("Value", bindingSourceAppsetting, "MaxEntries", true));
            numericUpDownmaxEntries.Location = new Point(287, 6);
            numericUpDownmaxEntries.Name = "numericUpDownmaxEntries";
            numericUpDownmaxEntries.Size = new Size(57, 23);
            numericUpDownmaxEntries.TabIndex = 6;
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
            // bindingSourceCache
            // 
            bindingSourceCache.DataSource = typeof(WebLoggerCache<HttpCallDto>);
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
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAppsetting).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownmaxEntries).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCache).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label labelPort;
        private TabControl tabControl2;
        private TabPage tabPage2;
        private BindingSource bindingSourceAppsetting;
        private BindingSource bindingSourceCache;
        private TextBox textBoxUrl;
        private NumericUpDown numericUpDownmaxEntries;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
    }
}
