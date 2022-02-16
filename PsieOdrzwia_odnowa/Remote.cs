using System;
using System.Collections.Generic;
using System.Text;

namespace PsieDrzwi_odnowa
{
    
    class Remote
    {
        DogDoor door;

        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public void PressButton(DogDoor door)
        {
            if (door.IsOpen())
            door.Close();

            else door.Open();
        }
    }
}
