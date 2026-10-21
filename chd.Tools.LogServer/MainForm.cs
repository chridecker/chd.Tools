using System.Net;
using chd.Tools.LogServer.Extensions;
using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Services;
using chd.Tools.LogServer.Settings;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.Options;
using NLog.Config;
using NLog.Extensions.Logging;
using NLog.Layouts;
using NLog.Targets;
using NLog.Web;

namespace chd.Tools.LogServer
{
    public partial class MainForm : Form
    {
        private readonly AppSettings _appSettings;
        private readonly WebLoggerCache<HttpCallDto> _cache;

        public MainForm(AppSettings appSettings, WebLoggerCache<HttpCallDto> cache, IServer server)
        {
            _appSettings = appSettings;
            _cache = cache;
            InitializeComponent();
            this.bindingSourceAppsetting.DataSource = _appSettings;
            this.bindingSourceCache.DataSource = _cache;
            var addresses = server.Features.Get<IServerAddressesFeature>();
            this.textBoxUrl.Text = string.Join(",", addresses?.Addresses ?? Enumerable.Empty<string>());
            this.LoadStatusCodes();
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
