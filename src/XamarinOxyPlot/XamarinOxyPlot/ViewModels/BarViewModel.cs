using OxyPlot;
using OxyPlot.Series;
using XamarinOxyPlot.ViewModels.Base;

namespace XamarinOxyPlot.ViewModels
{
    public class BarViewModel : ViewModelBase
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
                Title = "Bar"
            };

            var barSerie = new BarSeries
            {
                StrokeThickness = 2.0
            };

            barSerie.Items.Add(new BarItem(1));
            barSerie.Items.Add(new BarItem(2));
            barSerie.Items.Add(new BarItem(3));
            barSerie.Items.Add(new BarItem(4));
            barSerie.Items.Add(new BarItem(5));

            PlotModel.Series.Add(barSerie);
        }
    }
}
