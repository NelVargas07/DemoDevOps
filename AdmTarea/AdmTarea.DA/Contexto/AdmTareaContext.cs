using AdmTarea.DA.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AdmTarea.DA.Contexto
{
    public  class AdmTareaContext : DbContext
    {
        public AdmTareaContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<TareaDA> TareaDA { get; set; }

        public DbSet<FotoDA> FotoDA { get; set; }
    }
}

