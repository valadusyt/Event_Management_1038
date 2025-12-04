using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Event_Management_1038.Data;
using Event_Management_1038.Models;

namespace Event_Management_1038.Pages.Admin.Event_mgnmnt
{
    public class CreateModel : PageModel
    {
        private readonly Event_Management_1038.Data.ApplicationDbContext _context;

        public CreateModel(Event_Management_1038.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Event1038 Event1038 { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Events1038.Add(Event1038);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
