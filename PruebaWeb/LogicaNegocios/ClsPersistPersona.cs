using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AccesoDatos;
namespace LogicaNegocios
{
    public class ClsPersistPersona
    {
        ClsAccesoDatos accesoDatos = new ClsAccesoDatos();

        public void registrar(String pnombre, int pedad) 
        {
            try
            {
                accesoDatos.registrar(pnombre, pedad);
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ClsPersona> buscar() 
        {
            List<ClsPersona> personas = new List<ClsPersona>();
            IDataReader datos;

            try 
            {
                datos = accesoDatos.buscar();
                while (datos.Read()) 
                {
                    personas.Add(new ClsPersona(datos.GetInt32(0), datos.GetString(1), datos.GetInt32(2)));
                }
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            datos.Close();
            return personas;
        }
    }
}
