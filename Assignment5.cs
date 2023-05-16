using System;
using System.Collections;


public class Program
{
   List<string>list = new List<string>();
    public void Add(String name)
    {

        list.Add(name);
        
    }

    public void Remove(String name)
    {
        if (list.Contains(name))
        {
            list.Remove(name);
            Console.WriteLine("SUCCESFULLY DELETED !!");
        }
        else
            Console.WriteLine(" Element not in the list");
       
    }

    public void Update(String name, string newName)
    {
        if(list.Contains(name))
        {
            list.Remove(name);
            list.Add(newName);

        }
        else
            Console.WriteLine(" Element not in the list");

    }


    public void Search(string name)
    
    {
            if (list.Contains(name))
            {
                Console.WriteLine(name);
            }
            else
            {
            Console.WriteLine(" Not Found!!"); 
            }
     }
    

    public void FetchData()
    {
        foreach (String name in list)
        {
            Console.WriteLine(name);
        }
    }


    public static void Main()
    {
        int n;
        Program obj = new Program();
        do 
        {
            Label:
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1 : Add an element \n 2: Remove an element \n 3 : Search an element \n 4: Update an element \n 5: Display the list ");
             n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("enter name");
                        String name = Console.ReadLine();
                        obj.Add(name);
                        
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("enter name you want to Remove");
                        String name = Console.ReadLine();
                        obj.Remove(name);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("enter name you want to Search");
                        String name = Console.ReadLine();
                        obj.Search(name);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("enter name you want to Update");
                        String name = Console.ReadLine();
                        obj.Search(name);
                        Console.WriteLine("enter name you want to insert");
                        String newName = Console.ReadLine();
                        obj.Update(name,newName);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Your Data Is : ");
                        obj.FetchData();
                        break;
                    }
                default:
                    {
                        Console.WriteLine(" enter valid choice");
                    }
                    goto Label;
            }

        }while(n!=0);
    }
}