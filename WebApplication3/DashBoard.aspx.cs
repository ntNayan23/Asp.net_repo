using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class DashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                litUsername.Text = Session["Username"].ToString();
            }

        }

        protected void btn_click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");

        }

    }
}