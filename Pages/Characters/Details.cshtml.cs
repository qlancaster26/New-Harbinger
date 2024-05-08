using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StarWars.Models;

namespace New_Harbinger.Pages.Characters
{
    public class DetailsModel : PageModel
    {
        private readonly StarWars.Models.HarbingerDbContext _context;

        public DetailsModel(StarWars.Models.HarbingerDbContext context)
        {
            _context = context;
        }

        public Character Character { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FirstOrDefaultAsync(m => m.CharacterId == id);
            if (character == null)
            {
                return NotFound();
            }
            else
            {
                Character = character;
            }
            return Page();
        }
    }
}
