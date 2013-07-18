using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaNegocios
{
    public class ClsPersona
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public int edad { get; set; }

        public ClsPersona(int pid, String pnombre, int pedad) 
        {
            id = pid;
            nombre = pnombre;
            edad = pedad;
        }
    }
}
