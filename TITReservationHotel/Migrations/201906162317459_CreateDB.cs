namespace TITReservationHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                        Days = c.Int(nullable: false),
                        Cost = c.Double(nullable: false),
                        Room_Id = c.Int(nullable: false),
                        RoomType_Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.Room_Id, cascadeDelete: true)
                .ForeignKey("dbo.RoomTypes", t => t.RoomType_Price, cascadeDelete: true)
                .Index(t => t.Room_Id)
                .Index(t => t.RoomType_Price);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        Price = c.Double(nullable: false),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Price);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "RoomType_Price", "dbo.RoomTypes");
            DropForeignKey("dbo.Reservations", "Room_Id", "dbo.Rooms");
            DropIndex("dbo.Reservations", new[] { "RoomType_Price" });
            DropIndex("dbo.Reservations", new[] { "Room_Id" });
            DropTable("dbo.RoomTypes");
            DropTable("dbo.Rooms");
            DropTable("dbo.Reservations");
        }
    }
}
