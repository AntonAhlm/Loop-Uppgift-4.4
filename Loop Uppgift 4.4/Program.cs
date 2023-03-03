using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett av följande alternativ: \n" +
                "1. Subtrahera ett tal med ett annat \n" +
                "2. Dividera ett tal med ett annat \n" +
                "3. Avsluta programmet");
            string val = Console.ReadLine();

            switch(val)
            {
                case "1":
                    {
                        Console.Write("Tal 1 : ");
                        int tal1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Tal 2 : ");
                        int tal2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(tal1 + " - " + tal2 + " = " + (tal1 - tal2));
                      
                        break;
                    }

                case "2":
                    {
                        Console.Write("Tal 1 : ");
                        int tal1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Tal 2 : ");
                        int tal2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(tal1 + " / " + tal2 + " = " + (tal1 / tal2));
                        
                        break;
                    }
                case "3":
                    {
                        break;
                    }

            }


        }
    }
}
