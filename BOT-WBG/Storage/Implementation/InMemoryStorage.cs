using System;
using System.Collections.Generic;
using System.Text;

namespace BOT_WBG.Storage.Implementation
{
    public class InMemoryStorage : IDateStorage
    {
        private readonly Dictionary<string, object> _dictionary = new Dictionary<string, object>();

        public void StoreObject(object obj, string key)
        {
            if (_dictionary.ContainsKey(key)) return;
            _dictionary.Add(key, obj);
        }

        public T RestoreObject<T>(string key)
        {
            if (!_dictionary.ContainsKey(key)) throw new ArgumentException($"A chave fornecida '{key}' não foi encontrada.");

            return (T)_dictionary[key];
        }

        public void Hello()
        {
            Console.WriteLine("Olá!");
        }
    }
}