using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinAppExam.Model;
using XamarinAppExam.Services;
using XamarinAppExam.Views;

namespace XamarinAppExam.ViewModel
{
    public class BetPlayViewModel : BaseViewModel
    {
        private ObservableCollection<BetPlay> books;
        private BetPlay selectedBook;
        private readonly IBetPlayService _bookService;

        public BetPlayViewModel(IBetPlayService bookService)
        {
            _bookService = bookService;

            Books = new ObservableCollection<BetPlay>();

            DeleteBookCommand = new Command<BetPlay>(async b => await DeleteBook(b));

            AddNewBookCommand = new Command(async () => await GoToAddbookView());
        }

        private async Task DeleteBook(BetPlay b)
        {
            await _bookService.DeleteBook(b);

            PopulateBooks();
        }

        private async Task GoToAddbookView()
            => await Shell.Current.GoToAsync(nameof(AddBook));

        public async void PopulateBooks()
        {
            try
            {
                Books.Clear();

                var books = await _bookService.GetBooks();
                foreach (var book in books)
                {
                    Books.Add(book);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        async void OnBookSelected(BetPlay book)
        {
            if (book == null)
                return;

            await Shell.Current.GoToAsync($"{nameof(BookDetails)}?{nameof(BetPlayDetailsViewModel.BookId)}={book.Id}");
        }

        public ObservableCollection<BetPlay> Books
        {
            get => books;
            set
            {
                books = value;
                OnPropertyChanged(nameof(Books));
            }
        }

        public BetPlay SelectedBook
        {
            get => selectedBook;
            set
            {
                if (selectedBook != value)
                {
                    selectedBook = value;

                    OnBookSelected(SelectedBook);
                }
            }
        }

        public ICommand DeleteBookCommand { get; }

        public ICommand AddNewBookCommand { get; }
    }
}
