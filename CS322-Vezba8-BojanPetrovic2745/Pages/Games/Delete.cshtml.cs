using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CS322_Vezba8_BojanPetrovic2745.Data;
using CS322_Vezba8_BojanPetrovic2745.Models;

namespace CS322_Vezba8_BojanPetrovic2745.Pages.Games
{
    public class DeleteModel : PageModel
    {
        private readonly CS322_Vezba8_BojanPetrovic2745.Data.AppDbContext _context;

        public DeleteModel(CS322_Vezba8_BojanPetrovic2745.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.Game.FirstOrDefaultAsync(m => m.Id == id);

            if (Game == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.Game.FindAsync(id);

            if (Game != null)
            {
                _context.Game.Remove(Game);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
