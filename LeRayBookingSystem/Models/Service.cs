namespace LeRayBookingSystem.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public TimeSpan Duration { get; set; }

        public string CreatedBy { get; set; } // UserId of the creator
        public ApplicationUser CreatedByUser { get; set; } // Navigation property to the user who created the service
        public DateTime CreatedAt { get; set; } // Timestamp of when the service was created
       
        public DateTime UpdatedAt { get; set; } // Timestamp of when the service was last updated
        public DateTime LastUpdatedAt { get; set; } // Timestamp of the last update to the service
        public string UpdatedBy { get; set; } // UserId of the user who last updated the service
        public string LastUpdatedBy { get; set; } // UserId of the user who last updated the service
        public ApplicationUser UpdatedByUser { get; set; } // Navigation property to the user who last updated the service
        public ApplicationUser LastUpdatedByUser { get; set; } // Navigation property to the user who last updated the service
        public string ServiceId { get; set; } // Unique identifier for the service
        public string ServiceName { get; set; }

        public string ImagePath { get; set; } // Path to the service image
        public string Category { get; set; } // Category of the service (e.g., Hair, Nails, Massage)
        public bool IsActive { get; set; } // Indicates if the service is currently active
        public Service()
        {
            IsActive = true; // Default status is active
            CreatedAt = DateTime.Now; // Set default creation date to now

        }
    }
}

