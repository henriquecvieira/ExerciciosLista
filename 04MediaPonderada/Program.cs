using System;

namespace _04MediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada mp = new MediaPonderada();
            mp.p1 = 9.5;
            mp.p2 = 8.2;
            mp.x1 = 5.5;
            mp.x2 = 10;

            mp.messageMediaPonderada();
        }
    }
}