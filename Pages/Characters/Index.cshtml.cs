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
    public class IndexModel : PageModel
    {
        private readonly StarWars.Models.HarbingerDbContext _context;

        public IndexModel(StarWars.Models.HarbingerDbContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Character = await _context.Characters.ToListAsync();
        }
    }
}
