using System.Collections.Generic;
using Huddl.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Huddl.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Huddl.Pages.Establishment
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<MerchantEstablishment> Establishments { get; set; }

        public async Task OnGet()
        {
            Establishments = await _db.MerchantEstablishment.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var MerchantEstablishment = await _db.MerchantEstablishment.FindAsync(id);
            if (MerchantEstablishment == null)
            {
                return NotFound();
            }
            _db.MerchantEstablishment.Remove(MerchantEstablishment);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}