using System;
using System.Collections.Generic;
using System.Text;

namespace katapotter
{
    public class Book
    {
        public int Price { get; set; }
        public string name { get; set; }

        public Book(string name)
        {
            this.Price = 8;
            this.name = name;
            
        }

    }
}
