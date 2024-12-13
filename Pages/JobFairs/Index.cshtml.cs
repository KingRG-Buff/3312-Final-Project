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

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}


        public async Task OnGetAsync()
        {
            TotalPages = (int)Math.Ceiling(_context.CareerEvents.Count() / (double)PageSize);
            
            CareerEvent = await _context.CareerEvents.Include(s => s.StudentRegistrations!).ThenInclude(rs => rs.Student)
            .Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
