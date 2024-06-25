using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10_17_06_2024
{
    internal class Book
    {

        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Book()
        {
            Name = "NoName";
            Author = "NoAuthor";
            Date = DateTime.Now;
            Description = "NoDescription";
        }
        public Book(string name)
        {
            Name = name;
            Author = "NoAuthor";
            Description = "NoDescription";
        }
        public Book(string name,string author)
        {
            Name = name;
            Author = author;
            Description = "NoDescription";
        }
        public Book(string name, string author,string description)
        {
            Name = name;
            Author = author;
            Description = description;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAuthor {Author}\nDescription: {Description}";
        }
    }
}
