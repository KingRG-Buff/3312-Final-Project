using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _3312_Final_Project.Models;

namespace _3312_Final_Project.Pages.JobFairs
{
    public class CreateModel : PageModel
    {
        private readonly _3312_Final_Project.Models.CareerEventDbContext _context;

        public CreateModel(_3312_Final_Project.Models.CareerEventDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CareerEvent CareerEvent { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CareerEvents.Add(CareerEvent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
