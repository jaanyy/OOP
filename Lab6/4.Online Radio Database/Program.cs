using System;

namespace _4.Online_Radio_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Playlist playlist = new Playlist();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(';');

                try
                {
                    Song song = new Song(input);
                    Console.WriteLine(playlist.AddSong(song));
                }
                catch
                {
                    Console.WriteLine("Invalid song.");
                }
            }

            Console.WriteLine(playlist);
        }
    }
}
