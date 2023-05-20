using System;
using System.Collections;


namespace HashTable
{
    class HashTable
    {

        static public void Main()
        {
            Hashtable hs1 = new Hashtable();

            hs1.Add("1", "Deepa");
            hs1.Add("2", "Deepak");
            hs1.Add("3", "Kashish");

            Console.WriteLine("Key and Value pairs from my_hashtable1:");

            foreach (DictionaryEntry el in hs1)
            {
                Console.WriteLine("{0} and {1} ", el.Key, el.Value);
            }

            Hashtable hs2 = new Hashtable()
            {
                                        {1, "hello"},
                                        {2, 234},
                                        {3, "World"},
                                        {4, null}
            };

            Console.WriteLine("Key and Value pairs from my_hashtable2:");

            foreach (var ele1 in hs1.Keys)
            {
                Console.WriteLine("{0} and {1}", ele1,
                                hs1[ele1]);
            }
        }
    }

}