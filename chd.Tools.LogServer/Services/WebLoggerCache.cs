using System.Collections.Concurrent;
using chd.Tools.LogServer.Model;
using chd.Tools.LogServer.Settings;
using Microsoft.Extensions.Options;

namespace chd.Tools.LogServer.Services
{
    public class WebLoggerCache(AppSettings settings) 
    {
        private readonly ConcurrentBag<HttpCallDto> _data = new();

        public event EventHandler DataChanged;
        public void Add(HttpCallDto data)
        {
            while (_data.Count >= settings.MaxEntries)
            {
                _data.TryTake(out _);
            }
            _data.Add(data);
            NotifyData();
        }

        public void UpdateData() => NotifyData();

        public List<HttpCallDto> Data => _data.OrderByDescending(o => o.DateTimeOffset).ToList();

        public void Clear()
        {
            _data.Clear();
            NotifyData();
        }

        private void NotifyData() => this.DataChanged?.Invoke(this, EventArgs.Empty);
    }
}
