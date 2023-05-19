using System;
class HashSet
{
        public static void Main()
    {
        HashSet<int> set1 = new HashSet<int>();

        // Add Elements in HashSet

        for (int i = 1; i <= 10; i++)
        {
            set1.Add(i);
        }

        // Display the elements in HashSet
        Console.WriteLine("The elements in the HashSet are:");
        foreach (int i in set1)
        {
            Console.WriteLine(i);
        }

        // Removing all even elements from set

        Console.WriteLine(" Remove all even elements and display all odd numbers : ");
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                set1.Remove(i);
            }
        }
        Console.WriteLine("The odd elements in the HashSet are:");
        foreach (int i in set1)
        {
            Console.WriteLine(i);
        }
    }
}