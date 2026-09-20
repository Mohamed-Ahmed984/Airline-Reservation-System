using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineManagementApp.Models
{
    public class Flight
    {
        public Flight()
        {
            Passengers = new HashSet<Passenger>();
        }

        public int FlightId { get; set; }

        [Required]
        [StringLength(20)]
        public string FlightNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string OriginCity { get; set; }

        [Required]
        [StringLength(100)]
        public string DestinationCity { get; set; }

        public DateTime DepartureDateTime { get; set; }

        [Required]
        [StringLength(100)]
        public string Airline { get; set; }

        public virtual ICollection<Passenger> Passengers { get; set; }
    }
}
