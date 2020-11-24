using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CS322_Vezba8_BojanPetrovic2745.Data;
using CS322_Vezba8_BojanPetrovic2745.Models;

namespace CS322_Vezba8_BojanPetrovic2745.Pages.Games
{
    public class CreateModel : PageModel
    {
        private readonly CS322_Vezba8_BojanPetrovic2745.Data.AppDbContext _context;

        public CreateModel(CS322_Vezba8_BojanPetrovic2745.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Game Game { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Game.Add(Game);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
