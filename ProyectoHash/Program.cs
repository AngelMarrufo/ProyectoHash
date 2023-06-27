using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hash hashTable = new Hash();

            hashTable.Add("key1", "value1");
            hashTable.Add("key2", "value2");
            hashTable.Add("key3", "value3");
            hashTable.Add("key4", "value4");
            hashTable.Add("key5", "value5");
            hashTable.Add("key6", "value6");
            hashTable.Add("key7", "value7");

            Console.WriteLine("Valor de 'key1': " + hashTable.Get("key1"));
            Console.WriteLine("Valor de 'key3': " + hashTable.Get("key3"));
            Console.WriteLine("Valor de 'key6': " + hashTable.Get("key6"));
            Console.WriteLine("Valor de 'key8': " + hashTable.Get("key8"));

            Console.ReadLine();
        }
    }
}
