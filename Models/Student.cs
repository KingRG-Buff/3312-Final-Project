using System.ComponentModel.DataAnnotations;

namespace _3312_Final_Project.Models;

public class Student
{
    [Display(Name = "Buff ID")]
    public int StudentID {get; set;} // Primary Key
    
    [StringLength(20, ErrorMessage = "First name can't be more than 20 characters.")]
    [Display(Name = "First Name")]
    public string FirstName {get; set;} = string.Empty;
    [StringLength(25, ErrorMessage = "Last name can't be more than 25 Characters.")]
    [Display(Name = "Last Name")]
    public string LastName {get; set;} = string.Empty;
    [EmailAddress]
    public string Email {get; set;} = string.Empty;
    public string Major {get; set;} = string.Empty;
    [Range(2024,2027)]
    [Display(Name = "Graduation Year")]
    public int GradYear {get; set;}

    [Display(Name = "Registered Students")]
    public List<StudentRegistration>? StudentRegistrations {get; set;} = default!; // Navigation property. A student can register for many events
}
