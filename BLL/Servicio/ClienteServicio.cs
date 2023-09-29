using BLL.Contrato;
using DAL.Factory;
using SL.Servicio.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;


namespace BLL.Servicio
{
    public sealed class ClienteServicio : IGenericService<CLIENTE>
    {
        #region
        private readonly static ClienteServicio _instance = new ClienteServicio();
        public static ClienteServicio Instance { get { return _instance; } }
        private ClienteServicio()
        {
        }
        #endregion
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(CLIENTE obj)
        {
            try
            {
                //validar correo por ejemplo
                Factory.Instance.GetClienteRepositorio().Insertar(obj);
            }
            catch (Exception ex)
            { //prueba
                LoggerService.WriteLog(ex.Message, "Ailen Aranda");
            }
        }

        public void Modificar(CLIENTE obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CLIENTE> ObtenerTodo()
        {
            throw new NotImplementedException();
        }

        public CLIENTE ObtenerUno(int id)
        {
            throw new NotImplementedException();
        }
    }
}
