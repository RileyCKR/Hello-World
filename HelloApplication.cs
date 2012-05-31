using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_World
{
    public class HelloApplication
    {
        private IHello Words { get; set; }

        public HelloApplication(IHello words)
        {
            this.Words = words;
        }

        public void Communicate()
        {
            Console.WriteLine(Words.Speak());
            Console.ReadLine();
        }
    }
}