using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_World
{
    public class FrHello : IHello
    {
        public string Speak()
        {
            return "Bounjour Monde!";
        }
    }
}