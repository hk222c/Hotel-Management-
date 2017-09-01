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
using System.Windows.Shapes;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for customerUI.xaml
    /// </summary>
    public partial class customerUI : Window
    {

        //Business.businessFunctions busstest = new Business.businessFunctions();
        BusinessLayer.DAO busstest = new BusinessLayer.DAO();
        public customerUI()
        {
            InitializeComponent();

            var stuff = busstest.getCustomers();

            CustomerList.DataContext = stuff;


        }

        public customerUI(DataLayer.Entities.Booking custid)
        {
            InitializeComponent();

            int customerid = int.Parse(custid.customerid.ToString());

            var stuff = busstest.getUserWithId(customerid);

            CustomerList.DataContext = stuff;
        }

        private void addResvCus_Click(object sender, RoutedEventArgs e)
        {

            DataLayer.Entities.Customer cusResv = new DataLayer.Entities.Customer();
            cusResv = (DataLayer.Entities.Customer)CustomerList.SelectedItem;

            AddCustomerResvUI addRescust = new AddCustomerResvUI(cusResv);
            addRescust.Show();

        }

    }
}
