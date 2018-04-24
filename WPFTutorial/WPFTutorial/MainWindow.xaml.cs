using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        public Calculator cal;
        private string display;
        public string Display
        {
            get { return display; }
            set {
                if (value != display)
                {
                    display = value;
                    OnPropertyChanged("Display");
                } }
        }
        public MainWindow()
        {
            InitializeComponent();
            Result.DataContext = this;
            cal = new Calculator();
            
            Display = cal.GetCurrentNumber();
            //MainGrid.MouseUp += new MouseButtonEventHandler(MainGrid_MouseUp);
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            string button = (e.Source as Button).Content.ToString();
            cal.NumberInput(button);
            Display = cal.GetCurrentNumber();
            
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            string button = (e.Source as Button).Content.ToString();
            cal.Calculate(button);
            Display = cal.GetCurrentNumber();    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cal.Clear();
            Display = cal.GetCurrentNumber();
        }
    }
}
