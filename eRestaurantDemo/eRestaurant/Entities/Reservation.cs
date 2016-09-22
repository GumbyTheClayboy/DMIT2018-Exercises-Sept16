using System;

namespace eRestaurant.Entities
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumberInParty { get; set; }
        public string ContactPhone { get; set; }
        public string ReservationStatus { get; set; }
        public string EventCode { get; set; }

        public virtual SpecialEvent Event { get; set; }
    }
}
