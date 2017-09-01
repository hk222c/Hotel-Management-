using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace DataLayer.Entities
{
    [Table(Name = "room")]
    public class Room
    {

        [Column(IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true)]
        public int id { get; set; }

        [Column(CanBeNull = false)]
        public int roomnumber { get; set; }

        [Column(CanBeNull = false)]
        public int roomtypeid { get; set; } //References Type
       
    }
}