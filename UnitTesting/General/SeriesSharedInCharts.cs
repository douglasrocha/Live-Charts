﻿using LiveCharts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.General
{
    public partial class GeneralTest
    {

        //Charts should be able to handle when 
        //a series exists in more than one visual tree

        [TestMethod, TestCategory("General")]
        public void SharedSeries()
        {
            var sharedSeries = new LineSeries {Values = new ChartValues<double> {1, 2, 3}};

            var lineChart1 = new BarChart
            {
                Series = new SeriesCollection
                {
                    sharedSeries
                }
            };
            lineChart1.UnsafeUpdate();

            var lineChart2 = new LineChart
            {
                Series = new SeriesCollection
                {
                    sharedSeries
                }
            };

            lineChart2.UnsafeUpdate();
        }
    }
}
