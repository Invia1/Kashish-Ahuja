using System;
using System.Collections.Generic;

class Dictionary
{
    static public void Main()
    {

        Dictionary<int, string> dic1 = new Dictionary<int, string>();

        dic1.Add(1, "Deepa");
        dic1.Add(2, "Deepak");
        dic1.Add(3, "Tani");

        foreach (KeyValuePair<int, string> ele1 in dic1)
        {
            Console.WriteLine("{0} and {1}",
                        ele1.Key, ele1.Value);
        }
        Console.WriteLine();

        Dictionary<string, string> dic2 = new Dictionary<string, string>()
        {
                                {"Hello", "World"},
                                {"Welcome", "to my dict"},
                                {"Good", "Bye"}
        };

        foreach (KeyValuePair<string, string> ele2 in dic2)
        {
            Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
        }
    }
}