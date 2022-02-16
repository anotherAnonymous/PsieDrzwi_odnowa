using System;
using System.Collections.Generic;
using System.Text;

namespace PsieDrzwi_odnowa
{
    class BarkRecognizer
    {
        DogDoor door;
        Remote remote;
        public BarkRecognizer(DogDoor door, Remote remote)
        {
            this.door = door;
            this.remote = remote;
        }

        public void Recognize(Bark tempBark)
        {
            bool state=false;

            Console.WriteLine($"\nBarkRecognizer: usłyszano "+"'"+tempBark.GetSound()+"'");

            foreach (Bark bark in this.door.GetAllowedBarks())
            {
                if (!bark.Equals(tempBark) == true)
                {
                    state = true;
                    continue;
                }


                else remote.PressButton(door);
                state = false;
                break; 
                   
            }

            if (state==true)
            {
                Console.WriteLine("Ten pies nie moze wejść");
            }
            
        }    
    }
}
