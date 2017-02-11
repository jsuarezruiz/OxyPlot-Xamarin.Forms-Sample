using Xamarin.Forms;
using XamarinOxyPlot.ViewModels;

namespace XamarinOxyPlot.Views
{
    public partial class ScatterView : ContentPage
    {
        public object Parameter { get; set; }

        public ScatterView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = App.Locator.ScatterViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var scatterViewModel = BindingContext as ScatterViewModel;
            if (scatterViewModel != null) scatterViewModel.OnAppearing(Parameter);
        }
    }
}