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

        public async Task OnGetAsync()
        {
            CareerEvent = await _context.CareerEvents.Include(s => s.StudentRegistrations!).ThenInclude(rs => rs.Student).ToListAsync();
        }
    }
}
