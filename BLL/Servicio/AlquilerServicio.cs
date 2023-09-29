using BLL.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace BLL.Servicio
{
    public class AlquilerServicio : IGenericService<Alquiler>
    {
        #region
        private readonly static AlquilerServicio _instance = new AlquilerServicio();
        public static AlquilerServicio Instance { get { return _instance; } }
        private AlquilerServicio()
        {
        }
        #endregion
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Alquiler obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Alquiler obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Alquiler> ObtenerTodo()
        {
            throw new NotImplementedException();
        }

        public Alquiler ObtenerUno(int id)
        {
            throw new NotImplementedException();
        }
    }
}
