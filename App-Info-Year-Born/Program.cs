using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
             System.Console.WriteLine("What's your name? ");
            String nome = System.Console.ReadLine();            
            System.Console.WriteLine("Now, Can you tell me how old you are? ");
            Int32 idade = Int32.Parse(System.Console.ReadLine());
            Int32 year = DateTime.Now.Year - idade;
            Console.WriteLine($"Hello World!, {nome}, and you born in {year}");
            System.Console.WriteLine("hum...I'm not sure, Please, Can you tell what month you born?");
            Int32 month = Int32.Parse(System.Console.ReadLine());
            System.Console.WriteLine("hum...I'm not sure, Please, Can you tell what day you born?");
            Int32 day = Int32.Parse(System.Console.ReadLine());

            if(DateTime.Now.Day <= day && DateTime.Now.Month <= month)
            {
               year = year - 1; 
               System.Console.WriteLine($"Ok. You born in {year}");
            }
            else
            {
                System.Console.WriteLine($"I'm right. You born in {year}");
            }
        }
    }
}
