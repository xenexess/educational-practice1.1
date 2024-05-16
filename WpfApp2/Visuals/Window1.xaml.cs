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
using WpfApp2.DBase;

namespace WpfApp2.Visuals
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            inventory user = new inventory();
            user.id = Convert.ToInt32(id_TxB.Text);
            user.fullName = fullName_TxB.Text;
            user.invNum = Convert.ToInt32(invNum_TxB.Text);
            user.invType = invType_TxB.Text;
            user.invPrice = Convert.ToInt32(invCost_TxB.Text);
            user.adress = adress_TxB.Text;

            AppData.db.inventory.Edit(user);
            AppData.db.SaveChanges();
            MessageBox.Show("Пользователь изменен в базе!");
            NavigationService.GoBack();
        }
    }
}
