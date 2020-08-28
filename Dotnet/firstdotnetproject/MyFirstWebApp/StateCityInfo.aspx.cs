using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class StateCityInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = PopulateDataSet();

                GridView1.DataSource = dt;
                GridView1.DataBind();

           
                //Linq to Dataset/Datatbale
                var query = (from st in dt.AsEnumerable()
                             orderby st.Field<string>("State")
                            select new
                            {
                              State=  st.Field<string>("State")
                            }).Distinct().ToList();
                
                //Populate all State to ddlState Drop Down
                ddlState.DataSource = query;
                ddlState.DataTextField = "State";
                ddlState.DataValueField = "State";
                ddlState.DataBind();
            }
        }

        private static DataTable PopulateDataSet()
        {
            string connectionstringtodatabase = "Data Source=acts-PC;Initial Catalog=MiscDB;User ID=sa;Password=boss";
            DataSet ds = new DataSet();
            using (SqlConnection cn = new SqlConnection(connectionstringtodatabase))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SelectStateCityInfo";
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                    }
                }
            }
            return ds.Tables[0];
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = PopulateDataSet();
            var query = from st in dt.AsEnumerable()
                        orderby st.Field<string>("City")
                        where st.Field<string>("State") == ddlState.SelectedValue
                        select new
                        {
                            City = st.Field<string>("City")
                        };

            //Populate all State to ddlState Drop Down
            ddlCity.DataSource = query;
            ddlCity.DataTextField = "City";
            ddlCity.DataValueField = "City";
            ddlCity.DataBind();
        }
    }
}