using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TITReservationHotel.Models
{
    public class RoomType
    {

        [Required]
        public string Type { get; set; }

        [Key]
        public double Price { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}