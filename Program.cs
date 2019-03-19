
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
   delegate void Operation(int num);

   // delegate int Operation(int num);

    class Program
    {
        static void Main(string[] args)

        {
            
 //            Operation op = Double;
 //            op(2);



  //          Operation op = delegate(int num) { Console.WriteLine("{0} x 2 = {1}", num, num * 2);

   //             op(2);

            Operation op=num =>
            {
                Console.WriteLine("{0} x 2 = {1}", num, num * 2);     

                // return num *2;
            };
          //  int value = op(2);
  
          
            op(2);

           // Console.WriteLine(value);
           Console.ReadLine();


        }

  //      static void Double(int num)
  //      {
  

  //      }
    }
}
