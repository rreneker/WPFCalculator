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
using BusinessLogic;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Calculator cal;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            
            cal = new Calculator();
            Result.Text = cal.GetCurrentNumber();
            //MainGrid.MouseUp += new MouseButtonEventHandler(MainGrid_MouseUp);
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            string button = (e.Source as Button).Content.ToString();
            cal.NumberInput(button);
            Result.Text = cal.GetCurrentNumber();
            
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            string button = (e.Source as Button).Content.ToString();
            cal.Calculate(button);
            Result.Text = cal.GetCurrentNumber();    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cal.Clear();
            Result.Text = cal.GetCurrentNumber();
        }
    }
}
