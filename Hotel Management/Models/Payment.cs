using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.Models
{
    public enum PaymentStatus
    {
        Pending, 
        Paid
    }

    public enum PMethod
    {
        CreditCard, 
        Cash, 
    }
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public Double Amount { get; set; }

        [Required]
        public PMethod PaymentMethod { get; set; } // E.g., "Credit Card", "Cash"

        [Required]
        public PaymentStatus Status { get; set; }
    }
}
