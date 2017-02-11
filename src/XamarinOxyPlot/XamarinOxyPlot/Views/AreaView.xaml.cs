using Xamarin.Forms;
using XamarinOxyPlot.ViewModels;

namespace XamarinOxyPlot.Views
{
    public partial class AreaView : ContentPage
    {
        public object Parameter { get; set; }

        public AreaView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = App.Locator.AreaViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var areaViewModel = BindingContext as AreaViewModel;
            if (areaViewModel != null) areaViewModel.OnAppearing(Parameter);
        }
    }
}