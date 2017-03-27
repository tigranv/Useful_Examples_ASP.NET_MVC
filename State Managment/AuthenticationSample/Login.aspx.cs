using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthenticationSample
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "8888" && LoginTextBox.Text == "Tigran")
            {
                HttpCookie cookieName = new HttpCookie("name", LoginTextBox.Text);
                HttpCookie cookieSign = new HttpCookie("sign", CryptoProvider.GetMD5Hash(LoginTextBox.Text + "s@lt"));
                // In order to ensure that this cookie set was created by our page, 
                // and not by an attacker, we send a cookie-signature in addition to the name.
                // In order to complicate the selection of the value that we put
                // in the signature is used "salt" - a word or a set of symbols.
                // Every time when requests come from the user,
                // we will re-generate the signature and check that it matches the received one.

               Response.Cookies.Add(cookieName);
                Response.Cookies.Add(cookieSign);
                Response.Redirect("Default.aspx");
            }
            else
            {
                ErrorLabel.Visible = true;
            }
        }
    }
}