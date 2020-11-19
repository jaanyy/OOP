using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Online_Radio_Database
{
    class Song
    {
        private string name;
        private string artist;
        private int minutes;
        private int seconds;

        public Song(string[] tokens)
        {
            ValidateArgs(tokens);
            Artist = tokens[0];
            Name = tokens[1];
            int[] lengthArgs = ValidateLength(tokens[2]);
            Minutes = lengthArgs[0];
            Seconds = lengthArgs[1];
        }

        private string Name
        {
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new Exception("Song name should be between 3 and 30 symbols.");
                }

                name = value;
            }
        }

        private string Artist
        {
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new Exception("Artist name should be between 3 and 20 symbols.");
                }

                artist = value;
            }
        }

        private int Minutes
        {
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new Exception("Song minutes should be between 0 and 14.");
                }

                minutes = value;
            }
        }

        private int Seconds
        {
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new Exception("Invalid song.");
                }

                seconds = value;
            }
        }

        private void ValidateArgs(string[] tokens)
        {
            if (tokens.Length != 3)
            {
                throw new Exception("Invalid song.");
            }
        }

        private int[] ValidateLength(string length)
        {
            var tokens = length.Split(':');
            if (tokens.Length != 2 || tokens.Any(t => !t.All(c => Char.IsDigit(c))))
            {
                throw new Exception("Invalid song length.");
            }

            return tokens.Select(int.Parse).ToArray();
        }

        public int GetLengthInSeconds()
        {
            return minutes * 60 + seconds;
        }
    }
}
