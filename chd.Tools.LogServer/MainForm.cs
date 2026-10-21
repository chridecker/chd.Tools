using System.Net;
using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;

namespace chd.Tools.LogServer
{
    public partial class MainForm : Form
    {
        private readonly AppSettings _appSettings;
        private readonly WebLoggerCache _cache;

        public MainForm(AppSettings appSettings, WebLoggerCache cache, IServer server)
        {
            _appSettings = appSettings;
            _cache = cache;
            _cache.DataChanged += _cache_DataChanged;
            InitializeComponent();
            this.bindingSourceAppsetting.DataSource = _appSettings;
            var addresses = server.Features.Get<IServerAddressesFeature>();
            this.textBoxUrl.Text = string.Join(",", addresses?.Addresses ?? Enumerable.Empty<string>());
            this.LoadStatusCodes();
            bindingSourceLogList.CurrentChanged += BindingSourceLogList_CurrentChanged;
            dataGridView1.CellMouseClick += DataGridView1_CellMouseClick; ;
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

            comboBox1.DataBindings.Add("SelectedValue", _appSettings, nameof(AppSettings.ResponseStatusCode), true,
                DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
