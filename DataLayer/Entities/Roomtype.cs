using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace DataLayer.Entities
{
    [Table(Name = "roomtype")]
    public class Roomtype
    {
        [Column(IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true)]
        public int id { get; set; }

        [Column(CanBeNull = false)]
        public int roomtypeid { get; set; }

        [Column(CanBeNull = false)]
        public string typename { get; set; }

        [Column(CanBeNull = false)]
        public int numberofbeds { get; set; }

        [Column(CanBeNull = false)]
        public int size { get; set; }

        [Column(CanBeNull = false)]
        public int rate { get; set; }
   
    }
}