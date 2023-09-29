using DAL.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace DAL.Repositorios.SQL
{
    public class ClienteRepositorio : IGenericRepository<CLIENTE>
    {
         //TP_TCEntities db = new TP_TCEntities();
        
        public void Eliminar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(CLIENTE obj) 
        { 
            using(TP_TCEntities db = new TP_TCEntities())
            {
                /*CLIENTE c = new CLIENTE()
                {
                    NOMBRE_CLIENTE = obj.NOMBRE_CLIENTE,
                    APELLIDO_CLIENTE = obj.APELLIDO_CLIENTE,
                    CORREO_CLIENTE = obj.CORREO_CLIENTE
                };*/
                db.CLIENTE.Add(obj);
                db.SaveChanges();
            }
        }
        /*
         using (TP_TCEntities db = new TP_TCEntities())
                {
                    CLIENTE c = new CLIENTE()
                    {
                        NOMBRE_CLIENTE = txtNombreCliente.Text,
                        APELLIDO_CLIENTE = txtApellidoCliente.Text,
                        CORREO_CLIENTE = txtCorreoCliente.Text
                    };
                    db.CLIENTE.Add(c); //persistir
                    db.SaveChanges(); //ejecutar en sql
                    MessageBox.Show($"El cliente: {c.NOMBRE_CLIENTE} - {c.APELLIDO_CLIENTE}, se ha creado.");
                    #region limpiarBotones
                    txtNombreCliente.Clear();
                    txtApellidoCliente.Clear();
                    txtCorreoCliente.Clear();
                    #endregion
                }
         */

        public void Modificar(CLIENTE obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CLIENTE> ObtenerTodo()
        {
            throw new NotImplementedException();
        }

        public CLIENTE ObtenerUno(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
