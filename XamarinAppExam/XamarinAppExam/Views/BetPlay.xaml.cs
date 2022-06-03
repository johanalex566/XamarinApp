
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAppExam.ViewModel;

namespace XamarinAppExam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Books : ContentPage
    {
        private readonly BetPlayViewModel _booksViewModel;
        public Books()
        {
            InitializeComponent();

            _booksViewModel = Startup.Resolve<BetPlayViewModel>();
            BindingContext = _booksViewModel;
        }
        protected override void OnAppearing()
        {
            _booksViewModel?.PopulateBooks();
        }
    }
}