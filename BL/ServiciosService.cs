using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IServiciosService
    {
        DBEntity Create(ServiciosEntity entity);
        DBEntity Delete(ServiciosEntity entity);
        IEnumerable<ServiciosEntity> Get();
        ServiciosEntity GetById(ServiciosEntity entity);
        DBEntity Update(ServiciosEntity entity);
    }

    public class ServiciosService : IServiciosService
    {
        public IDataAccess sql { get; set; }
        public object PacientesId { get; private set; }

        public ServiciosService()
        {
            sql = new DataAccess();
        }


        public IEnumerable<ServiciosEntity> Get()
        {
            try
            {
                var result = sql.Query<ServiciosEntity, PacientesEntity>
                    ("ServiciosObtener", "ServiciosId, PacientesId");

                return result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metódo para obtener el detalle de un registro
        public ServiciosEntity GetById(ServiciosEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<ServiciosEntity>("ServiciosObtener", new
                {
                    entity.ServicioId

                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para crear
        public DBEntity Create(ServiciosEntity entity)
        {
            try
            {
                var result = sql.Execute("ServiciosInsertar", new
                {
                    entity.ServicioId,
                    entity.Servicio,
                    entity.Procedimiento,
                    entity.Caracteristicas,
                    entity.Doctor,
                    entity.Precio,
                    entity.HorariosDisponibles


                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para actualizar
        public DBEntity Update(ServiciosEntity entity)
        {
            try
            {
                var result = sql.Execute("ServiciosActualizar", new
                {
                    entity.ServicioId,
                    entity.Servicio,
                    entity.Procedimiento,
                    entity.Caracteristicas,
                    entity.Doctor,
                    entity.Precio,
                    entity.HorariosDisponibles

                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DBEntity Delete(ServiciosEntity entity)
        {
            try
            {
                var result = sql.Execute("ServiciosEliminar", new
                {
                    entity.ServicioId


                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}