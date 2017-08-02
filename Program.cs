using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
			
         Console.WriteLine("Please enter a number");
         var Input = Console.ReadLine();

         var number = 0;
         var isnum = int.TryParse(Input, out number);

         if(isnum){
            int count = 12;
            for (int i = 0; i <= count; i++)
            Console.WriteLine(Input + "X" +i);
            var Total = 78;
          Console.WriteLine(Input+ Total);

          
           
         }
         else{
             Console.WriteLine("Please enter a number ");
         }









			Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
