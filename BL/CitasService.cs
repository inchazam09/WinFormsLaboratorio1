using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface ICitasService
    {
        DBEntity Create(CitasEntity entity);
        DBEntity Delete(CitasEntity entity);
        IEnumerable<CitasEntity> Get();
        CitasEntity GetById(CitasEntity entity);
        DBEntity Update(CitasEntity entity);
    }

    public class CitasService : ICitasService
    {
        public IDataAccess sql { get; set; }
        public object CitaId { get; private set; }

        public CitasService()
        {
            sql = new DataAccess();
        }


        public IEnumerable<CitasEntity> Get()
        {
            try
            {
                var result = sql.Query<CitasEntity, PacientesEntity>
                    ("CitasObtener", "CitaId, PacientesId");

                return result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metódo para obtener el detalle de un registro
        public CitasEntity GetById(CitasEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<CitasEntity>("CitasObtener", new
                {
                    entity.CitaId

                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para crear
        public DBEntity Create(CitasEntity entity)
        {
            try
            {
                var result = sql.Execute("CitasInsertar", new
                {
                    entity.CitaId,
                    entity.TipoServicio,
                    entity.Paciente,
                    entity.Fecha,
                    entity.Hora


                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para actualizar
        public DBEntity Update(CitasEntity entity)
        {
            try
            {
                var result = sql.Execute("CitasActualizar", new
                {
                    entity.CitaId,
                    entity.TipoServicio,
                    entity.Paciente,
                    entity.Fecha,
                    entity.Hora

                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DBEntity Delete(CitasEntity entity)
        {
            try
            {
                var result = sql.Execute("CitasEliminar", new
                {
                    entity.CitaId


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