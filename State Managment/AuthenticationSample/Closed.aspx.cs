using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthenticationSample
{
    public partial class Closed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie name = Request.Cookies["name"];
            HttpCookie sign = Request.Cookies["sign"];

            if (name != null && sign != null)
            {
                if (sign.Value == CryptoProvider.GetMD5Hash(name.Value + "s@lt"))
                {
                    return;
                }
            }

            Response.Redirect("Login.aspx");

        }
    }
}