﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class WebDataForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Connection string
        string connString = @"server=.\sql2012;database=AdventureWorks;Integrated Security=true";

        //Query
        string query = @" SELECT  Title, BirthDate
                          FROM    HumanResources.Employee";
        
        DataTable dt = new DataTable();

        try
        {
            SqlDataAdapter da = new SqlDataAdapter(query, connString);
            da.Fill(dt);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());  
        }

        //Populate Repeater control with data
        RepData.DataSource = dt;
        RepData.DataBind();         
    }    
}