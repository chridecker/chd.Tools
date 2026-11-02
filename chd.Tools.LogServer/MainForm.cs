using chd.Base.Hosting.Contracts.Helper;
using chd.Base.Hosting.Contracts.Interfaces;
using chd.Base.Hosting.Contracts.Settings;
using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Modules;
using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;
using System.Net;
using System.Net.NetworkInformation;

namespace chd.Tools.LogServer
{
    public partial class MainForm : Form
    {
        private readonly HttpLogSettings _appSettings;
        private readonly WebLoggerCache _cache;
        private readonly SignalRCache _signalRCache;
        private readonly IModuleManager _moduleManager;
        private readonly IServiceProvider _serviceProvider;

        public MainForm(HttpLogSettings appSettings, WebLoggerCache cache,
            SignalRCache signalRCache,
            IModuleManager moduleManager, IServiceProvider serviceProvider)
        {
            _appSettings = appSettings;
            _cache = cache;
            _cache.DataChanged += _cache_DataChanged;
            _signalRCache = signalRCache;
            this._moduleManager = moduleManager;
            this._serviceProvider = serviceProvider;
            _signalRCache.DataChanged += _signalRCache_DataChanged;
            InitializeComponent();

            this._moduleManager.Set<WebModuleSettings, int>(nameof(httpLogModule),
                x => x.Port,
                int.TryParse(textBoxLogPort.Text, out var port) ? port : 0);

            this.FormClosing += MainForm_FormClosing;

            this.bindingSourceAppsetting.DataSource = _appSettings;
            this.LoadStatusCodes();
            this.LoadIpAddresses();
            bindingSourceLogList.CurrentChanged += BindingSourceLogList_CurrentChanged;
            bindingSourceSignalRLog.CurrentChanged += BindingSourceSignalRLog_CurrentChanged;
            dataGridView1.CellMouseClick += DataGridView1_CellMouseClick;
            dataGridView2.CellMouseDoubleClick += DataGridView2_CellMouseDoubleClick;
            NetworkChange.NetworkAddressChanged += OnNetworkAddressChanged;
        }

        private async void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing
                && _moduleManager.Names.Any(a => _moduleManager.IsRunning(a))
                && MessageBox.Show("Server currently running! Do you really want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void OnNetworkAddressChanged(object? sender, EventArgs e)
        {
            if (IsHandleCreated && !IsDisposed)
            {
                BeginInvoke(LoadIpAddresses);
            }
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

            comboBox1.DataBindings.Add("SelectedValue", _appSettings, nameof(HttpLogSettings.ResponseStatusCode), true,
                DataSourceUpdateMode.OnPropertyChanged);
        }
        private void LoadIpAddresses()
        {
            var previous = (comboBoxIPs.SelectedItem as IpOption)?.Address;

            var items = IpAddressProvider.GetAvailable();
            comboBoxIPs.DataSource = null;
            comboBoxIPs.DataSource = items;

            var selected = items.FirstOrDefault(i => i.Address.Equals(previous))
                           ?? items.First(x => Equals(x.Address, IPAddress.Loopback));
            comboBoxIPs.SelectedItem = selected;
        }

        private async void buttonLogServer_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                await this.Toggle(nameof(httpLogModule), b);
            }
        }
        private async Task Toggle(string name, Button button)
        {
            button.Enabled = false;
            try
            {
                if (_moduleManager.IsRunning(name))
                {
                    await _moduleManager.StopAsync(name);
                    button.Text = $"Start";
                    comboBoxIPs.Enabled = !_moduleManager.Names.Any(_moduleManager.IsRunning);
                }
                else
                {
                    var ip = (comboBoxIPs.SelectedItem as IpOption)?.Address ?? IPAddress.Loopback;
                    _moduleManager.Set<WebModuleSettings, string>(name, x => x.Host, ip.ToString());
                    await _moduleManager.StartAsync(name);
                    button.Text = $"Stop";
                    comboBoxIPs.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, $"{name} Fehler");
            }
            finally { button.Enabled = true; }
        }

        private void textBoxLogPort_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox
                && int.TryParse(textBox.Text, out var port))
            {
                _moduleManager.Set<WebModuleSettings,int>(nameof(httpLogModule), x => x.Port, port);
            }
        }
    }
}
