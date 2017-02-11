using Xamarin.Forms;
using XamarinOxyPlot.ViewModels;

namespace XamarinOxyPlot.Views
{
    public partial class ColumnView : ContentPage
    {
        public object Parameter { get; set; }

        public ColumnView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = App.Locator.ColumnViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var columnViewModel = BindingContext as ColumnViewModel;
            if (columnViewModel != null) columnViewModel.OnAppearing(Parameter);
        }
    }
}