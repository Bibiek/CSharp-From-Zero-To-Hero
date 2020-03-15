using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_1YAY
{
    class Program
    {
        static void Main(string[] args)
        {
            //name
            Console.WriteLine("Hello sir please insert your name: ");
            string name = Console.ReadLine();
            Console.Clear();
            //family name
            Console.WriteLine("Hello sir please insert your family name: ");
            string family = Console.ReadLine();
            Console.Clear();
            //age
            Console.WriteLine("Hello sir please insert your age: ");
            string age = Console.ReadLine();
            Console.Clear();
            //hight
            Console.WriteLine("Hello sir please tell me how tall are you : ");
            Double high =Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            //weight
            Console.WriteLine("Hello sir please tell me how heavy are you : ");
            Double weight =Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            //ibm calc
            Double ibm = (weight / ((high * high) / 10000));
            //if
            if (ibm > 100)
            {
                Console.WriteLine("So "  +   name   + " ! Since you are only  " + age + " ...... How did yo gain so much weight? Thats over " +  weight  + " kg!!!! Your ibm is " +  ibm  + " !!  How are you so fat?");

            }
            else
            {
                Console.WriteLine("So " + name + " ! You are " + age + " and your bim is " + ibm + " Have a nice day!!!");


            }







            Console.ReadLine();




        }
        




    }
}
