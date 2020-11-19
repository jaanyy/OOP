using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Online_Radio_Database
{
    class Playlist
    {
        private List<Song> songs = new List<Song>();

        public string AddSong(Song song)
        {
            songs.Add(song);

            return "Song added.";
        }

    }
}
