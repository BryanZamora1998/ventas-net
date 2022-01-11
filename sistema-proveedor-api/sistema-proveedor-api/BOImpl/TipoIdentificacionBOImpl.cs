using Microsoft.EntityFrameworkCore;
using sistema_proveedor_api.Dao;
using sistema_proveedor_api.DAO;
using sistema_proveedor_api.MODEL;


namespace sistema_proveedor_api.BOImpl
{
    public class TipoIdentificacionBOImpl
    {
        private TipoIdentificacionDao objTipoIdentificacionDao;

        public TipoIdentificacionBOImpl(DbContextOptions<MyDBContext> options)

        {
            this.objTipoIdentificacionDao = new TipoIdentificacionDao(options);
        }

        public object consultarTipoIdentificacion(int id)
        {
            return this.objTipoIdentificacionDao.findById(id);
        }

        public object actualizacionTipoIdentificacion(int id, TiposIdentificacion obj)
        {
            if (id == null)
                throw new BOException("El id es requerido");

            TiposIdentificacion objTipoIdentificacion =this.objTipoIdentificacionDao.find(id);
            objTipoIdentificacion.esActivo=obj.esActivo;
            objTipoIdentificacion.nombre=obj.nombre;
            this.objTipoIdentificacionDao.update(objTipoIdentificacion);

            return null;
        }

        internal object agregarTipoIdentificacion(TiposIdentificacion objTiposIdentificacion)
        {
            if (objTiposIdentificacion.nombre == null || objTiposIdentificacion.nombre=="")
                throw new BOException("El nombre es requerido");

            objTiposIdentificacion.esActivo = "S";
            objTiposIdentificacion.secuenciaTipoIdentificacion=0;

            this.objTipoIdentificacionDao.add(objTiposIdentificacion);

            return null;
        }

        internal object eliminarTipoIdentificacion(int id)
        {
            if (id == null)
                throw new BOException("El id es requerido");

            TiposIdentificacion objTipoIdentificacion = this.objTipoIdentificacionDao.find(id);
            this.objTipoIdentificacionDao.Remove(objTipoIdentificacion);

            return null;
        }
    }
}
