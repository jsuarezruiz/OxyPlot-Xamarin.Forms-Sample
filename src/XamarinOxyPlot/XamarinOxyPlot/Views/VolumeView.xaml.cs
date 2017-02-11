using Xamarin.Forms;
using XamarinOxyPlot.ViewModels;

namespace XamarinOxyPlot.Views
{
    public partial class VolumeView : ContentPage
    {
        public object Parameter { get; set; }

        public VolumeView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = App.Locator.VolumeViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var volumeViewModel = BindingContext as VolumeViewModel;
            if (volumeViewModel != null) volumeViewModel.OnAppearing(Parameter);
        }
    }
}
