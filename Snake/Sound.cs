using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace Snake
{
    class Sound
    {
        SoundPlayer snd;
        public void gameOverSound()
        {
            SoundPlayer snd = new SoundPlayer(@"C:\Users\USER\Documents\Visual Studio 2017\Projects\Snake\Snake\sound\over.wav");
            snd.Play();
        }
    }
}
