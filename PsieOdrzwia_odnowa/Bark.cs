using System;
using System.Collections.Generic;
using System.Text;

namespace PsieDrzwi_odnowa
{
    class Bark
    {
        string sound;

        public Bark(string bark)
        {
            this.sound = bark;
        }

        public string GetSound()
        {
            return sound;
        }

        public bool Equals(Bark bark)
        {
            if ((string.Compare(this.sound, bark.sound, true))==0 )
            {
                return true;
            }
            return false;
        }
    }
}
