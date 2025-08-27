using Microsoft.EntityFrameworkCore;
using WARazorDB.Models;

namespace WARazorDB.Data
{
    public class TareaDBContext : DbContext
    {
        public TareaDBContext(DbContextOptions <TareaDBContext> options) : base(options)
        {
        }
        public DbSet<Tarea> Tareas { get; set; }

        protected TareaDBContext()
        {
        }
    }
}
