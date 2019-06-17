namespace TITReservationHotel.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TITReservationHotel.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TITReservationHotel.Models.ITIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TITReservationHotel.Models.ITIContext context)
        {
            RoomType[] roomTypes = new RoomType[]
            {
                new RoomType{Type="Superior Room", Price=100},
                new RoomType{Type="Suite", Price=200},
                new RoomType{Type="Family Room", Price=300},
                new RoomType{Type="Villas", Price=400}
            };
            context.RoomTypes.AddOrUpdate(roomTypes);
            Room[] rooms = new Room[]
            {
                new Room{Id=1, Name="100"},
                new Room{Id=2, Name="200"},
                new Room{Id=3, Name="300"},
                new Room{Id=4, Name="400"},
                new Room{Id=5, Name="500"},
                new Room{Id=6, Name="600"},
                new Room{Id=7, Name="700"},
                new Room{Id=8, Name="800"},
                new Room{Id=9, Name="900"},
                new Room{Id=10, Name="1000"}
            };
            context.Rooms.AddOrUpdate(rooms);
        }
    }
}
