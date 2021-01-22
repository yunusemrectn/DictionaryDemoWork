using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            MyList<string> names = new MyList<string>();
            names.Add("Yunus Emre");
            names.Add("Ali");
            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }
            */
            cMyDictionary<int, string> users = new cMyDictionary<int, string>();
            users.Add(1, "Yunus Emre");
            users.Add(2, "Ali");
            users.Add(3, "Batuhan");
            users.Add(4, "Hüseyin");
            users.Add(5, "Çetin");
            users.Add(6, "Eren");
            for (int i = 0; i < users.NKey.Length; i++)
            {
                Console.WriteLine("No : {0} -> Adı : {1}", users.NKey[i], users.NValue[i]);
            }
            Console.WriteLine("\nKayıtlı kullanıcı sayısı : {0}",users.Length);
            Console.ReadKey();
        }
    }
}
