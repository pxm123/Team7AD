using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;
using ClassLibraryBL.Controller.deptEmpRep;

namespace LogicUniv1._1.webpage.deptEmpRep
{
    public partial class DepEmpHome : System.Web.UI.Page
    {
        ConfirmDisbursementListController cdlc = new ConfirmDisbursementListController();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["UserEntity"];
            if (u == null || u.RoleId != 3)
            {
                Response.Redirect("../Security.aspx");
            }

            if (cdlc.getDisbursementList(u).Count() == 0)
            {
                Label1.Text = "Current Disbursementlist has not been generated yet..";
                confirmBtn.Visible = false;
            }
            else
            {


                List<string> otherinf = cdlc.getrestinfo(u);

                Label1.Text = "Current Week Disbursement List";
                contacName.Text = "Contact Person: " + otherinf[0];
                address.Text = "Collection Point: " + otherinf[1];
                time.Text = "Collection Time: " + otherinf[2];
                colldate.Text = "Collection Date: " + otherinf[3]; 

                GridView1.DataSource = cdlc.getDisbursementList(u);
                GridView1.DataBind();






            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void confirmBtn_Click(object sender, EventArgs e)
        {
            User u = (User)Session["UserEntity"];
            cdlc.confirmRceive(u);
        }
    }
}