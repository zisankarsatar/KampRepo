using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictonary<K,V>
    {
        K[] keys;
        V[] values;
        public Dictonary()
        {
            keys = new K[0];
            values = new V[0];
        }
        public void Add(K key,V val)
        {
            K[] tempKey = keys;
            V[] tempVal = values;
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];
            for (int i = 0; i <tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempVal[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = val;

            Console.WriteLine(key + " " + val);

        }

    }
}