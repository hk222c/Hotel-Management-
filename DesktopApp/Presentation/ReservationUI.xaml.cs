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
    /// Interaction logic for ReservationUI.xaml
    /// </summary>
    public partial class ReservationUI : Window

    {

        BusinessLayer.DAO acess = new BusinessLayer.DAO();
        public ReservationUI()
        {
            
            InitializeComponent();
            ReservationList.DataContext = acess.getReservations();
        }

        private void addResv_Click(object sender, RoutedEventArgs e)
        {            
            DataLayer.Entities.ReservationApplication selectRes = (DataLayer.Entities.ReservationApplication)ReservationList.SelectedItem;
            if (selectRes != null)
            {
                DataLayer.Entities.Booking bookings = new DataLayer.Entities.Booking();

                DateTime defualttime = new DateTime(1970, 1, 1, 00, 00, 00);

                bookings.customerid = selectRes.cusId;
                bookings.arriveDate = selectRes.arriveDate;
                bookings.leaveDate = selectRes.leaveDate;
                bookings.roomid = selectRes.roomNo;
                bookings.comment = selectRes.comment;
                bookings.checkin = defualttime;
                bookings.checkout = defualttime;

                acess.addBooking(bookings);
                acess.deleteResv(selectRes);
            }
            

        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            DataLayer.Entities.ReservationApplication selectRes = (DataLayer.Entities.ReservationApplication)ReservationList.SelectedItem;
            if (selectRes != null)
            {
                acess.deleteResv(selectRes);
            }
        }
    }
}
