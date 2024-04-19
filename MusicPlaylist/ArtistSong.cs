using System;
using System.Collections.Generic;
using StreamModel;

namespace MusicPlaylist
{
    public class ArtistSong
    {
        public static Dictionary<string, string[]> InitializeArtistSongs()
        {

            return new Dictionary<string, string[]>
            {
                { "Coldplay", new string[] {  "Sparks", "Fix You", "Paradise", "Yellow" } },
                { "Taylor Swift", new string[] { "Slut!", "Sparks Fly", "Blank Space", "You Belong With Me", "All too Well" } },
                { "Olivia Rodrigo", new string[] { "Vampire","Drivers License", "Good 4 u", "Deja vu" } },
                { "Hev Abi", new string[] { "Alam Mo Ba","Babaero", "Marikit" } },
                { "Blackpink", new string[] { "Boombayah","Forever Young", "Whistle", "Stay" } },
                { "BTS", new string[] { "Magic","Dynamite", "Spring Day", "Not Today", "Dimple", "Home" } },
                { "Carpenters", new string[] { "Close To You","Yesterday Once More", "I won't Last A Day", "You" } },
                { "Moira", new string[] { "Kumpas","Dito ka lang", "Babalik Sayo", "Tagpuan" } }
            };
        }
    }
}
