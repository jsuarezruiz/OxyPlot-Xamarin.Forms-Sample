using Xamarin.Forms;
using XamarinOxyPlot.ViewModels;

namespace XamarinOxyPlot.Views
{
    public partial class LineView : ContentPage
    {
        public object Parameter { get; set; }

        public LineView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = App.Locator.LineViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var lineViewModel = BindingContext as LineViewModel;
            if (lineViewModel != null) lineViewModel.OnAppearing(Parameter);
        }
    }
}
