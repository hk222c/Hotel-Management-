using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DataLayer.Entities
{
    [Table(Name = "customer")]
    public class Customer
    {

        [Column(IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true)]
        public int cusId { get; set; }

        [Column(CanBeNull = false)]
        public string firstName { get; set; }

        [Column(CanBeNull = false)]
        public string lastName { get; set; }

        [Column(CanBeNull = false)]
        public string email { get; set; }

        [Column(CanBeNull = false)]
        public string passWords { get; set; }

        [Column(CanBeNull = false)]
        public int phoneNo { get; set; }


    }

}
