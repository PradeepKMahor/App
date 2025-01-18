using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Api.Dtos
{
    public class RegisterDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string? Username { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? MiddleName { get; set; }

        [Required]
        public string? LastName { get; set; } = string.Empty;

        [Required]
        public string? City { get; set; } = string.Empty;

        [Required]
        public string? State { get; set; } = string.Empty;

        [Required]
        public string? Country { get; set; } = string.Empty;

        [Required]
        [PasswordPropertyText]
        public string Password { get; set; } = string.Empty;

        public int? PostalCode { get; set; }
        public string? SkillOrOccupation { get; set; } = string.Empty;

        public string? Biography { get; set; } = string.Empty;
        public string? StreetAddress { get; set; } = string.Empty;

        public string? ProfilePhoto { get; set; } = string.Empty;
        public string? CoverPhoto { get; set; } = string.Empty;
        public string? FacebookLink { get; set; } = string.Empty;
        public string? TwitterLink { get; set; } = string.Empty;
        public string? LinkedinLink { get; set; } = string.Empty;
        public string? WebsiteLink { get; set; } = string.Empty;
        public string? GitHubLink { get; set; } = string.Empty;
        public List<string>? Roles { get; set; }
    }
}