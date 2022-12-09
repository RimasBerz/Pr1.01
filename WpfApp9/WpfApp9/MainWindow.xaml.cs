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

namespace WpfApp9
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
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Button1.Background = Brushes.Red;
            Button1.Background = Brushes.Blue;
            Button1.Background = Brushes.Green;
        }
        //private void Window_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyboardDevice.Modifiers == ModifierKeys.Control)
        //        if (e.Key == Key.B)
        //        {
        //            Button1.Background = new SolidColorBrush(Colors.Blue);
        //        }
        //    if (e.Key == Key.R)
        //    {
        //        Button1.Background = new SolidColorBrush(Colors.Red);
        //    }
        //    if (e.Key == Key.G)
        //    {
        //        Button1.Background = new SolidColorBrush(Colors.Green);
        //    }
        //}
    }

    public class ColorCommands
    {
        static ColorCommands()
        {
            RedCommand = new RoutedCommand("RedCommand", typeof(ColorCommands));
            BlueCommand = new RoutedCommand("BlueCommand", typeof(ColorCommands));
            GreenCommand = new RoutedCommand("GreenCommand", typeof(ColorCommands));
        }
        public static RoutedCommand RedCommand { get; set; }
        public static RoutedCommand BlueCommand { get; set; }
        public static RoutedCommand GreenCommand { get; set; }
    }
}

