namespace LeRayBookingSystem.Models
{
    public class AuditLog
    {
        public string Id { get; set; } // Unique identifier for the audit log entry
        public string Action { get; set; } // Description of the action performed (e.g., "Created", "Updated", "Deleted")
        public string UserId { get; set; } // UserId of the user who performed the action
        public ApplicationUser User { get; set; } // Navigation property to the user who performed the action
        public DateTime Timestamp { get; set; } // Timestamp of when the action was performed
        public string EntityType { get; set; } // Type of entity affected by the action (e.g., "Service", "Booking", "Payment")
        public string EntityId { get; set; } // Unique identifier of the entity affected by the action
        public string Details { get; set; } // Additional details about the action, if any
        public AuditLog()
        {
            Id = Guid.NewGuid().ToString(); // Generate a new unique identifier
            Timestamp = DateTime.Now; // Set the timestamp to the current time
        }
        // Default constructor for the Auditlog class
        // Initializes the Id and Timestamp properties
    }
}

