﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text == "agarwal")
        {
            Response.Redirect("WebDataForm.aspx");
        }
        else
        {
            Response.Write("Invalid User Name, please try again!");
        }
    }
}