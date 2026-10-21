using System.Collections.Concurrent;
using chd.Tools.LogServer.Settings;
using Microsoft.Extensions.Options;

namespace chd.Tools.LogServer.Services
{
    public class WebLoggerCache<T>(AppSettings settings) where T : class, new()
    {
        private readonly ConcurrentBag<T> _data = new();

        public void Add(T data)
        {
            if (_data.Count >= settings.MaxEntries)
            {
                _data.TryTake(out _);
            }
            _data.Add(data);
        }

        public List<T> Data => _data.ToList();

        public T Remove(T data) => _data.TryTake(out T d) ? d : null;
        public void Clear() => _data.Clear();
    }
}
