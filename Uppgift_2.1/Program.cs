﻿using System;

namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken är din favoritbok?");
            string favoritbok = Console.ReadLine();
            Console.WriteLine("Din favorit bok är: " + favoritbok);
            Console.ReadKey();
        }
    }
}
