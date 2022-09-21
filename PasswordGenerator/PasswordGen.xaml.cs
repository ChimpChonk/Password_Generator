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
        int currentPasswordLength = 0;
        Random character = new Random();

        private void PasswordGenerate(int passwordLength)
        {
            string allCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz!@$%^&*";
            string randomPassword = "";

            for (int i = 0; i < passwordLength; i++)
            {
                int randomNum = character.Next(0, allCharacters.Length);
                randomPassword += allCharacters[randomNum];
            }

            PasswordLabel.Text = randomPassword;
        }
        public PasswordGen()
        {
            InitializeComponent();
            slider.Minimum = 5;
            slider.Maximum = 20;
            PasswordGenerate(5);
        }

        private void slider_ValueChanged(object sender, EventArgs e)
        {
            currentPasswordLength = (int)slider.Value;
            PasswordLengthLabel.Content = "Password Length: " + slider.Value.ToString();
            PasswordGenerate(currentPasswordLength);

        }

        private void button_Click(object sender, RoutedEventArgs e)
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
