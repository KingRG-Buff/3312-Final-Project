using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

namespace _3312_Final_Project.Models;

public class CareerEvent
{
     public int CareerEventID {get; set;} // Primary Key
    
    [StringLength(45)]
    [Display(Name = "Event Name")]
    public string EventName {get; set;} = string.Empty;
    
    [DataType(DataType.Date)]
    [Display(Name = "Event Date")]
    public DateTime EventDate { get; set; }

    [Display(Name = "Location")]
    public string EventLocation {get; set;} = string.Empty;
    
    [Display(Name = "Event Information")]
    public string EventDescription {get; set;} = string.Empty;
}