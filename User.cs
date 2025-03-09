using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTalkApp
{
    internal class User
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserPassword { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Author { get; set; }

    }
}
