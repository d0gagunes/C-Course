using System;

namespace MyDictionary
{
    class Program
    {
        class MyDictionary <key, value>
        {
            key[] keys;
            value[] values;

        }
        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];

        }
        public void Add (Key key, Value value)
        {
            Key[] tempKey = keys; 
            keys = new Key[keys.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];

            }
            keys[keys.Length - 1] = key;
            Value[] tempValue = values;
            values = new Value[values.Length + 1];
            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }
            values[values.Length - 1] = value;
            Console.WriteLine("Yas: " + key + " , " + " Isim: " + value);

        }
    }
}
