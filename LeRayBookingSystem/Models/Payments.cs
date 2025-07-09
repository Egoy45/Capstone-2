namespace LeRayBookingSystem.Models
{
    public class Payments
    {
        public string UserId { get; set; }
        public string PaymentId { get; set; }
        public string description { get; set; }

        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public string PaymentMethod { get; set; } // e.g., Credit Card, PayPal

        public string Status { get; set; } // e.g., Completed, Pending, Failed

        public string ReceiptPath { get; set; } // Path to the payment receipt file

        public ApplicationUser User { get; set; } // Navigation property to the user who made the payment

        public Payments()
        {
            PaymentDate = DateTime.Now; // Set default payment date to now
            Status = "Pending"; // Default status
        }
    }
}
