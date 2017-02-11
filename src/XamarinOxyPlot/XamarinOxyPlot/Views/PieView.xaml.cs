using Xamarin.Forms;
using XamarinOxyPlot.ViewModels;

namespace XamarinOxyPlot.Views
{
    public partial class PieView : ContentPage
    {
        public object Parameter { get; set; }

        public PieView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = App.Locator.PieViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var pieViewModel = BindingContext as PieViewModel;
            if (pieViewModel != null) pieViewModel.OnAppearing(Parameter);
        }
    }
}
