namespace LeRayBookingSystem.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string ServiceName { get; set; }
        public string Status { get; set; } // Pending, Approved, Cancelled
        public string PaymentReceiptPath { get; set; }
        public string PaymentStatus { get; set; } // Paid, Unpaid
        public DateTime CreatedAt { get; set; } // Timestamp of when the appointment was created
        public DateTime UpdatedAt { get; set; } // Timestamp of when the appointment was last updated
        public DateTime LastUpdatedAt { get; set; } // Timestamp of the last update to the appointment
        public Appointment()
        {
            CreatedAt = DateTime.Now; // Set default creation date to now
            UpdatedAt = DateTime.Now; // Set default updated date to now
            LastUpdatedAt = DateTime.Now; // Set default last updated date to now
        }
        public string Notes { get; set; } // Additional notes for the appointment
        public string ServiceId { get; set; } // Foreign key to the Service
        public Service Service { get; set; } // Navigation property to the Service
        public string PromoCode { get; set; } // Optional promo code applied to the appointment
        public Promos Promo { get; set; } // Navigation property to the Promo
        public string PaymentMethod { get; set; } // Method of payment (e.g., Credit Card, Cash)
        public string PaymentId { get; set; } // Unique identifier for the payment transaction
        public string CreatedBy { get; set; } // UserId of the creator
        public ApplicationUser CreatedByUser { get; set; } // Navigation property to the user who created the appointment
        public string UpdatedBy { get; set; } // UserId of the user who last updated the appointment
        public ApplicationUser UpdatedByUser { get; set; } // Navigation property to the user who last updated the appointment
        public string LastUpdatedBy { get; set; } // UserId of the user who last updated the appointment
        public ApplicationUser LastUpdatedByUser { get; set; } // Navigation property to the user who last updated the appointment
        public string CancellationReason { get; set; } // Reason for cancellation, if applicable
        public Appointment(string userId, string serviceName, string paymentMethod)
        {
            UserId = userId;
            ServiceName = serviceName;
            PaymentMethod = paymentMethod;
            Status = "Pending"; // Default status is Pending
            PaymentStatus = "Unpaid"; // Default payment status is Unpaid
            CreatedAt = DateTime.Now; // Set default creation date to now
            UpdatedAt = DateTime.Now; // Set default updated date to now
            LastUpdatedAt = DateTime.Now; // Set default last updated date to now
            AppointmentDate = DateTime.Now; // Default appointment date is now
            Notes = string.Empty; // Initialize notes as an empty string
            CancellationReason = string.Empty; // Initialize cancellation reason as an empty string
            PromoCode = string.Empty; // Initialize promo code as an empty string
            PaymentId = Guid.NewGuid().ToString(); // Generate a unique payment ID
            CreatedBy = userId; // Set the creator to the current user
            CreatedByUser = null; // Initialize navigation property to null
            UpdatedBy = userId; // Set the updater to the current user
            UpdatedByUser = null; // Initialize navigation property to null
            LastUpdatedBy = userId; // Set the last updater to the current user
            LastUpdatedByUser = null; // Initialize navigation property to null

        }
        public Appointment(int id, string userId, string serviceName, DateTime appointmentDate, string status, string paymentReceiptPath, string paymentStatus, string notes, string serviceId, string promoCode, string paymentMethod)
        {
            Id = id;
            UserId = userId;
            ServiceName = serviceName;
            AppointmentDate = appointmentDate;
            Status = status;
            PaymentReceiptPath = paymentReceiptPath;
            PaymentStatus = paymentStatus;
            Notes = notes;
            ServiceId = serviceId;
            PromoCode = promoCode;
            PaymentMethod = paymentMethod;
            CreatedAt = DateTime.Now; // Set default creation date to now
            UpdatedAt = DateTime.Now; // Set default updated date to now
            LastUpdatedAt = DateTime.Now; // Set default last updated date to now
        }

    }
}
