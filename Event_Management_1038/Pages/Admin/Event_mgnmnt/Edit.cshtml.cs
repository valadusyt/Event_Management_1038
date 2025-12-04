using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Event_Management_1038.Data;
using Event_Management_1038.Models;

namespace Event_Management_1038.Pages.Admin.Event_mgnmnt
{
    public class EditModel : PageModel
    {
        private readonly Event_Management_1038.Data.ApplicationDbContext _context;

        public EditModel(Event_Management_1038.Data.ApplicationDbContext context)
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

            var event1038 =  await _context.Events1038.FirstOrDefaultAsync(m => m.Id == id);
            if (event1038 == null)
            {
                return NotFound();
            }
            Event1038 = event1038;
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

            _context.Attach(Event1038).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Event1038Exists(Event1038.Id))
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

        private bool Event1038Exists(int id)
        {
            return _context.Events1038.Any(e => e.Id == id);
        }
    }
}
