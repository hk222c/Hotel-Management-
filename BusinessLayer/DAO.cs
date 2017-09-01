using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer


{
    public class DAO : DataLayer.DataAccess
    {

        public Object getRequests()
        {
            var requests = dc.GetTable<DataLayer.Entities.Request>();
            return requests;

        }
        public Object getMaintenanceTasks(){
            var mRequests = dc.GetTable<DataLayer.Entities.Request>().Where(req => req.service == "MAINTENANCE");

            return mRequests; 
        }

        public Object getCleaningTasks()
        {
            var mRequests = dc.GetTable<DataLayer.Entities.Request>().Where(req => req.service == "CLEANING");

            return mRequests;
        }
        
        public Object getServiceTasks()
        {
            var mRequests = dc.GetTable<DataLayer.Entities.Request>().Where(req =>req.service == "SERVICE");

            return mRequests;
        }

        public void addBooking(DataLayer.Entities.Booking ent)
        {
            dc.GetTable<DataLayer.Entities.Booking>().InsertOnSubmit(ent);
            dc.SubmitChanges();
        }

        public void addRoom(DataLayer.Entities.Room ent)
        {
            dc.GetTable<DataLayer.Entities.Room>().InsertOnSubmit(ent);
            dc.SubmitChanges();
        }

        public void addCustomer(DataLayer.Entities.Customer ent)
        {
            dc.GetTable<DataLayer.Entities.Customer>().InsertOnSubmit(ent);
            dc.SubmitChanges();
        }
        public void addRequest(DataLayer.Entities.Request ent)
        {
            dc.GetTable<DataLayer.Entities.Request>().InsertOnSubmit(ent);
            dc.SubmitChanges();
        }
        public void addReservation(DataLayer.Entities.ReservationApplication ent)
        {
            dc.GetTable<DataLayer.Entities.ReservationApplication>().InsertOnSubmit(ent);
            dc.SubmitChanges();
        }
        public void addRoomtype(DataLayer.Entities.Roomtype ent)
        {
            dc.GetTable<DataLayer.Entities.Roomtype>().InsertOnSubmit(ent);
            dc.SubmitChanges();
        }

        public Object getReservations()
        {
            var ret = dc.GetTable<DataLayer.Entities.ReservationApplication>();
            return ret;
        }

        public Object getBookings()
        {
            var ret = dc.GetTable<DataLayer.Entities.Booking>();
            return ret;
        }

        public Object getCustomers()
        {
            var ret = dc.GetTable<DataLayer.Entities.Customer>();
            return ret;
        }

        public Object getRooms()
        {
            var ret = dc.GetTable<DataLayer.Entities.Room>();
            return ret;
        }
        
        public Object getUserWithId(int id){
            var ret = dc.GetTable<DataLayer.Entities.Customer>()
                      .Where(cust => cust.cusId == id);
            return ret;
        }

        public Object getVacantRooms(DateTime checkIn, DateTime checkOut)
        {
            var bookings = dc.GetTable<DataLayer.Entities.Booking>();
            var rooms = dc.GetTable<DataLayer.Entities.Room>();
        
        var vacant = rooms.Where
            ((r => bookings.Any(b => checkOut < b.arriveDate || checkIn > b.leaveDate ) 
                || (!bookings.Any(b => b.roomid == r.roomnumber))));

        return vacant;
                              
        }

        public Object getVacantRoomsOfType(DateTime checkIn, DateTime checkOut, int type)
        {
            var bookings = dc.GetTable<DataLayer.Entities.Booking>();
            var rooms = dc.GetTable<DataLayer.Entities.Room>();

            var vacant = rooms.Where
                ((r => bookings.Any(b => checkOut < b.arriveDate || checkIn > b.leaveDate)
                    || (!bookings.Any(b => b.roomid == r.roomnumber))));

            return vacant.Where(r => r.roomtypeid == type);
        }

        public int getVacantRoomsOfTypeBok(DateTime checkIn, DateTime checkOut, int type)
        {
            var bookings = dc.GetTable<DataLayer.Entities.Booking>();
            var rooms = dc.GetTable<DataLayer.Entities.Room>();

            var vacant = rooms.Where
                ((r => bookings.Any(b => checkOut < b.arriveDate || checkIn > b.leaveDate)
                    || (!bookings.Any(b => b.roomid == r.roomnumber))));

            return vacant.Where(r => r.roomtypeid == type).First().roomnumber;
        }

        public void deleteBok(DataLayer.Entities.Booking delBok)
        {
            dc.GetTable<DataLayer.Entities.Booking>().DeleteOnSubmit(delBok);
            dc.SubmitChanges();

        }

        public void deleteResv(DataLayer.Entities.ReservationApplication delResv)
        {
            dc.GetTable<DataLayer.Entities.ReservationApplication>().DeleteOnSubmit(delResv);
            dc.SubmitChanges();
        }

        public void checkIn(int ids)
        {
            DateTime currDatetime = DateTime.Now;
            DataLayer.Entities.Booking currentBok = dc.GetTable<DataLayer.Entities.Booking>().Where(st => st.id.Equals(ids)).First();
            currentBok.checkin = currDatetime;
            dc.SubmitChanges();
        }

        public void checkOut(int ids)
        {
            DateTime currDatetime = DateTime.Now;
            DataLayer.Entities.Booking currentBok = dc.GetTable<DataLayer.Entities.Booking>().Where(st => st.id.Equals(ids)).First();
            currentBok.checkout = currDatetime;
            dc.SubmitChanges();
        }        

    
    }
}
