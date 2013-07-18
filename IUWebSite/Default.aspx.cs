using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LogicaNegocios;
public partial class _Default : System.Web.UI.Page
{
    ClsGestor gestor = new ClsGestor();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            txtNombre.Value = Request.QueryString.Get("textNombre");
            TxtEdad.Value = Request.QueryString.Get("textEdad");
        }
        
        //foreach (String s in Request.QueryString)
        //{
        //    txtNombre.Value = Request.QueryString.Get("textNombre");
        //    Response.Write("<script>alert('" + s + " = " + Request.QueryString[s] + "');</script>");
        //}
        buscar();
    }
    protected void bntRegistrar_Click(object sender, EventArgs e)
    {
        String nombre = txtNombre.Value;
        int edad = Convert.ToInt32(TxtEdad.Value);

        gestor.registrar(nombre, edad);

    }
    public void buscar() 
    {
        List<Array> datos;

        datos = gestor.buscar();

        DataTable dt = new DataTable();
        dt.Columns.Add(new DataColumn("ID", typeof(Int32)));
        dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
        dt.Columns.Add(new DataColumn("Edad", typeof(Int32)));

        DataRow dr = null;
        foreach (Array dato in datos)
        {
            dr = dt.NewRow();
            dr["ID"] = dato.GetValue(0);
            dr["Nombre"] = dato.GetValue(1);
            dr["Edad"] = dato.GetValue(2);
            dt.Rows.Add(dr);
        }

        gvPersonas.DataSource = dt;
        gvPersonas.DataBind();
    }
}
