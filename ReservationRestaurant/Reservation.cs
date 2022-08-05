using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationRestaurant
{
    internal class Reservation
    {
        public int ReservationID { get; set; }
        public string ReservationName { get; set; }
        public int ReservationLevel { get; set; }
        public DateTime DateReservation { get; set; }
        public string usuario { get; set; }

        public Reservation(int reservationID,string reservationName, int reservationLevel, DateTime dateReservation) {
        
            this.ReservationID = reservationID;
            this.ReservationName = reservationName;
            this.ReservationLevel = reservationLevel;
            this.DateReservation = dateReservation;
        }
        
    }
}
