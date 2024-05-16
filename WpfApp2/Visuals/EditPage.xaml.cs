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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        public EditPage()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            inventory user = new inventory();
            user.id = Convert.ToInt32(id_Txb.Text);
            user.fullName = fullName_Txb.Text;
            user.invNum = Convert.ToInt32(invNum_Txb.Text);
            user.invType = invType_Txb.Text;
            user.invPrice = Convert.ToInt32(invCost_Txb.Text);
            user.adress = adress_Txb.Text;

            AppData.db.inventory.Add(user);
            AppData.db.SaveChanges();
            MessageBox.Show("Пользователь добавлен в базу!");
        }
    }
}
