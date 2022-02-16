using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PsieDrzwi_odnowa
{
    class DogDoor
    {
        bool open;
        List<Bark> allowedBarks = new List<Bark>();
        
        //czym powyzszy zapis rozni sie od tego --> List<Bark> allowedBarks;  ??
        public DogDoor()
        {
            this.open = false;
            //this.allowedBarks = null;
        }

        public void Open()
        {
            this.open = true;
            Console.WriteLine("Drzwi otworzyły się.");
            Thread t = new Thread(new ThreadStart(DoorCloseDelay));
            t.Start();
            

             
        }
        public void Close()
        {
            this.open = false;
            Console.WriteLine("Drzwi zamkneły się.");
        }

        public bool IsOpen()
        {
            return open;
        }

        public void AddAllowedBark(Bark bark)
        {
            allowedBarks.Add(bark);
        }

        public List<Bark> GetAllowedBarks()
        {
            return allowedBarks;
        }

        void DoorCloseDelay()
        {
            Thread.Sleep(2000);
            Close();
        }
    }
    

}
