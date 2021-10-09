using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPacientesService
    {
    
        DBEntity Create(PacientesEntity entity);
        DBEntity Delete(PacientesEntity entity);
        IEnumerable<PacientesEntity> Get();
        IEnumerable<PacientesEntity> GetLista();
        PacientesEntity GetById(PacientesEntity entity);
        DBEntity Update(PacientesEntity entity);
    }

    public class PacientesService : IPacientesService
    {
        public IDataAccess sql { get; set; }
        public PacientesService()
        {
            sql = new DataAccess();
        }

        //Metódo para obtener los datos en general de Marca Vehiculo
        public IEnumerable<PacientesEntity> Get()
        {
            try
            {
                var result = sql.Query<PacientesEntity>("PacientesObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public IEnumerable<PacientesEntity> GetLista()
        {
            try
            {
                var result = sql.Query<PacientesEntity>("PacientesLista");

                return result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metódo para obtener el detalle de un registro
        public PacientesEntity GetById(PacientesEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<PacientesEntity>("PacientesObtener", new
                {
                    entity.PacientesId

                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para crear
        public DBEntity Create(PacientesEntity entity)
        {
            try
            {
                var result = sql.Execute("PacientesInsertar", new
                {
                    entity.Nombre,
                    entity.Apellidos,
                    entity.Nacionalidad,
                    entity.Cedula,
                    entity.Edad,
                    entity.Telefono,
                    entity.Direccion,
                    entity.Enfermedades,
                    entity.Alergias
                    

                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para actualizar
        public DBEntity Update(PacientesEntity entity)
        {
            try
            {
                var result = sql.Execute("PacientesActualizar", new
                {
                    entity.PacientesId,
                    entity.Nombre,
                    entity.Apellidos,
                    entity.Nacionalidad,
                    entity.Cedula,
                    entity.Edad,
                    entity.Telefono,
                    entity.Direccion,
                    entity.Enfermedades,
                    entity.Alergias

                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DBEntity Delete(PacientesEntity entity)
        {
            try
            {
                var result = sql.Execute("PacientesEliminar", new
                {
                    entity.PacientesId


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
