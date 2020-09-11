using Huddl.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Huddl.Controllers
{

    [Route("api/Establishments")]
    [ApiController]
        public class MerchantEstablishmentController : Controller
        {
            private readonly ApplicationDbContext _db;

            public MerchantEstablishmentController(ApplicationDbContext db)
            {
                _db = db;
        }
        //[Authorize]
        [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                return Json(new { data = await _db.MerchantEstablishment.ToListAsync() });
            }
        [Authorize]
        [HttpDelete]
            public async Task<IActionResult> Delete(int id)
            {
                var EstablishmentFromDb = await _db.MerchantEstablishment.FirstOrDefaultAsync(u => u.Id == id);
                if (EstablishmentFromDb == null)
                {
                    return Json(new { success = false, message = "Error while Deleting" });
                }
                _ = _db.MerchantEstablishment.Remove(EstablishmentFromDb);
                await _db.SaveChangesAsync();
                return Json(new { success = true, message = "Delete successful" });
            }

        }


}
