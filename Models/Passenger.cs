using System.ComponentModel.DataAnnotations;

namespace AirlineManagementApp.Models
{
    public class Passenger
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public int TripNO { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNum { get; set; }

        public int PassportNum { get; set; }

        [Required]
        [StringLength(100)]
        public string Nationality { get; set; }

        public int? FlightId { get; set; }

        public virtual Flight Flight { get; set; }
    }
}
