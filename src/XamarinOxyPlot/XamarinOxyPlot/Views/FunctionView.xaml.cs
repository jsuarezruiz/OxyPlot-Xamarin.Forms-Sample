using Xamarin.Forms;
using XamarinOxyPlot.ViewModels;

namespace XamarinOxyPlot.Views
{
    public partial class FunctionView : ContentPage
    {
        public object Parameter { get; set; }

        public FunctionView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = App.Locator.FunctionViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var functionViewModel = BindingContext as FunctionViewModel;
            if (functionViewModel != null) functionViewModel.OnAppearing(Parameter);
        }
    }
}
