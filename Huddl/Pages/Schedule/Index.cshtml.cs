using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Huddl.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Huddl.Models;
using Microsoft.EntityFrameworkCore;

namespace Huddl.Pages.Schedule
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<FixtureSchedule> FixtureSchedule { get; set; }

        public async Task OnGet()
        {
            FixtureSchedule = await _db.FixtureSchedule.ToListAsync();
        }
    }
}
