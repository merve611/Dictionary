using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();
            sehirler.Add(61, "Trabzon");
            sehirler.Add(69, "Bayburt");
            sehirler.Add(55, "Samsun");
            sehirler.List();
        }
    }



}
