using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Huddl.Data;
using Huddl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Huddl.Pages.Establishment
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public MerchantEstablishment Establishments { get; set; }

        public async Task OnGet(int id)
        {
            Establishments = await _db.MerchantEstablishment.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var EstablishmentsFromDb = await _db.MerchantEstablishment.FindAsync(Establishments.Id);
                EstablishmentsFromDb.Establishment = Establishments.Establishment;
                EstablishmentsFromDb.Address = Establishments.Address;
                EstablishmentsFromDb.Team = Establishments.Team;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
