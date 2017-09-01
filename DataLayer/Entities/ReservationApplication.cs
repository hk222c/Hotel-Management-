using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DataLayer.Entities
{
    [Table(Name = "reservationapplication")]
    public class ReservationApplication
    {
        [Column(IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true)]
        public int id { get; set; }

        [Column(CanBeNull = false)]
        public int cusId { get; set; }

        [Column(CanBeNull = false)]
        public DateTime arriveDate { get; set; }

        [Column(CanBeNull = false)]
        public DateTime leaveDate { get; set; }

        [Column(CanBeNull = false)]
        public string roomChoice { get; set; }

        [Column(CanBeNull = false)]
        public int roomNo { get; set; }

        [Column(CanBeNull = false)]
        public string comment { get; set; }



    }
}
