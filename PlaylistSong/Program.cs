using System;
using MusicPlaylist;
using StreamModel;
namespace PlaylistSong
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> artistSongs = ArtistSong.InitializeArtistSongs();

            Console.WriteLine("Enter an Artist Name to Search:");
            string artistName = Console.ReadLine();


            FindAndDisplaySongs(artistName, artistSongs);
        }

        public static void FindAndDisplaySongs(string artistName, Dictionary<string, string[]> artistSongs)
        {
            bool artistFound = false;


            foreach (var artist in artistSongs)
            {
                if (artist.Key == artistName)
                {
                    artistFound = true;
                    DisplaySongs(artistName, artist.Value);
                    break;
                }
            }

            if (!artistFound)
            {
                Console.WriteLine($"Artist '{artistName}' not found.");
            }
        }

        public static void DisplaySongs(string artistName, string[] songs)
        {

            Console.WriteLine($"\nSongs by {artistName}:");
            foreach (var song in songs)
            {
                Console.WriteLine($"- {song}");
            }
        }
    }
}
