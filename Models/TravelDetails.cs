using System.ComponentModel.DataAnnotations;

namespace Travelogue03.Models
{
    public class TravelDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; } // Changed to string for flexibility in phone number format

        public string Destination { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public int Budget { get; set; }
        public int NumPeople { get; set; }
        public string SpecialRequests { get; set; }
    }
}
