using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp2.DBase;
using WpfApp2.Visuals;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tableInventory.ItemsSource = AppData.db.inventory.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddPage());
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить пользователя?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var currentUser = tableInventory.SelectedItem as inventory;

                AppData.db.inventory.Remove(currentUser);
                AppData.db.SaveChanges();

                tableInventory.ItemsSource = AppData.db.inventory.ToList();
                MessageBox.Show("Успешно");
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    
}
