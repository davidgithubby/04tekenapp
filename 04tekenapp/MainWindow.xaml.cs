using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _04tekenapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool radioButtonFunction(Shape shapeArg)
        {
            if (radioButtonCyan.IsChecked == true)
            {
                shapeArg.Stroke = System.Windows.Media.Brushes.Cyan;
                return true;
            }
            else if (radioButtonYellow.IsChecked == true)
            {
                shapeArg.Stroke = System.Windows.Media.Brushes.Yellow;
                return true;
            }
            else if (radioButtonRed.IsChecked == true)
            {
                shapeArg.Stroke = System.Windows.Media.Brushes.Red;
                return true;
            }
            return false;
        }
   
        private void btn_reset(object sender, RoutedEventArgs e)
        {
            mainGrid.Children.Clear();
        }

        private void btn_drawLineClick(object sender, RoutedEventArgs e)
        {
            Line myLine = new Line();

            if (radioButtonFunction(myLine) == true)
            {
                myLine.X1 = 100;
                myLine.Y1 = 50;

                myLine.X2 = 450;
                myLine.Y2 = 50;

                myLine.HorizontalAlignment = HorizontalAlignment.Left;
                myLine.VerticalAlignment = VerticalAlignment.Center;
                if (checkBoxThickStroke.IsChecked == true)
                {
                    myLine.StrokeThickness = 6;
                }
                else
                {
                    myLine.StrokeThickness = 2;
                }
                mainGrid.Children.Add(myLine);
            }
        }

        private void btn_rectangle(object sender, RoutedEventArgs e)
        {
            Rectangle rec = new Rectangle();
            
            if (radioButtonFunction(rec) == true)
            {
                rec.Height = 200;
                rec.Width = 300;
                if (checkBoxThickStroke.IsChecked == true)
                {
                    rec.StrokeThickness = 6;
                }
                else
                {
                    rec.StrokeThickness = 2;
                }
                mainGrid.Children.Add(rec);
            }
        }

        private void btn_ellipse(object sender, RoutedEventArgs e)
        {
            Ellipse elip = new Ellipse();

            if (radioButtonFunction(elip) == true)
            {
                elip.Height = 300;
                elip.Width = 400;
                if (checkBoxThickStroke.IsChecked == true)
                {
                    elip.StrokeThickness = 6;
                }
                else
                {
                    elip.StrokeThickness = 2;
                }
                
                mainGrid.Children.Add(elip);
            }
        }
    }
}
