//------------------------------------------------------------------------------
// <copyright file="CSSqlStoredProcedure.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure()]
    public static void InsertCurrency_CS(SqlString currencyCode, SqlString currencyName)
    {
        SqlConnection conn = null;

        try
        {
            conn = new SqlConnection(@"server = .\sql2012;integrated security = true;database = AdventureWorks");

            SqlCommand cmdInsertCurrency = new SqlCommand();
            cmdInsertCurrency.Connection = conn;

            SqlParameter parmCurrencyCode = new SqlParameter("@CCode", SqlDbType.NVarChar, 3);
            SqlParameter parmCurrencyName = new SqlParameter("@Name", SqlDbType.NVarChar, 50);

            parmCurrencyCode.Value = currencyCode;
            parmCurrencyName.Value = currencyName;

            cmdInsertCurrency.Parameters.Add(parmCurrencyCode);
            cmdInsertCurrency.Parameters.Add(parmCurrencyName);

            cmdInsertCurrency.CommandText =
                "INSERT Sales.Currency (CurrencyCode, CurrencyName, ModifiedCurrencyDate)" +
                " VALUES(@CCode, @Name, GetDate())";           

            conn.Open();

            cmdInsertCurrency.ExecuteNonQuery();
        }

        catch (SqlException ex)
        {
            SqlContext.Pipe.Send("An error occured" + ex.Message + ex.StackTrace);
        }

        finally
        {
            conn.Close();
        }
    }   
}
