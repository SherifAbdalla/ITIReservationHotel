using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TITReservationHotel.Models.ViewModel
{
    public class ReservationViewModel
    {
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
        public int Room { get; set; }

        [Required]
        public double RoomType { get; set; }
    }
}