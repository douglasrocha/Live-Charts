﻿using System.Collections.Generic;
using System.Windows.Controls;
using ChartsTest.BarExamples;
using ChartsTest.BarExamples.FilterChart;
using ChartsTest.BarExamples.MultiAxesBarChart;
using ChartsTest.BarExamples.UsingObservableChartPoint;
using ChartsTest.Line_Examples;
using ChartsTest.Line_Examples.AnimationImprovement;
using ChartsTest.Line_Examples.DynamicLine;
using ChartsTest.Line_Examples.Generic;
using ChartsTest.Line_Examples.InLine;
using ChartsTest.Line_Examples.IrregularIntervals;
using ChartsTest.Line_Examples.LogarithmicLine;
using ChartsTest.Line_Examples.RotadedLine;
using ChartsTest.Line_Examples.ZoomingAndPanning;
using ChartsTest.Pie_Examples;
using ChartsTest.StackedBarExamples;
using ChartsTest.StackedBarExamples.StackedBarRotated;
using ChartsTest.z.DebugCases;
using ChartsTest.z.DebugCases._101;
using BasicBar = ChartsTest.BarExamples.Basic.BasicBar;
using BasicLine = ChartsTest.Line_Examples.Basic.BasicLine;
using BasicPie = ChartsTest.Pie_Examples.Basic.BasicPie;
using BasicStackedBar = ChartsTest.StackedBarExamples.Basic.BasicStackedBar;
using MvvmPie = ChartsTest.Pie_Examples.Mvvm.MvvmPie;
using MvvmStackedBar = ChartsTest.StackedBarExamples.Mvvm.MvvmStackedBar;
using RotatedBar = ChartsTest.BarExamples.RotatedBar.RotatedBar;
using UiElementsLine = ChartsTest.Line_Examples.UiElements.UiElementsLine;

namespace ChartsTest
{
    //IMPORTANT
    //This class is only to display examples in MainWindow
    //If you want to see the code behind and XAML of an example you should go to that path
    //for example in solution exmplorer go to "Line Examples" folder and open the example you need.
    public static class ExamplesMapper
    {
        public static void Initialize(MainWindow window)
        {
            LineAndAreaAexamples = new List<UserControl>
            {
                new ZAndPLine(),
                new AnimationImprovementLine(),
                new BasicLine(),
                new DynamicLine(),
                new GenericLine(),
                new RotatedLine(),
                new CustomLine(),
                new IrregularLine(),
                new LogarithmicAxis(),
                new UiElementsLine(),
                new InLineLine()
            };
            BarExamples = new List<UserControl>
            {
                new FilterChart(),
                new MultiAxChart(),
                new RotatedBar(),
                new MvvmBar(),
                new PointPropertyChangedBar(),
                new BasicBar(),
                new BindingBar(),
                new CustomBar()
            };
            PieExamples = new List<UserControl>
            {
                new BasicPie(),
                new MvvmPie(),
                new CustomPie(),
            };

            //currently disabled chart type
            //StackedBarExamples = new List<UserControl>
            //{
            //    //new BasicStackedBar(),
            //    //new RotatedStackedBar(),
            //    //new BindingStackedBar(),
            //    //new MvvmStackedBar(),
            //    //new CustomStackedBar(),
            //};
            MoreExamples = new List<UserControl>
            {
               //new Issue101(),
               //new Issue102()
            };
            window.LineControl.Content = LineAndAreaAexamples != null && LineAndAreaAexamples.Count > 0 ? LineAndAreaAexamples[0] : null;
            window.BarControl.Content = BarExamples != null && BarExamples.Count > 0 ? BarExamples[0] : null;
            window.StackedBarControl.Content =StackedBarExamples != null && StackedBarExamples.Count > 0 ? StackedBarExamples[0] : null;
            window.PieControl.Content = PieExamples != null && PieExamples.Count > 0 ? PieExamples[0] : null;
            window.MoreControl.Content = MoreExamples != null && MoreExamples.Count > 0 ? MoreExamples[0] : null;
        }
        public static List<UserControl> LineAndAreaAexamples { get; set; }
        public static List<UserControl> BarExamples { get; set; }
        public static List<UserControl> StackedBarExamples { get; set; }
        public static List<UserControl> PieExamples { get; set; }
        public static List<UserControl> ScatterExamples { get; set; }
        public static List<UserControl> MoreExamples { get; set; } 

        public static void Next(this ContentControl control, List<UserControl> list)
        {
            var c = control.Content as UserControl;
            if (c == null) return;
            var i = list.IndexOf(c);
            i++;
            if (i > list.Count - 1) i = 0;
            control.Content = list[i];
        }

        public static void Previous(this ContentControl control, List<UserControl> list)
        {
            var c = control.Content as UserControl;
            if (c == null) return;
            var i = list.IndexOf(c);
            i--;
            if (i < 0) i = list.Count-1;
            control.Content = list[i];
        }
    }
}
