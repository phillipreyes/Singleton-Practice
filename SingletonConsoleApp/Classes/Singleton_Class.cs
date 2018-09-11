using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Classes
{
   public sealed class  Singleton_Class
    {
        private int incr;
        private string str;
        private static Singleton_Class single;
        private Singleton_Class()
        {
            

        }
        public static Singleton_Class GetReference()
        {
            if(single == null)
            {
                single = new Singleton_Class();
                Console.WriteLine("intaintiate object");
            }

            return single; 
        }
        public void printSingleton()
        {
            Console.WriteLine("Inside Singleton");
        }

    }
     
}
