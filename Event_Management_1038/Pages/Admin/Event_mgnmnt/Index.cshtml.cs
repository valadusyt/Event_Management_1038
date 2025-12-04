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
    public class IndexModel : PageModel
    {
        private readonly Event_Management_1038.Data.ApplicationDbContext _context;

        public IndexModel(Event_Management_1038.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Event1038> Event1038 { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Event1038 = await _context.Events1038.ToListAsync();
        }
    }
}
