using System.ComponentModel.DataAnnotations;

namespace ADL.Data
{
    public class EngineerRequest
    {

        //change to guid
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a First Name")]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter an Email Address")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter a Contact Number")]
        [Display(Name = "Contact Number")]
        public string? ContactNumber { get; set; }

        [Required(ErrorMessage = "Please enter an Address")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Please enter a Town")]
        public string? Town { get; set; }

        [Required(ErrorMessage = "Please enter a Postcode")]
        public string? Postcode { get; set; }

        [Required(ErrorMessage = "Please select an Appointment Date")]
        [DataType(DataType.Date)]
        [DateValidate]
        [Display(Name = "Appointment Date")]
        public DateTime? AppointmentDate { get; set; }

        [Required(ErrorMessage = "Please select an Appointment Time")]
        [Display(Name = "Appointment Time")]
        public string? AppointmentTime { get; set; }

        [Required(ErrorMessage = "Please enter a Vehicle Registration")]
        [StringLength(7, ErrorMessage = "Please enter a valid Vehicle Registration")]
        [Display(Name = "Vehicle Registration")]
        public string? VehicleRegistation { get; set; }

        [Required(ErrorMessage = "Please select a Job Category")]
        [Display(Name = "Job Category")]
        public string? JobCategory { get; set; }

        [StringLength(500, ErrorMessage = "Please enter maximum 500 characters")]
        public string? Comments { get; set; }




    }
}


