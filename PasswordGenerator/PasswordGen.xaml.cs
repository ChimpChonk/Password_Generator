using PasswordLogic;
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

namespace PasswordGenerator
{
    /// <summary>
    /// Interaction logic for PasswordGenerator.xaml
    /// </summary>
    public partial class PasswordGen : Page
    {
        AppLogic appLogic;
        int passwordLength;

        public PasswordGen()
        {
            InitializeComponent();
            slider.Minimum = 5;
            slider.Maximum = 20;
        }

        private void slider_ValueChanged(object sender, EventArgs e)
        {
            appLogic = new AppLogic();


            passwordLength = (int)slider.Value;
            PasswordLengthLabel.Content = "Password Length: " + slider.Value.ToString();

            PasswordLabel.Text = appLogic.NewPassword((bool)CapitalCheck.IsChecked, (bool)SmallCheck.IsChecked, (bool)NumbersCheck.IsChecked, (bool)SymbolsCheck.IsChecked, passwordLength);
            //PasswordLabel.Text = "click the check boxex";



        }

        private void BtnCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText((string)PasswordLabel.Text);
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            Password.Content = mainWindow;
        }
    }
}
