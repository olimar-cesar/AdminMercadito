using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet ds = Login.ValidarLogin(txtUserID.Text, txtPassword.Text);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count == 0)
            {
                messageBox.ShowMessage("Usuario y / o Password incorrectos");
            }
            else
            {
                this.Session["UserID"] = dt.Rows[0]["Id"].ToString();
                this.Session["UserName"] = dt.Rows[0]["Username"].ToString();
                Response.Redirect("Main.aspx");
            }

        }
    }
}