using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinAppExam.Model;

namespace XamarinAppExam.Services
{
    public class InMemoryBetPlayService : IBetPlayService
    {
        private readonly List<BetPlay> _books = new List<BetPlay>();
        public InMemoryBetPlayService()
        {
            _books.Add(new BetPlay
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

        public Task AddBook(BetPlay book)
        {
            book.Id = ++_books.Last().Id;
            _books.Add(book);
            return Task.CompletedTask;
        }

        public Task DeleteBook(BetPlay book)
        {
            _books.Remove(book);
            return Task.CompletedTask;
        }

        public Task<BetPlay> GetBook(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            return Task.FromResult(book);
        }

        public Task<IEnumerable<BetPlay>> GetBooks()
        {
            return Task.FromResult(_books.AsEnumerable());
        }

        public Task SaveBook(BetPlay book)
        {
            _books[_books.FindIndex(b => b.Id == book.Id)] = book;
            return Task.CompletedTask;
        }
    }
}
