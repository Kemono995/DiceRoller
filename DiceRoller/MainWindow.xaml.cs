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

namespace DiceRoller
{
    
   /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
        //Total
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
            MainWindowViewModel mainWindowViewModel = DataContext as MainWindowViewModel;
            if (mainWindowViewModel==null)
            {
                return;
            }
                mainWindowViewModel.RollOption = RollOptions.Total;
        }
        //Average
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = DataContext as MainWindowViewModel;
            if (mainWindowViewModel == null)
            {
                return;
            }
            mainWindowViewModel.RollOption = RollOptions.Average;
        }
        //Regular
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = DataContext as MainWindowViewModel;
            if (mainWindowViewModel == null)
            {
                return;
            }
            mainWindowViewModel.AdvantageOption = AdvantageOptions.Regular;
        }
        //Advantage
        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = DataContext as MainWindowViewModel;
            if (mainWindowViewModel == null)
            {
                return;
            }
            mainWindowViewModel.AdvantageOption = AdvantageOptions.Advantage;
        }
        //Dissadvantage
        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = DataContext as MainWindowViewModel;
            if (mainWindowViewModel == null)
            {
                return;
            }
            mainWindowViewModel.AdvantageOption = AdvantageOptions.Dissadvantage;
        }
        //
    }

}
