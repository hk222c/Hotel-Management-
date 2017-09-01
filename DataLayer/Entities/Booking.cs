using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace DataLayer.Entities
{
    [Table (Name="booking")]
    public class Booking
    {
        [Column(IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true)]
        public int id { get; set; }

        [Column(CanBeNull = false)] //References customer
        public int customerid { get; set; }

        [Column(CanBeNull = false)]
        public int roomid { get; set; }//References room

        [Column(CanBeNull = false)]
        public DateTime checkin {get; set;}

        [Column(CanBeNull = false)]
        public DateTime checkout { get; set; }


        [Column(CanBeNull = false)]
        public DateTime arriveDate { get; set; }

        [Column(CanBeNull = false)]
        public DateTime leaveDate { get; set; }

        [Column(CanBeNull = true)]
        public String comment { get; set; }
    }
}
