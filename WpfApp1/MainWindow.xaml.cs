﻿using System;
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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int zähler = 6;
        DispatcherTimer timer = new DispatcherTimer();

        Random r = new Random();

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            zähler -=1;
            if (zähler == 0)
            {
                timer.Stop();
            }
            labeltimer.Content = zähler.ToString();
        }

        private void gamestart(object sender, RoutedEventArgs e)
        {
            Ellipse newEllipse = new Ellipse
            {
                Width = 50,
                Height = 50,
                StrokeThickness = 40,
                Stroke = Brushes.Black
            };

            // once the Ellipse is set we need to give a X and Y position for the new object
            // we will calculate the mouse click location and add it there
            Canvas.SetLeft(newEllipse, r.Next(0, 1500));
            Canvas.SetTop(newEllipse, r.Next(0, 550));

            spielfeld.Children.Add(newEllipse); // add the new Ellipse to the canvas
            timer.Start();
        }

        private void add(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is Ellipse)
            {
                // if the click source is a Ellipse then we will create a new Ellipse
                // and link it to the Ellipse that sent the click event
                Ellipse activeEllipse = (Ellipse)e.OriginalSource; // create the link between the sender Ellipse

                spielfeld.Children.Remove(activeEllipse); // find the Ellipse and remove it from the canvas

                // create a re Ellipse and give it the following properties
                // height and width 50 pixels
                // border thickness 3 pixels, fill colour set to the custom brush created above
                // border colour set to black
                Ellipse newEllipse = new Ellipse
                {
                    Width = 50,
                    Height = 50,
                    StrokeThickness = 40,
                    Stroke = Brushes.Black
                };

                // once the Ellipse is set we need to give a X and Y position for the new object
                // we will calculate the mouse click location and add it there
                Canvas.SetLeft(newEllipse, r.Next(0,1500)); 
                Canvas.SetTop(newEllipse, r.Next(0, 550));

                spielfeld.Children.Add(newEllipse); // add the new Ellipse to the canvas
            }

            // if we clicked on the canvas then we do the following
            else
            {
                
            }
        }
    }
}
