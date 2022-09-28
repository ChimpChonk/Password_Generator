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
using LoginManagerLogic;

namespace PasswordGenerator
{
    /// <summary>
    /// Interaction logic for LManager.xaml
    /// </summary>
    public partial class LManager : Page
    {
        public LManager()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            LManagerPage.Content = new MainPage();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            DataBase data = new DataBase();

            data.webSite = Website.Text;
            data.userName = User.Text;
            data.userPassword = UserPassword.Text;

            dataGrid.Items.Add(data);
        }

        private void DataGridCheckBoxColumn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FrameworkElement_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
