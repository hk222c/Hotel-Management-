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
    /// Interaction logic for BookingUI.xaml
    /// </summary>
    public partial class BookingUI : Window
    {
        
        BusinessLayer.DAO busstest = new BusinessLayer.DAO();


        public BookingUI()
        {
            InitializeComponent();

            BookingList.DataContext = busstest.getBookings();


        }

        private void moreInfo_Click(object sender, RoutedEventArgs e)
        {
            DataLayer.Entities.Booking custid = new DataLayer.Entities.Booking();
            custid = (DataLayer.Entities.Booking)BookingList.SelectedItem;

            if (custid != null)
            {
                customerUI custUi = new customerUI(custid);
                custUi.Show();
            }
            else
            {
                MessageBox.Show("Please Select Booking Data");
            }

            

        }

        private void deleterev_Click(object sender, RoutedEventArgs e)
        {
            DataLayer.Entities.Booking delid = new DataLayer.Entities.Booking();
            delid = (DataLayer.Entities.Booking)BookingList.SelectedItem;

            if (delid != null)
            {
                busstest.deleteBok(delid);
                
            }            
            
        }

        private void CheckinButton_Click(object sender, RoutedEventArgs e)
        {
            DataLayer.Entities.Booking currentBok = new DataLayer.Entities.Booking();
            currentBok = (DataLayer.Entities.Booking)BookingList.SelectedItem;

            if (currentBok != null)
            {
                int ids = currentBok.id;
                busstest.checkIn(ids);
                
            }            
            

        }

        private void CheckouButton_Click(object sender, RoutedEventArgs e)
        {
            DataLayer.Entities.Booking currentBok = new DataLayer.Entities.Booking();
            currentBok = (DataLayer.Entities.Booking)BookingList.SelectedItem;

            if (currentBok != null)
            {
                int ids = currentBok.id;
                busstest.checkOut(ids);
               

            }            
            
        }
    }
}
