using ConsoleApplication1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton_Class.GetReference().printSingleton();
            Singleton_Class.GetReference().printSingleton();
            Singleton_Class.GetReference().printSingleton();
            Singleton_Class.GetReference().printSingleton();
        }
    }
}
