using OxyPlot;
using OxyPlot.Series;
using XamarinOxyPlot.ViewModels.Base;

namespace XamarinOxyPlot.ViewModels
{
    public class AreaViewModel : ViewModelBase
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
                Title = "Area"
            };

            var areaSerie = new AreaSeries
            {
                StrokeThickness = 2.0
            };

            areaSerie.Points.Add(new DataPoint(0, 50));
            areaSerie.Points.Add(new DataPoint(10, 60));
            areaSerie.Points.Add(new DataPoint(20, 140));
            areaSerie.Points2.Add(new DataPoint(0, 50));
            areaSerie.Points2.Add(new DataPoint(5, 70));
            areaSerie.Points2.Add(new DataPoint(15, 60));

            PlotModel.Series.Add(areaSerie);
        }
    }
}