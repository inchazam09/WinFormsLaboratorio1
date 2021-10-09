using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IDoctoresService
    {
        DBEntity Create(DoctoresEntity entity);
        DBEntity Delete(DoctoresEntity entity);
        IEnumerable<DoctoresEntity> Get();
        DoctoresEntity GetById(DoctoresEntity entity);
        DBEntity Update(DoctoresEntity entity);
    }

    public class DoctoresService : IDoctoresService
    {
        public IDataAccess sql { get; set; }
        public object PacientesId { get; private set; }

        public DoctoresService()
        {
            sql = new DataAccess();
        }

    
        public IEnumerable<DoctoresEntity> Get()
        {
            try
            {
                var result = sql.Query<DoctoresEntity, PacientesEntity>
                    ("DoctoresObtener", "DoctoresId, PacientesId");

                return result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metódo para obtener el detalle de un registro
        public DoctoresEntity GetById(DoctoresEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<DoctoresEntity>("DoctoresObtener", new
                {
                    entity.DoctoresId

                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para crear
        public DBEntity Create(DoctoresEntity entity)
        {
            try
            {
                var result = sql.Execute("DoctoresInsertar", new
                {
                    entity.DoctoresId,
                    entity.Nombre,
                    entity.Apellidos,
                    entity.Cedula,
                    entity.Especialidad,
                    entity.Direccion,
                    entity.Telefono

                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para actualizar
        public DBEntity Update(DoctoresEntity entity)
        {
            try
            {
                var result = sql.Execute("DoctoresActualizar", new
                {
                    entity.DoctoresId,
                    entity.Nombre,
                    entity.Apellidos,
                    entity.Cedula,
                    entity.Especialidad,
                    entity.Direccion,
                    entity.Telefono

                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DBEntity Delete(DoctoresEntity entity)
        {
            try
            {
                var result = sql.Execute("DoctoresEliminar", new
                {
                    entity.DoctoresId


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
