using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinAppExam.Model;

namespace XamarinAppExam.Services
{
    public class InMemoryBookService : IBookService
    {
        private readonly List<Book> _books = new List<Book>();
        public InMemoryBookService()
        {
            _books.Add(new Book
            {
                documentId = "1245",
                Name = " Ejemplo Pepito",
                Date = DateTime.Now,
                StakeValue = 25,
                GainValue =100,
                Deduction = 10,
                TotalPayable = 85
            });
        }

        public Task AddBook(Book book)
        {
            book.Id = ++_books.Last().Id;
            _books.Add(book);
            return Task.CompletedTask;
        }

        public Task DeleteBook(Book book)
        {
            _books.Remove(book);
            return Task.CompletedTask;
        }

        public Task<Book> GetBook(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            return Task.FromResult(book);
        }

        public Task<IEnumerable<Book>> GetBooks()
        {
            return Task.FromResult(_books.AsEnumerable());
        }

        public Task SaveBook(Book book)
        {
            _books[_books.FindIndex(b => b.Id == book.Id)] = book;
            return Task.CompletedTask;
        }
    }
}
