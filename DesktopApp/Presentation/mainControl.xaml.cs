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

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for mainControl.xaml
    /// </summary>
    public partial class mainControl : UserControl
    {
        BookingUI bokUi = new BookingUI();
        RoomsUI romUi = new RoomsUI();
        ReservationUI resUi = new ReservationUI();
        customerUI custUi = new customerUI();
        public mainControl()
        {
            InitializeComponent();
        }

        private void resev_Click(object sender, RoutedEventArgs e)
        {
            ReservationUI resUi = new ReservationUI();
            resUi.Activate();
            resUi.Show();

        }

        private void booking_Click(object sender, RoutedEventArgs e)
        {
            BookingUI bokUi = new BookingUI();
            bokUi.Activate();
            bokUi.Show();
        }

        private void rooms_Click(object sender, RoutedEventArgs e)
        {
            RoomsUI romUi = new RoomsUI();
            romUi.Activate();
            romUi.Show();

        }

        private void customer_Click(object sender, RoutedEventArgs e)
        {
            customerUI custUi = new customerUI();
            custUi.Activate();
            custUi.Show();

        }

        private void request_Click(object sender, RoutedEventArgs e)
        {
            requestViewUI reqUi = new requestViewUI();
            reqUi.Activate();
            reqUi.Show();
        }
       
    }
}
