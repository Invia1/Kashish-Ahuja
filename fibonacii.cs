   

public class Program{
public static void Fibonacci(int len)  
{  
    int a = 0, b = 1, c = 0;  
    Console.Write("0 1", a,b);  
    for (int i = 2; i < len; i++)  
    {  
        c= a + b;  
        Console.Write(" {0}", c);  
        a= b;  
        b= c;  
    }  
}  
public static void Main(){
    Console.WriteLine(" Enter number upto which you want to print fibonacii");
    int num = Convert.ToInt32(Console.ReadLine());
    Fibonacci(num);
}
}
