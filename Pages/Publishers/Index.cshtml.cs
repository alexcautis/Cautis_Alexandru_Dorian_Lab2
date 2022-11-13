using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cautis_Alexandru_Dorian_Lab2.Data;
using Cautis_Alexandru_Dorian_Lab2.Models;

namespace Cautis_Alexandru_Dorian_Lab2.Pages.Publisher
{
    public class IndexModel : PageModel
    {
        private readonly Cautis_Alexandru_Dorian_Lab2.Data.Cautis_Alexandru_Dorian_Lab2Context _context;

        public IndexModel(Cautis_Alexandru_Dorian_Lab2.Data.Cautis_Alexandru_Dorian_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            {
                List<Book> books = await _context.Book
                                .Include(b => b.Publisher)
                                .ToListAsync();
                Book = books;
            }

            if (_context.Publisher != null)
            {
                List<Models.Publisher> publishers = await _context.Publisher.ToListAsync();
                Publisher = (IList<Publisher>)publishers;
            }
        }
    }
}
