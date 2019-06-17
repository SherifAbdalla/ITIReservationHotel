using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TITReservationHotel.Models
{
    public class ITIContext :DbContext
    {
        public ITIContext
            () : base("HotelConn") { }
        
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}