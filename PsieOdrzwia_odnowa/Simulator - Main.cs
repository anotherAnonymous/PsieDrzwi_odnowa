using System;
using System.Threading;


namespace PsieDrzwi_odnowa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Symulator
            DogDoor door = new DogDoor();
            door.AddAllowedBark(new Bark("Hrau"));
            door.AddAllowedBark(new Bark("Hrauu"));
            door.AddAllowedBark(new Bark("Hrauuu"));
            door.AddAllowedBark(new Bark("Hrauuuu"));
            door.AddAllowedBark(new Bark("Hrauuuuu"));
            Remote remote = new Remote(door); ;
            BarkRecognizer recognizer = new BarkRecognizer(door, remote);
            

            //Symulujemy "usłyszenie" szczekania przez system
            Console.WriteLine("Brus zaczyna szczekac.");
            recognizer.Recognize(new Bark("hrau"));

            Console.WriteLine("\nBrus wyszedł na zewnątrz");
            Thread.Sleep(3000);
            Console.WriteLine("\nBrus załatwił swoje potrzeby");
            Console.WriteLine("\n...ale utknął na zewnątrz");
            Thread.Sleep(2000);
            //Symulujemy szczekania innego psa
            Bark smallDog = new Bark("hiaaaauuu");
            Console.WriteLine("\nMały pies zaczął szczekać");
            recognizer.Recognize(smallDog);
            Thread.Sleep(2000);

            //Symulujemy szczekanie psa właściciela
            Console.WriteLine("\nBrus zaczyna szczekać");
            recognizer.Recognize(new Bark("hrauuuuu"));
            Console.WriteLine("\nBrus znowu jest w domu");
            Console.ReadKey();
        }
    }
}
