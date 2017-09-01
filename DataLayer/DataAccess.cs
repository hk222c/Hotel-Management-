using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Test change
namespace DataLayer
{
    public class DataAccess
    {
        protected DataContext dc;
        string dbHost = "tod112.hib.no,1443";
        string db = "dat154_2";
        string user = "dat154_2";
        string pass = "dat154_2";

        public DataAccess()
        {
            dc = new DataContext("Data source=" + dbHost + ";Initial Catalog=" + db + ";User ID=" + user + ";Password=" + pass);

        }
    }
}
