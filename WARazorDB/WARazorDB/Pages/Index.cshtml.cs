using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WARazorDB.Data;
using WARazorDB.Models;

namespace WARazorDB.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WARazorDB.Data.TareaDBContext _context;

        public IndexModel(WARazorDB.Data.TareaDBContext context)
        {
            _context = context;
        }

        public IList<Tarea> Tarea { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Tarea = await _context.Tareas.ToListAsync();
        }
    }
}
