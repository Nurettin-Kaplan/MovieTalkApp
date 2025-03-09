﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTalkApp
{
    internal class Movie
    {
        public int Id { get; set; }
        public string PosterImage { get; set; }
        public string Title { get; set; }
        public string MovieDescription { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
    }
}
