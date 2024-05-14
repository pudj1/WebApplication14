using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication13.Context;
using WebApplication13.Model;

namespace WebApplication13.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Instrument> Instruments { get; set; }

        public async Task OnGetAsync()
        {
            Instruments = await _context.Instruments.Take(20).ToListAsync();
        }
    }
}
