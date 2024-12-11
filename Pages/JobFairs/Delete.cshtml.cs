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
    public class DeleteModel : PageModel
    {
        private readonly _3312_Final_Project.Models.CareerEventDbContext _context;

        public DeleteModel(_3312_Final_Project.Models.CareerEventDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CareerEvent CareerEvent { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var careerevent = await _context.CareerEvents.FirstOrDefaultAsync(m => m.CareerEventID == id);

            if (careerevent is not null)
            {
                CareerEvent = careerevent;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var careerevent = await _context.CareerEvents.FindAsync(id);
            if (careerevent != null)
            {
                CareerEvent = careerevent;
                _context.CareerEvents.Remove(CareerEvent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
