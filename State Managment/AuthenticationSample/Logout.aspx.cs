using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthenticationSample
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cooki1 = new HttpCookie("name", string.Empty);
            HttpCookie cooki2 = new HttpCookie("sign", string.Empty);
            cooki1.Expires = DateTime.Now.AddDays(-1);
            cooki2.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cooki1);
            Response.Cookies.Add(cooki2);
            Response.Redirect("Default.aspx");
        }
    }
}