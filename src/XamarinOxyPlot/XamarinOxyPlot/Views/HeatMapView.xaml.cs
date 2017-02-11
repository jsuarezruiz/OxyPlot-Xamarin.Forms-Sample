using Xamarin.Forms;
using XamarinOxyPlot.ViewModels;

namespace XamarinOxyPlot.Views
{
    public partial class HeatMapView : ContentPage
    {
        public object Parameter { get; set; }

        public HeatMapView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = App.Locator.HeatMapViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var heatMapViewModel = BindingContext as HeatMapViewModel;
            if (heatMapViewModel != null) heatMapViewModel.OnAppearing(Parameter);
        }
    }
}
