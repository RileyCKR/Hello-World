using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_World
{
    public class HelloApplication
    {
        private IHello Words { get; set; }
        private IVoice Voice { get; set; }
        public HelloApplication(IHello words, IVoice voice)
        {
            this.Words = words;
            this.Voice = voice;
        }

        public void Communicate()
        {
            Voice.Communicate(Words.Speak());
        }
    }
}