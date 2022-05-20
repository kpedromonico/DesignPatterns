using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class RandomCache
    {
        private static RandomCache _instance;
        private static object _lock = new object(); 

        private Dictionary<string, string> _cache;

        private RandomCache()
        {
            if (_cache == null)
            {
                _cache = new Dictionary<string, string>();
            }
        }

        public static RandomCache Instance
        {
            get
            {
                // Double-Checked locking to avoid expensive lockings (https://en.wikipedia.org/wiki/Double-checked_locking)
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new RandomCache();
                        }
                    }
                }

                return _instance;
            }
        }

        public void AddItem(string key, string value)
        {
            lock (_lock)
            {
                if (_cache.TryAdd(key, value))
                {
                    Console.WriteLine($"Cache: {key} added");
                }
                else
                {
                    Console.WriteLine($"Cache: A key {key} already exists");
                }
            }
        }

        public void RemoveItem(string key)
        {
            lock (_lock)
            {
                if (_cache.ContainsKey(key))
                {
                    _cache.Remove(key);
                    Console.WriteLine($"Cache: {key} Removed");
                }
                else
                {
                    Console.WriteLine($"Cache {key} was not found");
                }

            }
        }

        public (string k, string v) GetItem(string key)
        {
            lock (_lock)
            {
                if (_cache.TryGetValue(key, out var value))
                {
                    return (key, value);
                }

                Console.WriteLine($"Cache: {key} does not exist");
                return (string.Empty, string.Empty);
            }
        }
    }
}
