using Microsoft.EntityFrameworkCore;
using sistema_proveedor_api.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_proveedor_api.DAO
{
    public class MyDBContext : DbContext
    {
        public DbSet<TiposIdentificacion> TiposIdentificacion { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }
    }
}
