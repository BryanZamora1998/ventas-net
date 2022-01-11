using Microsoft.EntityFrameworkCore;
using sistema_proveedor_api.DAO;
using sistema_proveedor_api.MODEL;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace sistema_proveedor_api.Dao
{
    public class TipoIdentificacionDao
    {
        private MyDBContext context;

        public TipoIdentificacionDao(DbContextOptions<MyDBContext> options)

        {
            this.context = new MyDBContext(options);
        }

        public TiposIdentificacion find(int id)
        {
            return this.context.TiposIdentificacion.Find(id); ;
        }


        public void add(TiposIdentificacion id)
        {
            this.context.TiposIdentificacion.Add(id); ;
            this.context.SaveChanges();
        }

        internal object findById(int id)
        {
            var blogs = this.context.TiposIdentificacion
              .FromSqlRaw("SELECT * FROM tbl_tipos_identificacion t " +
              "where t.secuencia_Tipo_Identificacion={0} ", id)
              .ToList();

            return blogs;
        }

        public void update(TiposIdentificacion id)
        {
            this.context.TiposIdentificacion.Update(id);
            this.context.SaveChanges();
        }

        public void Remove(TiposIdentificacion id)
        {
            this.context.TiposIdentificacion.Remove(id);
            this.context.SaveChanges();
        }

    }
}
