using OxyPlot;
using OxyPlot.Series;
using XamarinOxyPlot.ViewModels.Base;

namespace XamarinOxyPlot.ViewModels
{
    public class ColumnViewModel : ViewModelBase
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
                Title = "Column"
            };

            var columnSerie = new ColumnSeries
            {
                StrokeThickness = 2.0
            };

            columnSerie.Items.Add(new ColumnItem(1));
            columnSerie.Items.Add(new ColumnItem(2));
            columnSerie.Items.Add(new ColumnItem(3));
            columnSerie.Items.Add(new ColumnItem(4));
            columnSerie.Items.Add(new ColumnItem(5));

            PlotModel.Series.Add(columnSerie);
        }
    }
}
