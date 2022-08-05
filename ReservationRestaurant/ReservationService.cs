using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationRestaurant
{
    internal class ReservationService
    {
        private List<Reservation> reservation = new List<Reservation>();
        public void CreateReservation(int reservationID, string reservationName, int reservationLevel, DateTime dateReservation) {
            reservation.Add(new Reservation(reservationID, reservationName, reservationLevel, dateReservation));

        }

        public List<Reservation> GetReservation() {

            return reservation.ToList();
        
        }
    }
}
