using OxyPlot;
using OxyPlot.Series;
using XamarinOxyPlot.ViewModels.Base;

namespace XamarinOxyPlot.ViewModels
{
    public class VolumeViewModel : ViewModelBase
    {
        private PlotModel _plotModel;

        public PlotModel PlotModel
        {
            get { return _plotModel; }
            set
            {
                _plotModel = value;
                RaisePropertyChanged();
            }
        }

        public override void OnAppearing(object navigationContext)
        {
            base.OnAppearing(navigationContext);

            PlotModel = new PlotModel
            {
                Title = "Volume"
            };

            var volumeSeries = new VolumeSeries
            {
                StrokeThickness = 2.0
            };

            volumeSeries.Items.Add(new OhlcvItem(1, 20, 4, 1, 1));
            volumeSeries.Items.Add(new OhlcvItem(2, 10, 6, 1, 2));
            volumeSeries.Items.Add(new OhlcvItem(3, 50, 3, 1, 0.5));

            PlotModel.Series.Add(volumeSeries);
        }
    }
}
