﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject
{
    class Book
    {
        public int idbooks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public int DateCreate { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
