using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.stockClerk;

using ClassLibraryBL.Entities;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class ViewDiscrepancyHistoryDetails : System.Web.UI.Page
    {
        ProcessDiscrepancyController pdController = new ProcessDiscrepancyController();
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["UserEntity"];
            if (u == null || u.RoleId != 4)
            {
                Response.Redirect("../Security.aspx");
            }

            String id = Session["transferId"].ToString();
            Object o= pdController.getDiscrepanyDetail(id);
            GridView1.DataSource = o;
            GridView1.DataBind();
        }

    }
}