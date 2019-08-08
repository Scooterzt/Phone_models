using System;

namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Phone App");
            Galaxy Note10 = new Galaxy("Note10", 85, "T-Mobile", "Dooo do doo dooo");
            Nokia el11 = new Nokia("\01100", 60, "Metro PCS", "Ringgg Ringggggg");
            Console.WriteLine("\01111");
            Note10.DisplayInfo();
            Console.WriteLine(Note10.Ring());
            Console.WriteLine(el11.Unlock());
            el11.DisplayInfo();
        }
    }
}
