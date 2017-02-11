using System.Windows.Input;
using XamarinOxyPlot.Services.Navigation;
using XamarinOxyPlot.ViewModels.Base;

namespace XamarinOxyPlot.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ICommand _areaCommand;
        private ICommand _barCommand;
        private ICommand _columnCommand;
        private ICommand _functionCommand;
        private ICommand _heatMapCommand;
        private ICommand _lineCommand;
        private ICommand _pieCommand;
        private ICommand _scatterCommand;
        private ICommand _stackBarCommand;
        private ICommand _volumeCommand;

        private INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand AreaCommand
        {
            get { return _areaCommand = _areaCommand ?? new DelegateCommand(AreaCommandExecute); }
        }

        public ICommand BarCommand
        {
            get { return _barCommand = _barCommand ?? new DelegateCommand(BarCommandExecute); }
        }

        public ICommand ColumnCommand
        {
            get { return _columnCommand = _columnCommand ?? new DelegateCommand(ColumnCommandExecute); }
        }

        public ICommand FunctionCommand
        {
            get { return _functionCommand = _functionCommand ?? new DelegateCommand(FunctionCommandExecute); }
        }

        public ICommand HeatMapCommand
        {
            get { return _heatMapCommand = _heatMapCommand ?? new DelegateCommand(HeatMapCommandExecute); }
        }

        public ICommand LineCommand
        {
            get { return _lineCommand = _lineCommand ?? new DelegateCommand(LineCommandExecute); }
        }

        public ICommand PieCommand
        {
            get { return _pieCommand = _pieCommand ?? new DelegateCommand(PieCommandExecute); }
        }

        public ICommand ScatterCommand
        {
            get { return _scatterCommand = _scatterCommand ?? new DelegateCommand(ScatterCommandExecute); }
        }

        public ICommand StackBarCommand
        {
            get { return _stackBarCommand = _stackBarCommand ?? new DelegateCommand(StackBarCommandExecute); }
        }

        public ICommand VolumeCommand
        {
            get { return _volumeCommand = _volumeCommand ?? new DelegateCommand(VolumeCommandExecute); }
        }

        private void AreaCommandExecute()
        {
            _navigationService.NavigateTo<AreaViewModel>();
        }

        private void BarCommandExecute()
        {
            _navigationService.NavigateTo<BarViewModel>();
        }

        private void ColumnCommandExecute()
        {
            _navigationService.NavigateTo<ColumnViewModel>();
        }

        private void FunctionCommandExecute()
        {
            _navigationService.NavigateTo<FunctionViewModel>();
        }

        private void HeatMapCommandExecute()
        {
            _navigationService.NavigateTo<HeatMapViewModel>();
        }

        private void LineCommandExecute()
        {
            _navigationService.NavigateTo<LineViewModel>();
        }

        private void PieCommandExecute()
        {
            _navigationService.NavigateTo<PieViewModel>();
        }

        private void ScatterCommandExecute()
        {
            _navigationService.NavigateTo<ScatterViewModel>();
        }

        private void StackBarCommandExecute()
        {
            _navigationService.NavigateTo<StackBarViewModel>();
        }

        private void VolumeCommandExecute()
        {
            _navigationService.NavigateTo<VolumeViewModel>();
        }
    }
}
