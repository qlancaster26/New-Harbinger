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

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set; } = 1;

        public int PageSize {get; set;} = 10;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}

        public async Task OnGetAsync()
        {
            var query = _context.Characters.Select( c => c);

            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(c => c.Name);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(c => c.Name);
                    break;
            }
            
            Character = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
