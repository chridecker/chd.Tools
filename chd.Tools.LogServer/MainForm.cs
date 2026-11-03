using chd.Base.Hosting.Contracts.Helper;
using chd.Base.Hosting.Contracts.Interfaces;
using chd.Base.Hosting.Contracts.Settings;
using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Modules;
using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;
using System.Net;
using chd.Base.Hosting.Forms.Base;
using chd.Base.Hosting.Forms.Extensions;
using Microsoft.Extensions.Options;

namespace chd.Tools.LogServer
{
    public partial class MainForm : BaseDiForm
    {

        private HttpLogSettings _httpLogSettings => _optionsMonitor.CurrentValue;
        private readonly WebLoggerCache _cache;
        private readonly SignalRCache _signalRCache;
        private readonly IOptionsMonitor<HttpLogSettings> _optionsMonitor;

        public MainForm(WebLoggerCache cache,
            SignalRCache signalRCache,
            IOptionsMonitor<HttpLogSettings> optionsMonitor,
            IModuleManager moduleManager, IServiceProvider serviceProvider) : base(moduleManager, serviceProvider)
        {
            _cache = cache;
            _cache.DataChanged += _cache_DataChanged;
            _signalRCache = signalRCache;
            _optionsMonitor = optionsMonitor;
            _signalRCache.DataChanged += _signalRCache_DataChanged;
            InitializeComponent();

            this.bindingSourceHttpLogSetting.DataSource = _httpLogSettings;
            this.LoadStatusCodes();
            bindingSourceLogList.CurrentChanged += BindingSourceLogList_CurrentChanged;
            bindingSourceSignalRLog.CurrentChanged += BindingSourceSignalRLog_CurrentChanged;
            dataGridView1.CellMouseClick += DataGridView1_CellMouseClick;
            dataGridView2.CellMouseDoubleClick += DataGridView2_CellMouseDoubleClick;
        }




        private async void DataGridView2_CellMouseDoubleClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (bindingSourceSignalRLog.Current is SignalRConnectionDto { CanSend: true } dto)
            {
            }
        }

        private void DataGridView1_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.RowIndex < 0)
            {
                return;
            }

            // Zeile selektieren
            dataGridView1.ClearSelection();
            dataGridView1.Rows[e.RowIndex].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];

            var menu = new ContextMenuStrip();
            menu.Items.Add("Clear", null, (_, _) =>
            {
                _cache.Clear();
            });
            menu.Show(Cursor.Position);
        }

        private void BindingSourceLogList_CurrentChanged(object? sender, EventArgs e)
        {
            if (sender is BindingSource bs
                && bs.Current is HttpCallDto dto)
            {
                httpCallDtoControl1.SetDto(dto);
            }
        }
        private void BindingSourceSignalRLog_CurrentChanged(object? sender, EventArgs e)
        {
            if (sender is BindingSource bs
                && bs.Current is SignalRConnectionDto dto)
            {
                signalrCallDtoControl1.SetDto(dto);
            }
        }

        private void _cache_DataChanged(object? sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(() => this.bindingSourceLogList.DataSource = _cache.Data);
            }
            else
            {
                this.bindingSourceLogList.DataSource = _cache.Data;
            }
        }
        private void _signalRCache_DataChanged(object? sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(() => this.bindingSourceSignalRLog.DataSource = _signalRCache.Data);
            }
            else
            {
                this.bindingSourceSignalRLog.DataSource = _signalRCache.Data;
            }
        }

        private void LoadStatusCodes()
        {
            comboBox1.DataSource = Enum
                .GetValues<HttpStatusCode>()
                .Select(x => new
                {
                    Value = x,
                    Text = $"{(int)x} - {x}"
                })
                .ToList();
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;
            comboBox1.SelectedValue = this._httpLogSettings.ResponseStatusCode;

        }

        private void ComboBox1_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (sender is ComboBox cB
                && cB.SelectedValue is HttpStatusCode statusCode)
            {
                _moduleManager.SetCustom<HttpLogSettings, HttpStatusCode>(x => x.ResponseStatusCode, statusCode, nameof(HttpLogModule));
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tB)
            {
                _moduleManager.SetCustom<HttpLogSettings, string>(x => x.ForwardUrl, tB.Text, nameof(HttpLogModule));
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tB)
            {
                _moduleManager.SetCustom<HttpLogSettings, string>(x => x.ResponseContentType, tB.Text, nameof(HttpLogModule));
            }
        }
    }
}
