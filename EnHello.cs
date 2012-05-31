using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_World
{
    public class EnHello : IHello
    {
        public void Speak()
        {
            Console.WriteLine("Hello World!");
        }
    }
}