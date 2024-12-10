using System.ComponentModel.DataAnnotations;

namespace _3312_Final_Project.Pages.Models
{
    public class Student
    {
        public int StudentID {get; set;} // Primary Key
        [StringLength(20)]
        public string FirstName {get; set;} = string.Empty;
        [StringLength(50)]
        public string LastName {get; set;} = string.Empty;
        public string Email {get; set;} = string.Empty;
        public string Major {get; set;} = string.Empty;
        [Range(2024,2027)]
        public int GradYear {get; set;}
        [Required] //Registration Requirement "Resume Reviewed" must be reviewed and marked Yes or No
        public bool ResumeReview {get; set;}
    }
}