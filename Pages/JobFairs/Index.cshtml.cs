using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _3312_Final_Project.Models;

namespace _3312_Final_Project.Pages.JobFairs
{
    public class IndexModel : PageModel
    {
        private readonly _3312_Final_Project.Models.CareerEventDbContext _context;

        public IndexModel(_3312_Final_Project.Models.CareerEventDbContext context)
        {
            _context = context;
        }

        public IList<CareerEvent> CareerEvent { get;set; } = default!;
        public IList<CareerEvent> Student { get;set; } = default!;
        public IList<CareerEvent> StudentRegistration { get; set; } = default!;

        // Pagination support
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

        // Sorting support
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;

        // Search support
        [BindProperty(SupportsGet = true)]
        public string CurrentSearch {get; set;} = string.Empty;

        public async Task OnGetAsync()
        {
            var query = _context.CareerEvents.Include(s => s.StudentRegistrations!).ThenInclude(rs => rs.Student).Select(s => s);
            
            if (!string.IsNullOrEmpty(CurrentSearch))
            //Case Insensitive search by Event Name
            {
                query = query.Where(s => s.EventName.ToUpper().Contains(CurrentSearch.ToUpper()));
            }

            //Sorting support
            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(s => s.EventName);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(s => s.EventName);
                    break;
                case "date_desc": 
                    query = query.OrderByDescending(s => s.EventDate);
                    break;
            }
            
            TotalPages = (int)Math.Ceiling(query.Count() / (double)PageSize);

            CareerEvent = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
