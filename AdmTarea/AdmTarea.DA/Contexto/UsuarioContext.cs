using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DA.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DA.Contexto
{
    public class UsuarioContext : DbContext
    {
            public UsuarioContext(DbContextOptions options)
                : base(options)
            {
            }
            public DbSet<UsuarioDA> UsuarioDA { get; set; }
    }
}
