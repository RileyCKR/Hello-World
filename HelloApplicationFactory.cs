using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_World
{
    public class HelloApplicationFactory
    {
        public HelloApplication Build()
        {
            IHello words = new EnHello();
            IVoice voice = new ConsoleVoice();
            HelloApplication app = new HelloApplication(words, voice);
            return app;
        }
    }
}