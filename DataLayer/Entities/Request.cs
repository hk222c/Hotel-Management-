using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DataLayer.Entities
{
    [Table(Name = "request")]
    public class Request
    {
        [Column(IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true)]
        public int id { get; set; }


        [Column(CanBeNull = false)]
        public int roomId { get; set; }

        [Column(CanBeNull = false)]
        public string service { get; set; }

        [Column(CanBeNull = false)]
        public string status { get; set; }

        [Column(CanBeNull = false)]
        public string description { get; set; }


        [Column(CanBeNull = true)]
        public string notes { get; set; }
        



    }
}
