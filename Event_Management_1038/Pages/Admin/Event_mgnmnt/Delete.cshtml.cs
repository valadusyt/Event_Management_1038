using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Event_Management_1038.Data;
using Event_Management_1038.Models;

namespace Event_Management_1038.Pages.Admin.Event_mgnmnt
{
    public class DeleteModel : PageModel
    {
        private readonly Event_Management_1038.Data.ApplicationDbContext _context;

        public DeleteModel(Event_Management_1038.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Event1038 Event1038 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var event1038 = await _context.Events1038.FirstOrDefaultAsync(m => m.Id == id);

            if (event1038 is not null)
            {
                Event1038 = event1038;

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

            var event1038 = await _context.Events1038.FindAsync(id);
            if (event1038 != null)
            {
                Event1038 = event1038;
                _context.Events1038.Remove(Event1038);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
