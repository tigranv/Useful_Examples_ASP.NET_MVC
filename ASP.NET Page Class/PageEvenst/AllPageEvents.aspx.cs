using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageEvenst
{
    public partial class AllPageEvents : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Label1.Text += "PreInit <b>IsPostBack " + IsPostBack + "</b><br />";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Label1.Text += "Init <br />";
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Label1.Text += "InitComplete <br />";
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Label1.Text += "PreLoad <br />";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text += "Load <br />";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text += "<b>The handler of the button clicked</b><br />";
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Label1.Text += "LoadComplete <br />";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Label1.Text += "PreRender <br />";
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Label1.Text += "PreRenderComplete <br />";
        }

        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            Label1.Text += "SaveStateComplete <br />";
        }

        // Rendering the page. All controls are turned into HTML, CSS and JavaScript, which will be sent to the client.

        protected void Page_Unload(object sender, EventArgs e)
        {
            // Release the resources that used the page.        }
        }

    }
}