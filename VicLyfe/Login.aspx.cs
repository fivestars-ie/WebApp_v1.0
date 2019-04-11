using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VicLyfe
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtpassword.Text == "123456")
            {
                Response.Redirect("/Home/Index");
            }
            else
            {
                Label3.Visible = true;
            }
        }
    }
}