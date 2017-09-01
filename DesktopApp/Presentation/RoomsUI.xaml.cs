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
    /// Interaction logic for RoomsUI.xaml
    /// </summary>
    public partial class RoomsUI : Window
    {
        public RoomsUI()
        {
            BusinessLayer.DAO roomData = new BusinessLayer.DAO();

            InitializeComponent();
            RoomsList.DataContext = roomData.getRooms();
        }

        private void AddRequest_Click(object sender, RoutedEventArgs e)
        {
            DataLayer.Entities.Room roomNo = new DataLayer.Entities.Room();
            roomNo = (DataLayer.Entities.Room)RoomsList.SelectedItem;

            if (roomNo != null)
            {
                RequestFormUI requestUi = new RequestFormUI(roomNo);
                requestUi.Show();
            }
            else
            {
                MessageBox.Show("Please Select A Room You Want To Send Request To");
            }

           
        }
    }
}
