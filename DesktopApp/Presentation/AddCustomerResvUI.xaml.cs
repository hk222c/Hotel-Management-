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
    /// Interaction logic for AddCustomerResvUI.xaml
    /// </summary>
    public partial class AddCustomerResvUI : Window
    {

        DataLayer.Entities.Customer newaddcust = new DataLayer.Entities.Customer();
        BusinessLayer.DAO busstest = new BusinessLayer.DAO();
        public AddCustomerResvUI(DataLayer.Entities.Customer cusToresv)
        {
            InitializeComponent();

            RoomTypes.Items.Add("SINGLE");
            RoomTypes.Items.Add("DOUBLE");
            RoomTypes.Items.Add("SUITE");

            newaddcust = cusToresv;
        }      

        private void Okbutton_Click(object sender, RoutedEventArgs e)
        {

            DataLayer.Entities.ReservationApplication newResv = new DataLayer.Entities.ReservationApplication();
            int romnu = 0;
            String romtyp = RoomTypes.SelectedItem.ToString();
            if(romtyp.Equals("SINGLE")){
                romnu = 1;
            }
            else if (romtyp.Equals("DOUBLE")) {
                romnu = 2;
            }
            else
            {
                romnu = 3;
            }

            DateTime ar = (DateTime)DatearrivePicked.SelectedDate;
            DateTime er = (DateTime)DateleavePicked.SelectedDate;

            int stuff = busstest.getVacantRoomsOfTypeBok(ar, er, romnu);

            if (stuff != 0)
            {
                newResv.cusId = newaddcust.cusId;
                newResv.arriveDate = (DateTime)DatearrivePicked.SelectedDate;
                newResv.leaveDate = (DateTime)DateleavePicked.SelectedDate;
                newResv.roomChoice = RoomTypes.SelectedItem.ToString();
                newResv.roomNo = stuff;
                newResv.comment = coommentfield.Text;
                busstest.addReservation(newResv);

                this.Close();

            }
            else
            {
                MessageBox.Show("We dont have rooms");
            }
            
           

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
