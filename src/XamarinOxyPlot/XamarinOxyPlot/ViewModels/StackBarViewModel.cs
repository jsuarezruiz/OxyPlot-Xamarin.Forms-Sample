using OxyPlot;
using OxyPlot.Series;
using XamarinOxyPlot.ViewModels.Base;

namespace XamarinOxyPlot.ViewModels
{
    public class StackBarViewModel : ViewModelBase
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

            var barSerie1 = new BarSeries
            {
                Title = "Series 1",
                IsStacked = true,
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1
            };
            barSerie1.Items.Add(new BarItem { Value = 1 });
            barSerie1.Items.Add(new BarItem { Value = 2 });
            barSerie1.Items.Add(new BarItem { Value = 3 });
            barSerie1.Items.Add(new BarItem { Value = 4 });

            var barSerie2 = new BarSeries
            {
                Title = "Series 2",
                IsStacked = true,
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1
            };

            barSerie2.Items.Add(new BarItem { Value = 4 });
            barSerie2.Items.Add(new BarItem { Value = 3 });
            barSerie2.Items.Add(new BarItem { Value = 2 });
            barSerie2.Items.Add(new BarItem { Value = 1 });

            PlotModel.Series.Add(barSerie1);
            PlotModel.Series.Add(barSerie2);
        }
    }
}
