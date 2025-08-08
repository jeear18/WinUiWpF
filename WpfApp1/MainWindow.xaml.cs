using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Navigation_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (Navigation.SelectedItem is Wpf.Ui.Controls.NavigationViewItem item)
            {
                switch (item.Tag)
                {
                    case "HomePage":
                        ContentFrame.Content = new TextBlock { Text = "Welcome to Home Page", Foreground = System.Windows.Media.Brushes.White };
                        break;
                    case "ReportsPage":
                        ContentFrame.Content = new TextBlock { Text = "Reports Page Content", Foreground = System.Windows.Media.Brushes.White };
                        break;
                    case "SettingsPage":
                        ContentFrame.Content = new TextBlock { Text = "Settings Page Content", Foreground = System.Windows.Media.Brushes.White };
                        break;
                }
            }
        }

    }
}