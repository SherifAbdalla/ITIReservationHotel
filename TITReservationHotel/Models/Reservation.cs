using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TITReservationHotel.Models
{
    public class Reservation
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime From { get; set; }

        [Required]
        public DateTime To { get; set; }

        [Required]
        public int Days
        {
            get;
            set;
        }

        [Required]
        public double Cost
        {
            get;
            set;
        }

        [Required]
        public virtual Room Room { get; set; }

        [Required]
        public virtual RoomType RoomType { get; set; }
    }
}