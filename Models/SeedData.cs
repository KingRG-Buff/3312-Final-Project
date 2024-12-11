using Microsoft.EntityFrameworkCore;

namespace _3312_Final_Project.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new EventDbContext(serviceProvider.GetRequiredService<DbContextOptions<EventDbContext>>());

        if (context.Events.Any()) 
        {
            return;
        }
        //Seed data provided by generative AI, following my example for Meet The Accountants
        context.Events.AddRange(
            new Event { EventName = "Meet The Accountants", EventDate = DateTime.Parse("02/25/2025"), EventLocation = "Legacy Hall", EventDescription = "Meet the Accountants is a networking event that connects accounting and finance students with potential employers in the field." },
            new Event { EventName = "Tech Careers Expo", EventDate = DateTime.Parse("03/10/2025"), EventLocation = "Engineering Building", EventDescription = "Explore career opportunities in the tech industry with top companies." },
            new Event { EventName = "Healthcare Networking Night", EventDate = DateTime.Parse("03/15/2025"), EventLocation = "Health Sciences Auditorium", EventDescription = "Network with professionals in the healthcare sector and learn about career paths." },
            new Event { EventName = "Creative Careers Fair", EventDate = DateTime.Parse("03/20/2025"), EventLocation = "Fine Arts Center", EventDescription = "An event tailored for students interested in design, arts, and creative industries." },
            new Event { EventName = "Summer Internship Kickoff", EventDate = DateTime.Parse("04/05/2025"), EventLocation = "Student Center", EventDescription = "Kick off your summer with exclusive internship opportunities." },
            new Event { EventName = "Resume Workshop", EventDate = DateTime.Parse("01/25/2025"), EventLocation = "Career Center", EventDescription = "Enhance your resume with guidance from industry experts." },
            new Event { EventName = "LinkedIn Profile Optimization", EventDate = DateTime.Parse("02/01/2025"), EventLocation = "Library Lab A", EventDescription = "Learn to create a standout LinkedIn profile for recruiters." },
            new Event { EventName = "Mock Interview Day", EventDate = DateTime.Parse("02/15/2025"), EventLocation = "Business School Conference Room", EventDescription = "Practice interviews with professionals to sharpen your skills." },
            new Event { EventName = "Diversity in STEM", EventDate = DateTime.Parse("03/05/2025"), EventLocation = "Innovation Hub", EventDescription = "A panel discussion and networking event focusing on diversity in STEM fields." },
            new Event { EventName = "Start-up Showcase", EventDate = DateTime.Parse("03/25/2025"), EventLocation = "Main Quad", EventDescription = "Meet founders and learn about exciting start-ups in various industries." },
            new Event { EventName = "Finance Career Pathways", EventDate = DateTime.Parse("04/10/2025"), EventLocation = "Financial Services Hall", EventDescription = "A networking event for students interested in finance and banking." },
            new Event { EventName = "Government & Nonprofit Career Fair", EventDate = DateTime.Parse("04/20/2025"), EventLocation = "Civic Center", EventDescription = "Connect with government and nonprofit organizations offering career opportunities." },
            new Event { EventName = "Cybersecurity Roundtable", EventDate = DateTime.Parse("05/01/2025"), EventLocation = "Tech Lab 1", EventDescription = "Discuss the latest trends and opportunities in cybersecurity." },
            new Event { EventName = "MBA Info Session", EventDate = DateTime.Parse("05/15/2025"), EventLocation = "Graduate School Lobby", EventDescription = "Learn about MBA programs and how to apply." },
            new Event { EventName = "Entrepreneurship Meet-Up", EventDate = DateTime.Parse("05/25/2025"), EventLocation = "Business Incubator", EventDescription = "Meet like-minded entrepreneurs and share ideas for startups." },
            new Event { EventName = "Career Bootcamp", EventDate = DateTime.Parse("06/01/2025"), EventLocation = "Fitness Hall", EventDescription = "A full-day workshop to build your career readiness skills." },
            new Event { EventName = "Alumni Networking Night", EventDate = DateTime.Parse("06/15/2025"), EventLocation = "Alumni Hall", EventDescription = "Connect with alumni and learn from their professional journeys." },
            new Event { EventName = "Women in Leadership", EventDate = DateTime.Parse("06/20/2025"), EventLocation = "Executive Hall", EventDescription = "An event celebrating women leaders and their achievements." },
            new Event { EventName = "Retail Careers Forum", EventDate = DateTime.Parse("06/25/2025"), EventLocation = "Mall Atrium", EventDescription = "Explore careers in the retail industry with major brands." },
            new Event { EventName = "End-of-Year Career Celebration", EventDate = DateTime.Parse("07/01/2025"), EventLocation = "Campus Green", EventDescription = "Celebrate the end of the year with employers, students, and faculty." }
        );

        context.SaveChanges();
    }
}