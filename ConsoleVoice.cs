using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_World
{
    public class ConsoleVoice : IVoice
    {
        public void Communicate(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}