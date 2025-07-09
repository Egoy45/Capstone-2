namespace LeRayBookingSystem.Models
{
    public class Promos
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public TimeSpan Duration { get; set; }
        public string PromoCode { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; } // Indicates if the promo is currently active
        public string CreatedBy { get; set; } // UserId of the creator
        public ApplicationUser CreatedByUser { get; set; } // Navigation property to the user who created the promo
        public DateTime CreatedAt { get; set; } // Timestamp of when the promo was created
        public Promos()
        {
            CreatedAt = DateTime.Now; // Set default creation date to now
            IsActive = true; // Default status is active
        }
           
    }
}
