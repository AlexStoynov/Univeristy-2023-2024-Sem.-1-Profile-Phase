using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class User
    {
        private const int maxSongsInFavs = 50;
        private string name;
        private string email;
        private string address;
        List<Song> favouriteSongs;

        public User(string name, string email)
        {
            this.name = name;
            this.email = email;
            favouriteSongs = new List<Song>();
        }

        public User(string name, string email, string address)
        {
            this.name = name;
            this.email = email;
            this.address = address;
            favouriteSongs = new List<Song>();
        }

        public void AddSongToFavourites(Song song)
        {
            if (favouriteSongs.Count() < maxSongsInFavs)
            {
                favouriteSongs.Add(song);
            }
            else
            {
                throw new ArgumentException("Favourite songs cannot be more than 50!");
            }
        }

        public void RemoveSongFromFavourites(string songTitle)
        {
            Song song = favouriteSongs.FirstOrDefault(x => x.GetTitle() == songTitle);

            if (song == null)
            {
                throw new ArgumentException("Song not found.");
            }

            favouriteSongs.Remove(song);
        }

        public string GetUserName()
        {
            return name;
        }
        public string GetFavouriteSongs()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Favourite songs of {this.name}:");
            if (favouriteSongs != null)
            {
                foreach (Song song in favouriteSongs)
                {
                    sb.AppendLine($"- {song.GetInfo()}");
                }
            }
            else
            {
                return $"{this.name} has no favourite songs";
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            if(string.IsNullOrEmpty(this.address))
            {
                return $"User - {this.name} with e-mail {this.email}.";
            }

            return $"User - {this.name} with e-mail {this.email} and address {this.address}.";
        }
    }
}
