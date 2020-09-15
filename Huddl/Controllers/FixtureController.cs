using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Huddl.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Huddl.Controllers
{
    public class FixtureController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FixtureController(ApplicationDbContext db)
        {
            _db = db;
        }

        //[Authorize]
        [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.FixtureSchedule.ToListAsync() });
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
