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
    public partial class RequisitionDetails : System.Web.UI.Page
    {
        NewMessageController nmc = new NewMessageController();


        ViewCurrentRequisitionDetails vcrd = new ViewCurrentRequisitionDetails();
        ViewPastRequistionController vprc = new ViewPastRequistionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["UserEntity"];
            if (u == null || u.RoleId != 1)
            {
                Response.Redirect("../Security.aspx");
            }




            if (Request.Params["rid"] != null && Request.Params["idet"] != null)
            {
                retrievePreReqDetailsForHead(Request.Params["rid"]);
            }

            else
            {
                retrieveReqDetails(Request.Params["rid"]);
            }
            Session["newmsg"] = nmc.getAllmessage(u);

            int msgCount = nmc.getAllmessage(u).Count();
            msgcount2.Text = msgCount.ToString();
            NewMessage.Text = "You have " + msgCount + " new message";


        }
        public void retrievePreReqDetailsForHead(string rid)
        {
            Session["reqdetails"] = vprc.getRequisitionDetails(rid);
            reqid.Text = "Requisition Number: " + Request.Params["rid"];
            reqby.Text = "Requested By :" + vcrd.getRequisitionDetails(rid).First().Name;
            status.Text = "Status :" + vcrd.getRequisitionDetails(rid).First().Status_dept;
            colpoint.Text = "Collection Point: " + vcrd.getRequisitionDetails(rid).First().CollectionPoint;
            RejectBtn.Visible = false;
            ApproveBtn.Visible = false;
        }


        public void retrieveReqDetails(string rid)
        {
            Session["reqdetails"] = vcrd.getRequisitionDetails(rid);
            reqid.Text = "Requisition Number: " + Request.Params["rid"];
            reqby.Text = "Requested By :" + vcrd.getRequisitionDetails(rid).First().Name;
            status.Text = "Status :" + vcrd.getRequisitionDetails(rid).First().Status_dept;
            colpoint.Text = "Collection Point: " + vcrd.getRequisitionDetails(rid).First().CollectionPoint;

        }

        protected void ApproveBtn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.Params["rid"]);
            vcrd.approveRequisition(x);
            retrieveReqDetails(Request.Params["rid"]);
            RejectBtn.Enabled = false;
            ApproveBtn.Enabled = false;
            Labelflag.Text = "Successful Approved.";
            Response.Redirect("HeadHome.aspx");
        }

        protected void RejBtn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.Params["rid"]);
            string reason = RejReason.Text;
            vcrd.rejectRequisition(x,reason);
            retrieveReqDetails(Request.Params["rid"]);
            Labelflag.Text = "Requisition Rejected.";
            RejectBtn.Enabled = false;
            ApproveBtn.Enabled = false;
            Response.Redirect("HeadHome.aspx");
        }
    }
}