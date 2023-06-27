using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHash
{
    internal class Hash
    {
        private const int TableSize = 10;
        private LinkedList<KeyValue>[] table;

        public Hash()
        {
            table = new LinkedList<KeyValue>[TableSize];
        }

        public void Add(string key, string value)
        {
            int index = HashFunction(key);

            if (table[index] == null)
            {
                table[index] = new LinkedList<KeyValue>();
            }

            foreach (KeyValue kv in table[index])
            {
                if (kv.Key == key)
                {
                    kv.Value = value;
                    return;
                }
            }

            table[index].AddLast(new KeyValue(key, value));
        }

        public string Get(string key)
        {
            int index = HashFunction(key);

            if (table[index] != null)
            {
                foreach (KeyValue kv in table[index])
                {
                    if (kv.Key == key)
                    {
                        return kv.Value;
                    }
                }
            }

            return null;
        }

        private int HashFunction(string key)
        {
            int hash = 0;

            foreach (char c in key)
            {
                hash += (int)c;
            }

            return hash % TableSize;
        }

        private class KeyValue
        {
            public string Key { get; }
            public string Value { get; set; }

            public KeyValue(string key, string value)
            {
                Key = key;
                Value = value;
            }
        }
    }
}
