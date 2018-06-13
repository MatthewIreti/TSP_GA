using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using TSP.GA;

namespace TSP
{
    public partial class ChartPlotter : Form
    {
        public ChartPlotter()
        {
            InitializeComponent();
        }

        public void PlotData(Tour tour, Tour optimalTour)
        {
            PlotRoute(tour, txtInitialRoute, plotViewInitial);
            PlotRoute(optimalTour, txtOptimal, plotViewOptimal);
            txtDistanceInitial.Text = $"Total Distance: {tour.CalculateTotalDistance()} KM";
            txtDistanceOptimal.Text = $"Total Distance: {optimalTour.CalculateTotalDistance()} KM";
        }
        private void PlotRoute(Tour tour, TextBox textBox, PlotView plotView)
        {
            var model = new PlotModel { Title = "TSP in GA" };
            var scatterSeries = new ScatterSeries { MarkerType = MarkerType.Circle };

            List<DataPoint> dataPoints = new List<DataPoint>();

            var lineseries = new LineSeries
            {
                LineStyle = LineStyle.DashDot,
                LineJoin = LineJoin.Bevel,
                ItemsSource=dataPoints
            };
            if (tour != null)
            {
                textBox.Text = tour.ToString();
                var r = new Random(314);
                for (int i = 0; i < tour.TourSize(); i++)
                {
                    var city = tour.GetCity(i);
                    var x = city.Longitude / Constants.CONVERT_TO_RADIANS;
                    var y = city.Latitude / Constants.CONVERT_TO_RADIANS;
                    dataPoints.Add(new DataPoint(x, y));
                    var colorValue = r.Next(100, 1000);
                    scatterSeries.Points.Add(new ScatterPoint(x, y, 10, colorValue));
                }

                var sourceCity = tour.GetCity(0);
                var sourceX = sourceCity.Longitude / Constants.CONVERT_TO_RADIANS;
                var sourceY = sourceCity.Latitude / Constants.CONVERT_TO_RADIANS;
                dataPoints.Add(new DataPoint(sourceX, sourceY));
                var colorValuer = r.Next(100, 1000);
                scatterSeries.Points.Add(new ScatterPoint(sourceX, sourceY, 10, colorValuer));

            }

            model.Series.Add(lineseries);
            model.Series.Add(scatterSeries);
            model.Axes.Add(new LinearColorAxis { Position = AxisPosition.Right, Palette = OxyPalettes.Jet(256) });
            plotView.Model = model;
        }
       
    }
}
