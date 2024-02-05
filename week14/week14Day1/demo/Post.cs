using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class Post
    {
        private string title;
        private string content;
        private int id = -1;
        private DateTime created = new DateTime();

        public Post(string title, string content)
        {
            this.title = title;
            this.content = content;
        }

        public Post(int id, string title, string content, DateTime createdAt)
        {
            this.id = id;
            this.title = title;
            this.content = content;
            this.created = createdAt;
        }
    }
}
