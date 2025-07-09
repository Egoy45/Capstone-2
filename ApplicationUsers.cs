namespace LeRayBookingSystem.Models;

using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; }
    public string Gender { get; set; }
    public DateTime DateJoined { get; set; }
    public string ProfilePicturePath { get; set; } // Path to the user's profile picture
    public string ProfilePictureUrl { get; set; } // URL to the user's profile picture
    
    public string Address { get; set; } // User's address
    public string PhoneNumber { get; set; } // User's phone number
    public string Bio { get; set; } // Short biography or description of the user
    public string Occupation { get; set; } // User's occupation or job title
    public string SocialMediaLinks { get; set; } // Links to the user's social media profiles
    public DateTime LastLogin { get; set; } // Timestamp of the user's last login
    public DateTime CreatedAt { get; set; } // Timestamp of when the user was created
    public DateTime UpdatedAt { get; set; } // Timestamp of when the user was last updated
    public ApplicationUser()
    {
        DateJoined = DateTime.Now; // Set default date joined to now
        CreatedAt = DateTime.Now; // Set default creation date to now
        UpdatedAt = DateTime.Now; // Set default updated date to now
        LastLogin = DateTime.Now; // Set default last login to now
    }
    public string ProfilePictureFileName { get; set; }
    public string ProfilePictureFilePath { get; set; }
    public string ProfilePictureContentType { get; set; }
    public string ProfilePictureFileSize { get; set; } // Optional, for display/validation
    public string ProfilePictureAltText { get; set; } // Optional, accessibility

    public string ProfilePictureThumbnailFileName { get; set; }
    public string ProfilePictureThumbnailFilePath { get; set; }
    public string ProfilePictureThumbnailUrl { get; set; }
    public string ProfilePictureThumbnailContentType { get; set; }

}

