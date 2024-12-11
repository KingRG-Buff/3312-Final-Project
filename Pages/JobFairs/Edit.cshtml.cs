using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _3312_Final_Project.Models;

namespace _3312_Final_Project.Pages.JobFairs
{
    public class EditModel : PageModel
    {
        private readonly _3312_Final_Project.Models.CareerEventDbContext _context;

        public EditModel(_3312_Final_Project.Models.CareerEventDbContext context)
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

            var careerevent =  await _context.CareerEvents.FirstOrDefaultAsync(m => m.CareerEventID == id);
            if (careerevent == null)
            {
                return NotFound();
            }
            CareerEvent = careerevent;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CareerEvent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CareerEventExists(CareerEvent.CareerEventID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CareerEventExists(int id)
        {
            return _context.CareerEvents.Any(e => e.CareerEventID == id);
        }
    }
}
