namespace LeRayBookingSystem.Models
{
    public class Feedback
    {
        public string Id { get; set; }
        public string description { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; } // Navigation property to the user who provided the feedback
        public DateTime CreatedAt { get; set; } // Timestamp of when the feedback was created
        public DateTime UpdatedAt { get; set;} // Timestamp of when the feedback was last updated
    }
}
