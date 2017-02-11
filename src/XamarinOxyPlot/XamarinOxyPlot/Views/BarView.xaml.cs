using Xamarin.Forms;
using XamarinOxyPlot.ViewModels;

namespace XamarinOxyPlot.Views
{
    public partial class BarView : ContentPage
    {
        public object Parameter { get; set; }

        public BarView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = App.Locator.BarViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var barViewModel = BindingContext as BarViewModel;
            if (barViewModel != null) barViewModel.OnAppearing(Parameter);
        }
    }
}
