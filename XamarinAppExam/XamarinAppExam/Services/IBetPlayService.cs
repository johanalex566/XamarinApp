using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinAppExam.Model;

namespace XamarinAppExam.Services
{
    public interface IBetPlayService
    {
        Task<IEnumerable<BetPlay>> GetBooks();
        Task<BetPlay> GetBook(int id);
        Task AddBook(BetPlay book);
        Task SaveBook(BetPlay book);
        Task DeleteBook(BetPlay book);

    }
}
