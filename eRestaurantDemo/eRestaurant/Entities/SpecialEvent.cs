using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace eRestaurant.Entities
{
    public class SpecialEvent
    {
        [Key]
        public string EventCode { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
