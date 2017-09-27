using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cacheTheater
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Cinemax");
            DropDownList1.Items.Add("PVR Phoenix Market City");
            DropDownList1.Items.Add("Maxus Cinemas");
            DropDownList1.Items.Add("INOX Nakshatra");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String s=DropDownList1.SelectedItem.ToString();
            if (!s.Equals(""))
            {
                Session["theater"] = s;
                
                Response.Redirect("WebForm2.aspx");
            }
        }
    }
}