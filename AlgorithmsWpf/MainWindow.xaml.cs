using AlgorithmLib;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Forms.DataVisualization.Charting;

namespace AlgorithmsWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<List<Algorithm>> algorithms = new List<List<Algorithm>>();

        public MainWindow()
        {
            InitializeComponent();

            chart.ChartAreas.First().AxisX.Title = "Ilosc elementów";
            chart.ChartAreas.First().AxisX.CustomLabels.Clear();
            chart.ChartAreas.First().AxisY.Title = "Czas trwania";
            chart.ChartAreas.First().AxisY.LabelStyle.Format = "0ms";
        }

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            chart.Series.Clear();

            if(algorithms.Count == 0)
            {
                MessageBox.Show("Add an algorithm", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            for(int i = 0; i < algorithms.Count; i++)
            {
                Series newSeries = new Series();
                newSeries.ChartType = SeriesChartType.Column;
                newSeries.Label = $"{algorithms[i][0].GetType().Name}";

                foreach (Algorithm alg in algorithms[i])
                {
                    newSeries.Points.Add(alg.Time).AxisLabel = $"{alg.Count}";
                }

                chart.Series.Add(newSeries);
                chart.ChartAreas.First().RecalculateAxesScale();
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < algorithms.Count; i++)
            {
                for (int j = 0; j < algorithms[i].Count; j++)
                {
                    if (sender.Equals(MaxButton))
                    {
                        algorithms[i][j].Data = new AscendingSequence(algorithms[i][j].Count);
                    }
                    if (sender.Equals(MinButton))
                    {
                        algorithms[i][j].Data = new DescendingSequence(algorithms[i][j].Count);
                    }
                    if (sender.Equals(RandButton))
                    {
                        algorithms[i][j].Data = new RandomSequence(algorithms[i][j].Count);
                    }
                }
            }
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if(sender.Equals(BubbleButton))
            {
                if(MaxButton.IsChecked == true)
                {
                    algorithms.Add(new List<Algorithm>(
                        new BubbleSort[] {
                            new BubbleSort(new AscendingSequence(1000)),
                            new BubbleSort(new AscendingSequence(1000)),
                        }
                    ));
                }
                if(MinButton.IsChecked == true)
                {
                    algorithms.Add(new List<Algorithm>(
                       new BubbleSort[] {
                            new BubbleSort(new DescendingSequence(1000)),
                            new BubbleSort(new DescendingSequence(1000)),
                       }
                   ));
                }
                else
                {
                    algorithms.Add(new List<Algorithm>(
                       new BubbleSort[] {
                            new BubbleSort(new RandomSequence(1000)),
                            new BubbleSort(new RandomSequence(1000)),
                       }
                   ));
                }
            }
            if (sender.Equals(InsertionButton))
            {
                if (MaxButton.IsChecked == true)
                {
                    algorithms.Add(new List<Algorithm>(
                        new InsertionSort[] {
                            new InsertionSort(new AscendingSequence(1000)),
                            new InsertionSort(new AscendingSequence(1000)),
                        }
                    ));
                }
                if (MinButton.IsChecked == true)
                {
                    algorithms.Add(new List<Algorithm>(
                       new InsertionSort[] {
                            new InsertionSort(new DescendingSequence(1000)),
                            new InsertionSort(new DescendingSequence(1000)),
                       }
                   ));
                }
                else
                {
                    algorithms.Add(new List<Algorithm>(
                       new InsertionSort[] {
                            new InsertionSort(new RandomSequence(1000)),
                            new InsertionSort(new RandomSequence(1000)),
                       }
                   ));
                }
            }
            if (sender.Equals(SelectionButton))
            {
                if (MaxButton.IsChecked == true)
                {
                    algorithms.Add(new List<Algorithm>(
                        new SelectionSort[] {
                            new SelectionSort(new AscendingSequence(1000)),
                            new SelectionSort(new AscendingSequence(1000)),
                        }
                    ));
                }
                if (MinButton.IsChecked == true)
                {
                    algorithms.Add(new List<Algorithm>(
                       new SelectionSort[] {
                            new SelectionSort(new DescendingSequence(1000)),
                            new SelectionSort(new DescendingSequence(1000)),
                       }
                   ));
                }
                else
                {
                    algorithms.Add(new List<Algorithm>(
                       new SelectionSort[] {
                            new SelectionSort(new RandomSequence(1000)),
                            new SelectionSort(new RandomSequence(1000)),
                       }
                   ));
                }
            }
            if (sender.Equals(QuickButton))
            {
                if (MaxButton.IsChecked == true)
                {
                    algorithms.Add(new List<Algorithm>(
                        new QuickSort[] {
                            new QuickSort(new AscendingSequence(1000)),
                            new QuickSort(new AscendingSequence(1000)),
                        }
                    ));
                }
                if (MinButton.IsChecked == true)
                {
                    algorithms.Add(new List<Algorithm>(
                       new QuickSort[] {
                            new QuickSort(new DescendingSequence(1000)),
                            new QuickSort(new DescendingSequence(1000)),
                       }
                   ));
                }
                else
                {
                    algorithms.Add(new List<Algorithm>(
                       new QuickSort[] {
                            new QuickSort(new RandomSequence(1000)),
                            new QuickSort(new RandomSequence(1000)),
                       }
                   ));
                }
            }
            if (sender.Equals(MergeButton))
            {
                if (MaxButton.IsChecked == true)
                {
                    algorithms.Add(new List<Algorithm>(
                        new MergeSort[] {
                            new MergeSort(new AscendingSequence(1000)),
                            new MergeSort(new AscendingSequence(1000)),
                        }
                    ));
                }
                if (MinButton.IsChecked == true)
                {
                    algorithms.Add(new List<Algorithm>(
                       new MergeSort[] {
                            new MergeSort(new DescendingSequence(1000)),
                            new MergeSort(new DescendingSequence(1000)),
                       }
                   ));
                }
                else
                {
                    algorithms.Add(new List<Algorithm>(
                       new MergeSort[] {
                            new MergeSort(new RandomSequence(1000)),
                            new MergeSort(new RandomSequence(1000)),
                       }
                   ));
                }
            }
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(BubbleButton))
            {
                algorithms = new List<List<Algorithm>>(algorithms.Where(alg => alg[0].GetType().Name != "BubbleSort"));
            }
            if (sender.Equals(InsertionButton))
            {
                algorithms = new List<List<Algorithm>>(algorithms.Where(alg => alg[0].GetType().Name != "InsertionSort"));
            }
            if (sender.Equals(SelectionButton))
            {
                algorithms = new List<List<Algorithm>>(algorithms.Where(alg => alg[0].GetType().Name != "SelectionSort"));
            }
            if (sender.Equals(QuickButton))
            {
                algorithms = new List<List<Algorithm>>(algorithms.Where(alg => alg[0].GetType().Name != "QuickSort"));
            }
            if (sender.Equals(MergeButton))
            {
                algorithms = new List<List<Algorithm>>(algorithms.Where(alg => alg[0].GetType().Name != "MergeSort"));
            }
        }
    }
}
