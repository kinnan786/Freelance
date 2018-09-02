using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Provider_GetImage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];

        string constr = "Server=SampleServer; Database=SampleDB; uid=test; pwd=test";
        string query = "SELECT ProductImage FROM Products WHERE ProductID = @ProductID";

        SqlConnection con = new SqlConnection(constr);
        SqlCommand com = new SqlCommand(query, con);

        com.Parameters.Add("@ProductID", SqlDbType.Int).Value = Int32.Parse(id);

        con.Open();
        SqlDataReader r = com.ExecuteReader();

        if (r.Read())
        {
            byte[] imgData = (byte[])r["ProductImage"];
            Response.BinaryWrite(imgData);
        }
        con.Close(); 
    }
}