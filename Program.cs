namespace HW_10_17_06_2024
{
//    Створіть додаток для обліку книг, який зберігатиме наступну
//інформацію:
// назва книги;
// П.І.Б.автора;
// жанр книги;
// рік видання.
//Для зберігання даних про книги використовуйте клас
//LinkedList<T>.
//Додаток має надавати таку функціональність:
// додавати книги;+
// видаляти книги;+
// змінювати інформацію про книги;+
// пошук книг за параметрами;+
// вставити книги у початок списку;+
// вставити книги у кінець списку;+
// вставити книги у певну позицію;+
// видалити книги з початку списку;+
// видалити книги з кінця списку;+
// видалити книги з певної позиції.+
    internal class Program
    {
        static void Main(string[] args)
        {
          BookAccounting bookAccounting = new BookAccounting();
            bookAccounting.AddBookToBegin("bob","A1","asd");
            bookAccounting.AddBookToBegin("bob", "A2", "asd");
            bookAccounting.AddBookToBegin("bobfg", "A2", "asd");
            bookAccounting.ShowBooks();
            Console.WriteLine("====================");
            bookAccounting.DelBookInBegin();
            bookAccounting.ShowBooks();
            Console.WriteLine("====================");
            bookAccounting.DelBookInEnd();
            bookAccounting.ShowBooks();
            Console.WriteLine("====================");
            bookAccounting.AddBookToBegin("Book1", "A2", "asd");
            bookAccounting.AddBookToBegin("Book2", "A3", "asd");
            bookAccounting.AddBookToBegin("Book3", "A4", "asd");
            bookAccounting.ShowBooks();
            Console.WriteLine("====================");
            Console.WriteLine("Search book: \n{0}",bookAccounting.SearchBookByName("Book2")); // TODO


        }
    }
}
