using OxyPlot;
using OxyPlot.Series;
using System;
using XamarinOxyPlot.ViewModels.Base;

namespace XamarinOxyPlot.ViewModels
{
    public class ScatterViewModel : ViewModelBase
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
                Title = "Scatter"
            };

            var scatterSerie = new ScatterSeries
            {
                MarkerType = MarkerType.Circle
            };

            var r = new Random(100);
            for (int i = 0; i < 100; i++)
            {
                var x = r.NextDouble();
                var y = r.NextDouble();
                var size = r.Next(5, 15);
                var colorValue = r.Next(100, 1000);
                scatterSerie.Points.Add(new ScatterPoint(x, y, size, colorValue));
            }

            PlotModel.Series.Add(scatterSerie);
        }
    }
}
