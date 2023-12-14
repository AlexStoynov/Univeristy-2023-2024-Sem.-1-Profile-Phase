using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class StreamingMusicService
    {
        private string name;
        private List<User> users;

        public StreamingMusicService(string name)
        {
            this.name = name;
            this.users = new List<User>();
        }

        public void AddUser(string name, string email)
        {
            User newUser = new User(name, email);
            users.Add(newUser);
        }

        public void RemoveUser(string name)
        {
            User user = users.FirstOrDefault(x => x.GetUserName() == name);

            if (user != null)
            {
                this.users.Remove(user);
            }
            else
            {
                throw new ArgumentException("User not found.");
            }
        }

        public List<User> GetUsers()
        {
            return this.users.ToList();
        }

        public string GetInfo()
        {
            return $"Streaming Music service: {this.name} ({this.users.Count} users)";
        }
    }
}
