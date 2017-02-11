using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinOxyPlot.ViewModels;
using XamarinOxyPlot.Views;

namespace XamarinOxyPlot.Services.Navigation
{
    public class NavigationService : INavigationService
    {
        private IDictionary<Type, Type> viewModelRouting = new Dictionary<Type, Type>()
        {
            { typeof(AreaViewModel), typeof(AreaView) },
            { typeof(BarViewModel), typeof(BarView) },
            { typeof(ColumnViewModel), typeof(ColumnView) },
            { typeof(FunctionViewModel), typeof(FunctionView) },
            { typeof(HeatMapViewModel), typeof(HeatMapView) },
            { typeof(LineViewModel), typeof(LineView) },
            { typeof(PieViewModel), typeof(PieView) },
            { typeof(ScatterViewModel), typeof(ScatterView) },
            { typeof(StackBarViewModel), typeof(StackBarView) },
            { typeof(VolumeViewModel), typeof(VolumeView) }
        };

        public void NavigateTo<TDestinationViewModel>(object navigationContext = null)
        {
            Type pageType = viewModelRouting[typeof(TDestinationViewModel)];
            var page = Activator.CreateInstance(pageType, navigationContext) as Page;

            if (page != null)
                Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public void NavigateTo(Type destinationType, object navigationContext = null)
        {
            Type pageType = viewModelRouting[destinationType];
            var page = Activator.CreateInstance(pageType, navigationContext) as Page;

            if (page != null)
                Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public void NavigateBack()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}