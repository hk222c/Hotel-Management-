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
    /// Interaction logic for RequestFormUI.xaml
    /// </summary>
    public partial class RequestFormUI : Window
    {
        public RequestFormUI(DataLayer.Entities.Room roomNo)
        {
            InitializeComponent();

            int romNo = int.Parse(roomNo.roomnumber.ToString());
            Roomnumber.AppendText(romNo.ToString());

            ServiceTypes.Items.Add("CLEANING");
            ServiceTypes.Items.Add("MAINTENANCE");
            ServiceTypes.Items.Add("SERVICE");
        }

        private void okbutton_Click(object sender, RoutedEventArgs e)
        {
            BusinessLayer.DAO reqdata = new BusinessLayer.DAO();
            DataLayer.Entities.Request req = new DataLayer.Entities.Request();
            req.roomId = int.Parse(Roomnumber.Text);
            req.service = (string)ServiceTypes.SelectedItem;
            req.status = "NEW";
            req.description = descrptext.Text.ToString();

            reqdata.addRequest(req);
            this.Close();

        }

        private void cancelbutton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
