using Xamarin.Forms;

namespace XF35BindFlexLayoutIssue
{
    public partial class MainPage : ContentPage
    {
        private readonly ViewModel vm = new ViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            vm.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            vm.OnDisappearing();
        }
    }
}
