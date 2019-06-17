using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TITReservationHotel.Models;
using TITReservationHotel.Models.ViewModel;

namespace TITReservationHotel.Controllers
{
    public class RoomController : Controller
    {
        private ITIContext context = new ITIContext();

        // GET: Room
        public ActionResult Index()
        {
            IEnumerable<RoomType> roomTypes = context.RoomTypes;
            ViewBag.RoomTypes = new SelectList(roomTypes, "Price", "Type");
            IEnumerable<Room> rooms = context.Rooms;
            ViewBag.Rooms = new SelectList(rooms, "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Reservation(ReservationViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            Room room = context.Rooms.FirstOrDefault(r => r.Id == viewModel.Room);
            RoomType roomType = context.RoomTypes.FirstOrDefault(t => t.Price == viewModel.RoomType);
            Reservation reservation = new Reservation()
            {
                To = viewModel.To,
                From = viewModel.From,
                Days = viewModel.Days,
                Cost = viewModel.Cost,
                Room = room,
                RoomType = roomType
            };
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public PartialViewResult ReservationReviews()
        {
            var reservations = context.Reservations.ToList();
            return PartialView("_ReservationReviews", reservations);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Reservation reservation = context.Reservations.FirstOrDefault(r => r.Id == id);
            if(reservation != null)
            {
                context.Reservations.Remove(reservation);
                context.SaveChanges();
            }
            return Json(new { data = reservation}, JsonRequestBehavior.AllowGet);
        }
    }
}