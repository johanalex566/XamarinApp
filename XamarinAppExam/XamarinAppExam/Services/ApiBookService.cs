using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using XamarinAppExam.Model;

namespace XamarinAppExam.Services
{
    public class ApiBookService : IBookService
    {
        private readonly HttpClient _httpClient;

        public ApiBookService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<BetPlay>> GetBooks()
        {
            var response = await _httpClient.GetAsync("Books");

            response.EnsureSuccessStatusCode();

            var responseAsString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<BetPlay>>(responseAsString);
        }

        public async Task<BetPlay> GetBook(int id)
        {
            var response = await _httpClient.GetAsync($"Books/{id}");

            response.EnsureSuccessStatusCode();

            var responseAsString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<BetPlay>(responseAsString);
        }

        public async Task AddBook(BetPlay book)
        {
            var response = await _httpClient.PostAsync("Books",
                new StringContent(JsonSerializer.Serialize(book), Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteBook(BetPlay book)
        {
            var response = await _httpClient.DeleteAsync($"Books/{book.Id}");

            response.EnsureSuccessStatusCode();
        }

        public async Task SaveBook(BetPlay book)
        {
            var response = await _httpClient.PutAsync($"Books?id={book.Id}",
                new StringContent(JsonSerializer.Serialize(book), Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();
        }
    }
}
