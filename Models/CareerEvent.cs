using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

namespace _3312_Final_Project.Models;

public class CareerEvent
{
     public int CareerEventID {get; set;} // Primary Key
    
    [StringLength(45)]
    [Display(Name = "Event_Name")]
    public string EventName {get; set;} = string.Empty;
    
    [DataType(DataType.Date)]
    [Display(Name = "Event_Date")]
    public DateTime EventDate { get; set; }

    [Display(Name = "Location")]
    public string EventLocation {get; set;} = string.Empty;
    
    [Display(Name = "Event_Information")]
    public string EventDescription {get; set;} = string.Empty;

    [Display(Name = "Student_Registrations")]
    public List<StudentRegistration>? StudentRegistrations {get; set;} = default!; // Navigation property. A student can register for many events
}

public class StudentRegistration
{
    public int CareerEventID {get; set;} // Composite Primary Key, Foreign Key 1
    public int StudentID{get; set;} // Composite Primary Key, Foreign Key 2
    public Student Student {get; set;} = default!; //Navigation property
    public CareerEvent CareerEvent {get; set;} = default!; //Navigation Property
    
    [DataType(DataType.Date)]
    [Display(Name = "Date Registered")]
    public DateTime RegisteredDate { get; set; }
}