using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CascadingDropDown
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet dsresultofcountrystatecity = new DataSet();
                dsresultofcountrystatecity = PopulateDataset(dsresultofcountrystatecity);
                           

                //Populate the country dropdown
                //linq to dataset

                var countryresult = (from localcountry in dsresultofcountrystatecity.Tables[0].AsEnumerable()
                                     orderby localcountry.Field<string>("countryname")
                                     select new
                                     {
                                         countryname = localcountry.Field<string>("countryname"),
                                         countryid = localcountry.Field<int>("countryid")
                                     }).Distinct().ToList();
                ddlCOuntry.DataSource = countryresult;
                ddlCOuntry.DataTextField = "countryname";
                ddlCOuntry.DataValueField = "countryid";
                ddlCOuntry.DataBind();

               
            }

        }

        private DataSet PopulateDataset(DataSet dsresultofcountrystatecity)
        {
            if (Session["resultofcountrystatecity"] == null)
            {

                using (SqlConnection cn = new SqlConnection("Data Source=acts-pc;Initial Catalog=StateCityInfo;User ID=cdac;Password=cdac"))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from  cities c,state s where c.stateid = s.stateid ";
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        {
                            da.SelectCommand = cmd;
                            da.Fill(dsresultofcountrystatecity);
                        }
                    }
                }
                Session["resultofcountrystatecity"] = dsresultofcountrystatecity;
            }
            else
            {
                dsresultofcountrystatecity = (DataSet)Session["resultofcountrystatecity"];
            }
            return dsresultofcountrystatecity;
        }

        protected void ddlCOuntry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var countryid = ddlCOuntry.SelectedValue;
            DataSet dsresultofcountrystatecity = new DataSet();
            dsresultofcountrystatecity = PopulateDataset(dsresultofcountrystatecity);
            //Populate the state dropdown
            //linq to dataset

            var stateresult = (from localstate in dsresultofcountrystatecity.Tables[0].AsEnumerable()
                               where localstate.Field<int>("countryid") == int.Parse(countryid)
                               orderby localstate.Field<string>("statename")
                                 select new
                                 {
                                     statename = localstate.Field<string>("statename"),
                                     stateid = localstate.Field<string>("stateid")
                                 }).Distinct().ToList();
            ddlState.DataSource = stateresult;
            ddlState.DataTextField = "statename";
            ddlState.DataValueField = "stateid";
            ddlState.DataBind();


        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stateid = ddlState.SelectedValue;
            DataSet dsresultofcountrystatecity = new DataSet();
            dsresultofcountrystatecity = PopulateDataset(dsresultofcountrystatecity);
            //Populate the city dropdown
            //linq to dataset

            var cityresult = (from localstate in dsresultofcountrystatecity.Tables[0].AsEnumerable()
                              where localstate.Field<string>("stateid") == stateid
                              orderby localstate.Field<string>("cityname")
                               select new
                               {
                                   cityname = localstate.Field<string>("cityname"),
                                   cityid = localstate.Field<string>("cityid")
                               }).Distinct().ToList();
            ddlCity.DataSource = cityresult;
            ddlCity.DataTextField = "cityname";
            ddlCity.DataValueField = "cityid";
            ddlCity.DataBind();
        }
    }
}