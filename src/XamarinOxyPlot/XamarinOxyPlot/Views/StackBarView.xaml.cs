using Xamarin.Forms;
using XamarinOxyPlot.ViewModels;

namespace XamarinOxyPlot.Views
{
    public partial class StackBarView : ContentPage
    {
        public object Parameter { get; set; }

        public StackBarView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = App.Locator.StackBarViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var stackBarViewModel = BindingContext as StackBarViewModel;
            if (stackBarViewModel != null) stackBarViewModel.OnAppearing(Parameter);
        }
    }
}
