using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Provider_Dummypage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string constr = "Server=NAWAZ; Database=kinnan_work4sale;";
            string query = "SELECT ProductID, ProductName FROM Products";

            SqlDataAdapter da = new SqlDataAdapter(query, constr);
            DataTable table = new DataTable();

            da.Fill(table);
            DataList1.DataSource = table;
            DataList1.DataBind();
        }
    }
}