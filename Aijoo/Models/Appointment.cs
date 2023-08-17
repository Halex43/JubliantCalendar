using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Aijoo.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }

        [DisplayName("Pet Profile")]
        public int PetID { get; set; }

        [DisplayName("Customer Profile")]
        public int CustomerID { get; set; }

        [Required]
        [DisplayName("Appointment Request Date")]
        [DataType(DataType.DateTime)]
        public DateTime AppointmentDate { get; set; }

        [DisplayName("Appointment Type")]
        public int AppointmentType { get; set; }
        public string? Notes { get; set; }
        public string? Status { get; set; }
        public Appointment()
        {

        }
    }
}
