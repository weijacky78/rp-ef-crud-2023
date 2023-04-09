using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rp_ef_crud.Models;

namespace rp_ef_crud.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly StoreContext _context;

        public IndexModel(StoreContext context)
        {
            _context = context;
        }

        public IList<Game> Games { get; set; } = default!;


        public async Task OnGetAsync()
        {
            if (_context.Game != null)
            {
                Games = await _context.Game.ToListAsync();
            }
        }
    }
}
