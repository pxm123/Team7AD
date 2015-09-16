using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.DeptHead;
using ClassLibraryBL.Entities;

namespace LogicUniv1._1.webpage.DeptHead
{
    public partial class DelegateAuthority : System.Web.UI.Page
    {

        DelegateAuthorityController dac = new DelegateAuthorityController();
        


        protected void Page_Load(object sender, EventArgs e)
        {
            
            User u = (User)Session["UserEntity"];
            if (u == null || u.RoleId != 1)
            {
                Response.Redirect("../Security.aspx");
            }


            getAllEmployee(u);
        }

        public void getAllEmployee(User u)
        {
            GridEmp.DataSource = dac.getAllEmployee(u);
            GridEmp.DataBind();
        }



        protected void delegateBtn_Click(object sender, EventArgs e)
        {
            
        }

        protected void GridEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridEmp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridEmp.PageIndex = e.NewPageIndex;
            GridEmp.DataBind();
        }

        protected void ConfirmBtn_Click(object sender, EventArgs e)
        {
            User u = (User)Session["UserEntity"];
            string name = GridEmp.SelectedRow.Cells[0].Text.Trim();
            string uid = GridEmp.SelectedRow.Cells[1].Text.Trim();
            string startDate = checkInDatePicker.Text;
            string endDate = checkOutDatePicker.Text;
            dac.delegateAuthority(uid);
            dac.mailNotification(startDate, endDate, u,name);
            Label2.Text = "Successfuly delegated, Email has been sent to all relevant individual.";
        }




    }
}