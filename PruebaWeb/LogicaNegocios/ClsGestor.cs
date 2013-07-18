using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaNegocios
{
    public class ClsGestor
    {
        ClsPersistPersona persistPersona = new ClsPersistPersona();

        public void registrar(String pnombre, int pedad)
        {
            try
            {
                persistPersona.registrar(pnombre, pedad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Array> buscar() 
        {
            List<Array> datos = new List<Array>();
            List<ClsPersona> personas;

            try 
            {
                personas = persistPersona.buscar();
                foreach (ClsPersona persona in personas) 
                {
                    String[] campos = {persona.id.ToString(), persona.nombre.ToString(), persona.edad.ToString()};
                    datos.Add(campos);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return datos;
        }
    }
}
