using Microsoft.EntityFrameworkCore;

namespace _3312_Final_Project.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new CareerEventDbContext(serviceProvider.GetRequiredService<DbContextOptions<CareerEventDbContext>>());

        if (context.CareerEvents.Any()) 
        {
            return;
        }
        //Seed data provided by generative AI, following my example for Meet The Accountants
        context.CareerEvents.AddRange(
            new CareerEvent { EventName = "Meet The Accountants", EventDate = DateTime.Parse("02/25/2025"), EventLocation = "Legacy Hall", EventDescription = "Meet the Accountants is a networking event that connects accounting and finance students with potential employers in the field." },
            new CareerEvent { EventName = "Tech Careers Expo", EventDate = DateTime.Parse("03/10/2025"), EventLocation = "Engineering Building", EventDescription = "Explore career opportunities in the tech industry with top companies." },
            new CareerEvent { EventName = "Healthcare Networking Night", EventDate = DateTime.Parse("03/15/2025"), EventLocation = "Health Sciences Auditorium", EventDescription = "Network with professionals in the healthcare sector and learn about career paths." },
            new CareerEvent { EventName = "Creative Careers Fair", EventDate = DateTime.Parse("03/20/2025"), EventLocation = "Fine Arts Center", EventDescription = "An event tailored for students interested in design, arts, and creative industries." },
            new CareerEvent { EventName = "Summer Internship Kickoff", EventDate = DateTime.Parse("04/05/2025"), EventLocation = "Student Center", EventDescription = "Kick off your summer with exclusive internship opportunities." },
            new CareerEvent { EventName = "Resume Workshop", EventDate = DateTime.Parse("01/25/2025"), EventLocation = "Career Center", EventDescription = "Enhance your resume with guidance from industry experts." },
            new CareerEvent { EventName = "LinkedIn Profile Optimization", EventDate = DateTime.Parse("02/01/2025"), EventLocation = "Library Lab A", EventDescription = "Learn to create a standout LinkedIn profile for recruiters." },
            new CareerEvent { EventName = "Mock Interview Day", EventDate = DateTime.Parse("02/15/2025"), EventLocation = "Business School Conference Room", EventDescription = "Practice interviews with professionals to sharpen your skills." },
            new CareerEvent { EventName = "Diversity in STEM", EventDate = DateTime.Parse("03/05/2025"), EventLocation = "Innovation Hub", EventDescription = "A panel discussion and networking event focusing on diversity in STEM fields." },
            new CareerEvent { EventName = "Start-up Showcase", EventDate = DateTime.Parse("03/25/2025"), EventLocation = "Main Quad", EventDescription = "Meet founders and learn about exciting start-ups in various industries." },
            new CareerEvent { EventName = "Finance Career Pathways", EventDate = DateTime.Parse("04/10/2025"), EventLocation = "Financial Services Hall", EventDescription = "A networking event for students interested in finance and banking." },
            new CareerEvent { EventName = "Government & Nonprofit Career Fair", EventDate = DateTime.Parse("04/20/2025"), EventLocation = "Civic Center", EventDescription = "Connect with government and nonprofit organizations offering career opportunities." },
            new CareerEvent { EventName = "Cybersecurity Roundtable", EventDate = DateTime.Parse("05/01/2025"), EventLocation = "Tech Lab 1", EventDescription = "Discuss the latest trends and opportunities in cybersecurity." },
            new CareerEvent { EventName = "MBA Info Session", EventDate = DateTime.Parse("05/15/2025"), EventLocation = "Graduate School Lobby", EventDescription = "Learn about MBA programs and how to apply." },
            new CareerEvent { EventName = "Entrepreneurship Meet-Up", EventDate = DateTime.Parse("05/25/2025"), EventLocation = "Business Incubator", EventDescription = "Meet like-minded entrepreneurs and share ideas for startups." },
            new CareerEvent { EventName = "Career Bootcamp", EventDate = DateTime.Parse("06/01/2025"), EventLocation = "Fitness Hall", EventDescription = "A full-day workshop to build your career readiness skills." },
            new CareerEvent { EventName = "Alumni Networking Night", EventDate = DateTime.Parse("06/15/2025"), EventLocation = "Alumni Hall", EventDescription = "Connect with alumni and learn from their professional journeys." },
            new CareerEvent { EventName = "Women in Leadership", EventDate = DateTime.Parse("06/20/2025"), EventLocation = "Executive Hall", EventDescription = "An event celebrating women leaders and their achievements." },
            new CareerEvent { EventName = "Retail Careers Forum", EventDate = DateTime.Parse("06/25/2025"), EventLocation = "Mall Atrium", EventDescription = "Explore careers in the retail industry with major brands." },
            new CareerEvent { EventName = "End-of-Year Career Celebration", EventDate = DateTime.Parse("07/01/2025"), EventLocation = "Campus Green", EventDescription = "Celebrate the end of the year with employers, students, and faculty." }
        );
        context.SaveChanges();

        List<Student> students = new List<Student>
        {
            new Student { FirstName = "Bucky", LastName = "Buffalo", Email = "bbuffalo1@buffs.edu", Major = "Animal Science", GradYear = 2025, ResumeReview = true },
            new Student { FirstName = "Ella", LastName = "Waters", Email = "ewaters1@buffs.edu", Major = "Computer Science", GradYear = 2026, ResumeReview = true },
            new Student { FirstName = "James", LastName = "Smith", Email = "jsmith1@buffs.edu", Major = "Accounting", GradYear = 2025, ResumeReview = false },
            new Student { FirstName = "Sophia", LastName = "Lopez", Email = "slopez1@buffs.edu", Major = "Finance", GradYear = 2027, ResumeReview = true },
            new Student { FirstName = "Liam", LastName = "Johnson", Email = "ljohnson1@buffs.edu", Major = "Healthcare Administration", GradYear = 2025, ResumeReview = true },
            new Student { FirstName = "Olivia", LastName = "Brown", Email = "obrown1@buffs.edu", Major = "Graphic Design", GradYear = 2026, ResumeReview = false },
            new Student { FirstName = "Noah", LastName = "Williams", Email = "nwilliams1@buffs.edu", Major = "Cybersecurity", GradYear = 2026, ResumeReview = true },
            new Student { FirstName = "Emma", LastName = "Davis", Email = "edavis1@buffs.edu", Major = "Marketing", GradYear = 2027, ResumeReview = true },
            new Student { FirstName = "Ava", LastName = "Garcia", Email = "agarcia1@buffs.edu", Major = "Business Management", GradYear = 2026, ResumeReview = false },
            new Student { FirstName = "William", LastName = "Martinez", Email = "wmartinez1@buffs.edu", Major = "Data Science", GradYear = 2025, ResumeReview = true },
            new Student { FirstName = "Isabella", LastName = "Hernandez", Email = "ihernandez1@buffs.edu", Major = "Art", GradYear = 2026, ResumeReview = false },
            new Student { FirstName = "Elijah", LastName = "Gonzalez", Email = "egonzalez1@buffs.edu", Major = "Finance", GradYear = 2025, ResumeReview = true },
            new Student { FirstName = "Mia", LastName = "Wilson", Email = "mwilson1@buffs.edu", Major = "Entrepreneurship", GradYear = 2027, ResumeReview = true },
            new Student { FirstName = "Alexander", LastName = "Anderson", Email = "aanderson1@buffs.edu", Major = "Computer Science", GradYear = 2026, ResumeReview = true },
            new Student { FirstName = "Charlotte", LastName = "Moore", Email = "cmoore1@buffs.edu", Major = "Economics", GradYear = 2025, ResumeReview = false },
            new Student { FirstName = "Amelia", LastName = "Taylor", Email = "ataylor1@buffs.edu", Major = "Healthcare Administration", GradYear = 2026, ResumeReview = true },
            new Student { FirstName = "Harper", LastName = "Thomas", Email = "hthomas1@buffs.edu", Major = "Graphic Design", GradYear = 2027, ResumeReview = true },
            new Student { FirstName = "Ethan", LastName = "Lee", Email = "elee1@buffs.edu", Major = "Cybersecurity", GradYear = 2025, ResumeReview = true },
            new Student { FirstName = "Lucas", LastName = "Harris", Email = "lharris1@buffs.edu", Major = "Finance", GradYear = 2026, ResumeReview = false },
            new Student { FirstName = "Mason", LastName = "Clark", Email = "mclark1@buffs.edu", Major = "Accounting", GradYear = 2025, ResumeReview = true },
            new Student { FirstName = "Scarlett", LastName = "Walker", Email = "swalker1@buffs.edu", Major = "Marketing", GradYear = 2027, ResumeReview = true },
            new Student { FirstName = "Henry", LastName = "Hall", Email = "hhall1@buffs.edu", Major = "Data Science", GradYear = 2026, ResumeReview = false },
            new Student { FirstName = "Grace", LastName = "Young", Email = "gyoung1@buffs.edu", Major = "Economics", GradYear = 2025, ResumeReview = true },
            new Student { FirstName = "Victoria", LastName = "Allen", Email = "vallen1@buffs.edu", Major = "Art", GradYear = 2026, ResumeReview = true },
            new Student { FirstName = "Daniel", LastName = "King", Email = "dking1@buffs.edu", Major = "Entrepreneurship", GradYear = 2025, ResumeReview = true },
            new Student { FirstName = "Madison", LastName = "Green", Email = "mgreen1@buffs.edu", Major = "Computer Science", GradYear = 2026, ResumeReview = false },
            new Student { FirstName = "Levi", LastName = "Baker", Email = "lbaker1@buffs.edu", Major = "Healthcare Administration", GradYear = 2027, ResumeReview = true },
            new Student { FirstName = "Evelyn", LastName = "Nelson", Email = "enelson1@buffs.edu", Major = "Marketing", GradYear = 2025, ResumeReview = true },
            new Student { FirstName = "Hannah", LastName = "Carter", Email = "hcarter1@buffs.edu", Major = "Finance", GradYear = 2026, ResumeReview = true },
            new Student { FirstName = "Lillian", LastName = "Mitchell", Email = "lmitchell1@buffs.edu", Major = "Cybersecurity", GradYear = 2025, ResumeReview = false },
            new Student { FirstName = "David", LastName = "Perez", Email = "dperez1@buffs.edu", Major = "Economics", GradYear = 2027, ResumeReview = true },
            new Student { FirstName = "Zoey", LastName = "Roberts", Email = "zroberts1@buffs.edu", Major = "Graphic Design", GradYear = 2025, ResumeReview = true },
            new Student { FirstName = "Wyatt", LastName = "Turner", Email = "wturner1@buffs.edu", Major = "Art", GradYear = 2026, ResumeReview = true },
            new Student { FirstName = "Aubrey", LastName = "Phillips", Email = "aphillips1@buffs.edu", Major = "Marketing", GradYear = 2027, ResumeReview = false },
            new Student { FirstName = "Samuel", LastName = "Campbell", Email = "scampbell1@buffs.edu", Major = "Finance", GradYear = 2026, ResumeReview = true },
            new Student { FirstName = "Sofia", LastName = "Parker", Email = "sparker1@buffs.edu", Major = "Entrepreneurship", GradYear = 2027, ResumeReview = true },
            new Student { FirstName = "Owen", LastName = "Evans", Email = "oemans1@buffs.edu", Major = "Accounting", GradYear = 2025, ResumeReview = true },
            new Student { FirstName = "Layla", LastName = "Edwards", Email = "ledwards1@buffs.edu", Major = "Data Science", GradYear = 2026, ResumeReview = false },
            new Student { FirstName = "Eliana", LastName = "Collins", Email = "ecollins1@buffs.edu", Major = "Graphic Design", GradYear = 2025, ResumeReview = true },
            new Student { FirstName = "Luke", LastName = "Stewart", Email = "lstewart1@buffs.edu", Major = "Cybersecurity", GradYear = 2026, ResumeReview = true },
            new Student { FirstName = "Aria", LastName = "Morris", Email = "amorris1@buffs.edu", Major = "Economics", GradYear = 2027, ResumeReview = true },
            new Student { FirstName = "Gabriel", LastName = "Rogers", Email = "grogers1@buffs.edu", Major = "Healthcare Administration", GradYear = 2025, ResumeReview = false },
            new Student { FirstName = "Chloe", LastName = "Reed", Email = "creed1@buffs.edu", Major = "Art", GradYear = 2027, ResumeReview = true },
            new Student { FirstName = "Carter", LastName = "Cook", Email = "ccook1@buffs.edu", Major = "Business Management", GradYear = 2026, ResumeReview = true }
        };
        context.AddRange(students);
        context.SaveChanges();

        List<StudentRegistration> studentRegistrations = new List<StudentRegistration>
        {
            // Student 1 assigned to 2 events
            new StudentRegistration { StudentID = 1, CareerEventID = 5 },
            new StudentRegistration { StudentID = 1, CareerEventID = 7 },

            // Student 2 assigned to 1 event
            new StudentRegistration { StudentID = 2, CareerEventID = 2 },

            // Student 3 assigned to 3 events
            new StudentRegistration { StudentID = 3, CareerEventID = 1 },
            new StudentRegistration { StudentID = 3, CareerEventID = 6 },
            new StudentRegistration { StudentID = 3, CareerEventID = 8 },

            // Student 4 assigned to 2 events
            new StudentRegistration { StudentID = 4, CareerEventID = 4 },
            new StudentRegistration { StudentID = 4, CareerEventID = 9 },

            // Student 5 assigned to 3 events
            new StudentRegistration { StudentID = 5, CareerEventID = 5 },
            new StudentRegistration { StudentID = 5, CareerEventID = 10 },
            new StudentRegistration { StudentID = 5, CareerEventID = 12 },

            // Student 6 assigned to 1 event
            new StudentRegistration { StudentID = 6, CareerEventID = 11 },

            // Student 7 assigned to 2 events
            new StudentRegistration { StudentID = 7, CareerEventID = 3 },
            new StudentRegistration { StudentID = 7, CareerEventID = 14 },

            // Student 8 assigned to 3 events
            new StudentRegistration { StudentID = 8, CareerEventID = 2 },
            new StudentRegistration { StudentID = 8, CareerEventID = 13 },
            new StudentRegistration { StudentID = 8, CareerEventID = 15 },

            // Student 9 assigned to 1 event
            new StudentRegistration { StudentID = 9, CareerEventID = 6 },

            // Student 10 assigned to 3 events
            new StudentRegistration { StudentID = 10, CareerEventID = 10 },
            new StudentRegistration { StudentID = 10, CareerEventID = 12 },
            new StudentRegistration { StudentID = 10, CareerEventID = 17 },

            // Student 11 assigned to 2 events
            new StudentRegistration { StudentID = 11, CareerEventID = 4 },
            new StudentRegistration { StudentID = 11, CareerEventID = 14 },

            // Student 12 assigned to 3 events
            new StudentRegistration { StudentID = 12, CareerEventID = 1 },
            new StudentRegistration { StudentID = 12, CareerEventID = 9 },
            new StudentRegistration { StudentID = 12, CareerEventID = 16 },

            // Student 13 assigned to 2 events
            new StudentRegistration { StudentID = 13, CareerEventID = 2 },
            new StudentRegistration { StudentID = 13, CareerEventID = 8 },

            // Student 14 assigned to 3 events
            new StudentRegistration { StudentID = 14, CareerEventID = 5 },
            new StudentRegistration { StudentID = 14, CareerEventID = 6 },
            new StudentRegistration { StudentID = 14, CareerEventID = 18 },

            // Student 15 assigned to 1 event
            new StudentRegistration { StudentID = 15, CareerEventID = 11 },

            // Student 16 assigned to 2 events
            new StudentRegistration { StudentID = 16, CareerEventID = 4 },
            new StudentRegistration { StudentID = 16, CareerEventID = 13 },

            // Student 17 assigned to 3 events
            new StudentRegistration { StudentID = 17, CareerEventID = 2 },
            new StudentRegistration { StudentID = 17, CareerEventID = 10 },
            new StudentRegistration { StudentID = 17, CareerEventID = 15 },

            // Student 18 assigned to 1 event
            new StudentRegistration { StudentID = 18, CareerEventID = 9 },

            // Student 19 assigned to 3 events
            new StudentRegistration { StudentID = 19, CareerEventID = 8 },
            new StudentRegistration { StudentID = 19, CareerEventID = 12 },
            new StudentRegistration { StudentID = 19, CareerEventID = 16 },

            // Student 20 assigned to 2 events
            new StudentRegistration { StudentID = 20, CareerEventID = 3 },
            new StudentRegistration { StudentID = 20, CareerEventID = 14 },

            // Remaining students follow the same structure
            new StudentRegistration { StudentID = 21, CareerEventID = 5 },
            new StudentRegistration { StudentID = 22, CareerEventID = 6 },
            new StudentRegistration { StudentID = 23, CareerEventID = 9 },
            new StudentRegistration { StudentID = 24, CareerEventID = 12 },
            new StudentRegistration { StudentID = 25, CareerEventID = 15 },
            new StudentRegistration { StudentID = 26, CareerEventID = 17 },
            new StudentRegistration { StudentID = 27, CareerEventID = 2 },
            new StudentRegistration { StudentID = 28, CareerEventID = 3 },
            new StudentRegistration { StudentID = 29, CareerEventID = 6 },
            new StudentRegistration { StudentID = 30, CareerEventID = 8 },
            new StudentRegistration { StudentID = 31, CareerEventID = 10 },
            new StudentRegistration { StudentID = 32, CareerEventID = 12 },
            new StudentRegistration { StudentID = 33, CareerEventID = 16 },
            new StudentRegistration { StudentID = 34, CareerEventID = 18 },
            new StudentRegistration { StudentID = 35, CareerEventID = 1 },
            new StudentRegistration { StudentID = 36, CareerEventID = 4 },
            new StudentRegistration { StudentID = 37, CareerEventID = 7 },
            new StudentRegistration { StudentID = 38, CareerEventID = 9 },
            new StudentRegistration { StudentID = 39, CareerEventID = 13 },
            new StudentRegistration { StudentID = 40, CareerEventID = 15 },
            new StudentRegistration { StudentID = 41, CareerEventID = 5 },
            new StudentRegistration { StudentID = 42, CareerEventID = 7 },
            new StudentRegistration { StudentID = 43, CareerEventID = 9 },
            new StudentRegistration { StudentID = 44, CareerEventID = 11 },
            new StudentRegistration { StudentID = 45, CareerEventID = 14 },
            new StudentRegistration { StudentID = 46, CareerEventID = 16 },
            new StudentRegistration { StudentID = 47, CareerEventID = 18 },
            new StudentRegistration { StudentID = 48, CareerEventID = 2 },
            new StudentRegistration { StudentID = 49, CareerEventID = 3 },
            new StudentRegistration { StudentID = 50, CareerEventID = 5 }
        };
        context.AddRange(studentRegistrations);
        context.SaveChanges();
    }
}