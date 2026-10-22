using chd.Tools.LogServer.Model;
using System.Collections.Concurrent;

namespace chd.Tools.LogServer.Services
{
    public abstract class BaseCache<T> where T : BaseCallDto
    {
        private readonly ConcurrentBag<T> _data = new();

        public event EventHandler DataChanged;
        public void Add(T data)
        {
            _data.Add(data);
            NotifyData();
        }

        public void UpdateData() => NotifyData();

        public List<T> Data => _data.OrderByDescending(o => o.DateTimeOffset).ToList();

        public void Clear()
        {
            _data.Clear();
            NotifyData();
        }

        private void NotifyData() => this.DataChanged?.Invoke(this, EventArgs.Empty);
    }
}
