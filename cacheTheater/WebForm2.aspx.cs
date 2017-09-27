using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cacheTheater
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                
                    if (Session["theater"] == null) { Response.Redirect("WebForm1.aspx"); }
                        string s=Session["theater"].ToString();
                    switch (s)
                    {
                    case "":
                        if (Cache["Cinemax_shows"] == null)
                        {
                            Cache["Cinemax_shows"] = "Judwaa 2    9:00am<br>";
                            
                        }
                        Label2.Text = Cache["Cinemax_shows"].ToString();
                            break;
                        default:
                            break;
                    }
                }
            
            catch (Exception ex) {
                Response.Redirect("WebForm1.aspx");
            }
        }
    }
}