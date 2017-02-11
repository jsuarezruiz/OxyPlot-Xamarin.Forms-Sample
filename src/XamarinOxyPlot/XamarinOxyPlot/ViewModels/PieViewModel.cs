using OxyPlot;
using OxyPlot.Series;
using XamarinOxyPlot.ViewModels.Base;

namespace XamarinOxyPlot.ViewModels
{
    public class PieViewModel : ViewModelBase
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
                Title = "Pie"
            };

            var pieSlice = new PieSeries
            {
                StrokeThickness = 2.0,
                InsideLabelPosition = 0.8,
                AngleSpan = 360,
                StartAngle = 0
            };

            pieSlice.Slices.Add(new PieSlice("1º", 1) { IsExploded = true });
            pieSlice.Slices.Add(new PieSlice("2º", 2) { IsExploded = true });
            pieSlice.Slices.Add(new PieSlice("3º", 3) { IsExploded = true });
            pieSlice.Slices.Add(new PieSlice("4º", 4) { IsExploded = true });
            pieSlice.Slices.Add(new PieSlice("5º", 5) { IsExploded = true });

            PlotModel.Series.Add(pieSlice);
        }
    }
}
