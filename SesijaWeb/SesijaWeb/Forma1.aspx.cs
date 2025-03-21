﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SesijaWeb
{
    public partial class Forma1 : System.Web.UI.Page
    {
        private String storedText;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Restore the value from the Sesion variable
            storedText = (string)Session["text1"];
            InsertRecord(storedText);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            storedText = TextBox1.Text;
            InsertRecord(storedText);

            // Store the value to the Session variable
            Session["text1"] = storedText;
        }

        private void InsertRecord(string tekstas)
        {
            TableCell cell = new TableCell();
            cell.Text = tekstas;
            TableRow row = new TableRow();
            row.Cells.Add(cell);
            Table1.Rows.Add(row);
        }

    }
}