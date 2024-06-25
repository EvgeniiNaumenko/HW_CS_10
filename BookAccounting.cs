using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace HW_10_17_06_2024
{
    internal class BookAccounting
    {
        private LinkedList<Book> _books;
        public BookAccounting()
        {
            _books = new LinkedList<Book>();
        }
        //добавить книгу пустую в начало
        public void AddBookToBegin()
        {
            _books.AddFirst(new Book());
        }
        //добавить книгу в начало+
        public void AddBookToBegin(Book book)
        {
            _books.AddFirst(book);
        }
        //добавить книгу в начало+
        public void AddBookToBegin(string name, string author, string description)
        {
            _books.AddFirst(new Book(name,author,description));
        }
        //добавить книгу в конец +
        public void AddBookToEnd()
        {
            _books.AddLast(new Book());
        }
        //добавить книгу в конец +
        public void AddBookToEnd(Book book)
        {
            _books.AddLast(book);
        }
        //добавить книгу в конец +
        public void AddBookToEnd(string name, string author, string description)
        {
            _books.AddLast(new Book(name, author, description));
        }
        //добавить книгу по позиции +
        public void InsertBookAtPosition(Book book, int position)
        {
            if (position < 0 || position > _books.Count)
            {
                throw new Exception("Not in range");
            }
            else if (position == 0)
            {
                _books.AddFirst(book);
                return;
            }
            else if (position == _books.Count)
            {
                _books.AddLast(book);
                return;
            }
            else
            {
                LinkedListNode<Book> current = _books.First;
                for (int i = 0; i < position; i++)
                {
                    current = current.Next;
                }
                _books.AddBefore(current, book);
            }
        }
        //изменить книку по книге
        public void UpdateBook(Book oldBook, Book newBook)
        {
            LinkedListNode<Book> node = _books.Find(oldBook);
            if (node != null)
            {
                node.Value = newBook;
            }
        }
        //изменить книгу
        public void ChangeBook (string oldName, string name, string author, string description)
        {
            LinkedListNode<Book> current = _books.First;
            while (current != null)
            {
                if (current.Value.Name == oldName)
                {
                    current.Value = new Book(name, author, description);
                    break;
                }
                current = current.Next;
            }
        }
        //изменить книгу +
        public void ChangeBook(string oldName, Book newBook)
        {
            LinkedListNode<Book> current = _books.First;
            while (current != null)
            {
                if (current.Value.Name==oldName)
                {
                    current.Value = newBook;
                    break;
                }
                current = current.Next;
            }
        }
        //поиск по имени
        public Book SearchBookByName (string name)
        {
            LinkedListNode<Book> current = _books.First;
            while (current != null)
            {
                if (current.Value.Name == name)
                {
                    break;
                }
                current = current.Next;
            }
            return current.Value;
        }
        //поиск по aвтору
        public Book SearchBookByAuthor (string author)
        {
            LinkedListNode<Book> current = _books.First;
            while (current != null)
            {
                if (current.Value.Author == author)
                {
                    break;
                }
                current = current.Next;
            }
            
            return current.Value;
        }
        //удалить книгу с начала
        public void DelBookInBegin()
        {
            _books.RemoveFirst();
        }
        //удалить книгу с конца
        public void DelBookInEnd()
        {
            _books.RemoveLast();
        }
        //удалить книгу по позиции
        public void DelBookInPos(int position)
        {
            if (position < 0 || position > _books.Count)
            {
                throw new Exception("Not in range");
            }
            else if (position == 0)
            {
                _books.RemoveFirst();
                return;
            }
            else if (position == _books.Count)
            {
                _books.RemoveLast();
                return;
            }
            else
            {
                LinkedListNode<Book> current = _books.First;
                for (int i = 0; i < position; i++)
                {
                    current = current.Next;
                }
                _books.Remove(current);
            }
        }
        //показать библиотеку
        public void ShowBooks()
        {
            foreach (Book book in _books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
