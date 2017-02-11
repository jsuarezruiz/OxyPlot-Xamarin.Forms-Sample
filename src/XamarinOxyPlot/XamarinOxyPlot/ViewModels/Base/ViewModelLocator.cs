using Microsoft.Practices.Unity;
using XamarinOxyPlot.Services.Navigation;

namespace XamarinOxyPlot.ViewModels.Base
{
    public class ViewModelLocator
    {
        readonly IUnityContainer _container;

        public ViewModelLocator()
        {
            _container = new UnityContainer();

            // ViewModels
            _container.RegisterType<AreaViewModel>();
            _container.RegisterType<BarViewModel>();
            _container.RegisterType<ColumnViewModel>();
            _container.RegisterType<FunctionViewModel>();
            _container.RegisterType<HeatMapViewModel>();
            _container.RegisterType<LineViewModel>();
            _container.RegisterType<MainViewModel>();
            _container.RegisterType<PieViewModel>();
            _container.RegisterType<ScatterViewModel>();
            _container.RegisterType<StackBarViewModel>();
            _container.RegisterType<VolumeViewModel>();

            // Services     
            _container.RegisterType<INavigationService, NavigationService>();
        }
        public AreaViewModel AreaViewModel
        {
            get { return _container.Resolve<AreaViewModel>(); }
        }

        public BarViewModel BarViewModel
        {
            get { return _container.Resolve<BarViewModel>(); }
        }

        public ColumnViewModel ColumnViewModel
        {
            get { return _container.Resolve<ColumnViewModel>(); }
        }

        public FunctionViewModel FunctionViewModel
        {
            get { return _container.Resolve<FunctionViewModel>(); }
        }

        public HeatMapViewModel HeatMapViewModel
        {
            get { return _container.Resolve<HeatMapViewModel>(); }
        }

        public PieViewModel PieViewModel
        {
            get { return _container.Resolve<PieViewModel>(); }
        }

        public LineViewModel LineViewModel
        {
            get { return _container.Resolve<LineViewModel>(); }
        }

        public MainViewModel MainViewModel
        {
            get { return _container.Resolve<MainViewModel>(); }
        }

        public ScatterViewModel ScatterViewModel
        {
            get { return _container.Resolve<ScatterViewModel>(); }
        }

        public StackBarViewModel StackBarViewModel
        {
            get { return _container.Resolve<StackBarViewModel>(); }
        }

        public VolumeViewModel VolumeViewModel
        {
            get { return _container.Resolve<VolumeViewModel>(); }
        }
    }
}
