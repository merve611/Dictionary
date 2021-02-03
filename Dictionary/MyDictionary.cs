using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] Keys;
        TValue[] Values;

        //Constructor;
        public MyDictionary()
        {
            Keys = new TKey[0];
            Values = new TValue[0];
        }
        public void Add(TKey Key, TValue Value)
        {
            TKey[] TempKey = Keys;
            TValue[] TempValue = Values;

            Keys = new TKey[Keys.Length + 1];
            Values = new TValue[Values.Length + 1];

            for (int i = 0; i < TempKey.Length; i++)
            {
                Keys[i] = TempKey[i];
                Values[i] = TempValue[i];
            }

            Keys[Keys.Length - 1] = Key;
            Values[Values.Length - 1] = Value;
        }



        //public int Length
        //{
        //    get { return Keys.Length; }

        //}

        //public TKey[] keys
        //{
        //    get { return Keys; }
        //}


        //public TValue[] values
        //{
        //    get { return Values; }

        //}



        public void List()

        {
            for (int i = 0; i < Keys.Length; i++)
            {
                Console.WriteLine(Keys[i] + "  " + Values[i]);
            }
        }


    }
}
