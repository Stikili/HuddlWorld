using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Huddl.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Huddl.Controllers
{

    public class BeverageController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BeverageController(ApplicationDbContext db)
        {
            _db = db;
        }

        [Authorize]
        [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Beverages.ToListAsync() });
        }

        [Authorize]
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var BeveragesFromDb = await _db.Beverages.FirstOrDefaultAsync(u => u.Id == id);
            if (BeveragesFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _ = _db.Beverages.Remove(BeveragesFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }

    }

}
