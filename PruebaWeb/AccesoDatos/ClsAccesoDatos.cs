using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace AccesoDatos
{
    public class ClsAccesoDatos
    {
        SqlConnection conn = new SqlConnection("Initial Catalog=BDPruebaWeb;Data Source=YULI-PC;Integrated Security=True;");
        SqlCommand comm;
        String sql = "";
        public void registrar(String pnombre, int pedad) 
        {
            
            sql = "exec [dbo].[insertarPersona] ";
            sql += "'" + pnombre + "'," + pedad;
            comm = new SqlCommand(sql, conn);
            try 
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                comm.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            comm.Connection.Close();
        }

        public SqlDataReader buscar() 
        {
            SqlDataReader result;
            sql = "exec buscarPersonas ";
            comm = new SqlCommand(sql, conn);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                result = comm.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
