﻿using System;

namespace UserInterface
{
    public class UI
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Song { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UI musicInfo = new UI();

            Console.WriteLine("Enter artist:");
            musicInfo.Artist = Console.ReadLine();

            Console.WriteLine("Enter album:");
            musicInfo.Album = Console.ReadLine();

            Console.WriteLine("Enter song:");
            musicInfo.Song = Console.ReadLine();

            Console.WriteLine("\nMusic Information:");
            Console.WriteLine($"Artist: {musicInfo.Artist}");
            Console.WriteLine($"Album: {musicInfo.Album}");
            Console.WriteLine($"Song: {musicInfo.Song}");

            Console.ReadLine();
        }
    }
}
