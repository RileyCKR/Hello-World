using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            hello.Speak();
            Console.ReadLine();
        }
    }
}