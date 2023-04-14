using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SiteUser
{
    public uint SiteUserId { get; set; }

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = "";

    [Display(Name = "First Name")]
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Password { get; set; } = "";

    [NotMapped]
    [Compare("Password", ErrorMessage = "Passwords do not match")]
    public string PasswordVerify { get; set; } = "";
}