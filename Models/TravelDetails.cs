using System.ComponentModel.DataAnnotations;

namespace Travelogue03.Models
{
    public class TravelDetails
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name must be between 1 and 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name must be between 1 and 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Destination is required")]
        [StringLength(100, ErrorMessage = "Destination must be between 1 and 100 characters")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Budget is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Budget must be a positive number")]
        public int Budget { get; set; }

        [Required(ErrorMessage = "Number of people is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Number of people must be at least 1")]
        public int NumPeople { get; set; }

        [StringLength(500, ErrorMessage = "Special requests must be at most 500 characters")]
        public string SpecialRequests { get; set; }
    }
}
