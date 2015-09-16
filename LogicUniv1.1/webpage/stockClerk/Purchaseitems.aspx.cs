using ClassLibraryBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBL.Controller.stockClerk;
using ClassLibraryBL.Entities;
using ClassLibraryBL.EntityFacade;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LogicUniv1._1.webpage.stockClerk
{
    public partial class Purchaseitem : System.Web.UI.Page
    {
        
        PlaceOrderController pl = new PlaceOrderController();
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["UserEntity"];
            if (u == null || u.RoleId != 4)
            {
                Response.Redirect("../Security.aspx");
            }

            purchase s=(purchase) Session["purchaseitem"];
            List<Purchaseitem111> l = pl.showpurchaseitems(s);
            GridView1.DataSource = l;
            GridView1.DataBind();
            Label3.Text = s.purchaserId.ToString();
            Label5.Text = DateTime.Today.Date.ToShortDateString();
            Label7.Text = s.supplierId.ToString();
            foreach (GridViewRow r in GridView1.Rows)
            {
                DropDownList dp = (DropDownList)r.FindControl("choosesupplier");
                int i=s.supplierId;
                int k=Convert.ToInt32(r.Cells[0].Text);
                int x = s.purchaserId;
                dp.DataSource = pl.getcompanyname(k, i,x);
                dp.DataBind();
            }
            Itemchoose.DataSource = pl.showitemsbysupppier(s.supplierId);
            Itemchoose.DataBind();
        }

      
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
                //GridViewRow gvr = (GridViewRow)((Control)e.CommandSource).Parent.Parent
            User u = (User)Session["UserEntity"];
            if (u.RoleId != 4)
            {
                Response.Redirect("../Security.aspx");
            }
            purchase s = (purchase)Session["purchaseitem"];
            int index=Convert.ToInt32(e.CommandArgument);
            string k =GridView1.Rows[index].Cells[0].Text;
            index = Convert.ToInt32(k);
            DropDownList dp = (DropDownList)GridView1.Rows[0].Cells[0].FindControl("choosesupplier");
            string sp = dp.Text;
            if (e.CommandName == "ChangeSupplier")
            {
                pl.changesupplier(index, s.purchaserId, sp,u.UserId);
                Response.Redirect("Purchaseitems.aspx"); 
            
            };
            if (e.CommandName == "DeleteItem")
            {
                pl.delete(index, s.supplierId, s.purchaserId);
                Response.Redirect("Purchaseitems.aspx"); 
            }
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            purchase s = (purchase)Session["purchaseitem"];
            string description = Itemchoose.SelectedValue;
            int itemcode = pl.finditemcode(description, s.supplierId);
            int qt = Convert.ToInt32(itemnumber.Text);
            pl.additems(itemcode, s.supplierId, s.purchaserId, qt);
            Response.Redirect("Purchaseitems.aspx");
        }
         protected void Button2_Click(object sender, EventArgs e)  
        {  
         Response.Redirect("Reorder.aspx");  
        }

         protected void Button1_Click(object sender, EventArgs e)
         {

         }

         protected void Send_Click(object sender, System.EventArgs e)
         {
             User u = (User)Session["UserEntity"];
            if (u.RoleId != 4){
                Response.Redirect("../Security.aspx");
            }
            string[] st = pl.sendemail(u, Convert.ToInt32(Label7.Text));
        
            string messageBody = "<font>The following are the records: </font><br><br>";
            string from = "lujianfeng1990@hotmail.com";
            string to = "lujianfeng1990@hotmail.com";                
            string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\" >";
            string htmlTableEnd = "</table>";
            string htmlHeaderRowStart = "<tr style =\"background-color:#6FA1D2; color:#ffffff;\">";
            string htmlHeaderRowEnd = "</tr>";
            string htmlTrStart = "<tr style =\"color:#555555;\">";
            string htmlTrEnd = "</tr>";
            string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
            string htmlTdEnd = "</td>";

            messageBody+= htmlTableStart;
            messageBody += htmlHeaderRowStart;
            messageBody += htmlTdStart + "ItmeCode " + htmlTdEnd;
            messageBody += htmlTdStart + "Description " + htmlTdEnd;
            messageBody += htmlTdStart + "Quantity " + htmlTdEnd;
            messageBody += htmlTdStart + "Price " + htmlTdEnd;
            messageBody += htmlTdStart + "Amount " + htmlTdEnd;
            messageBody += htmlHeaderRowEnd;

            foreach (GridViewRow r in GridView1.Rows)
           {
                messageBody = messageBody + htmlTrStart;
                messageBody = messageBody + htmlTdStart + r.Cells[0].Text + htmlTdEnd;
                messageBody = messageBody + htmlTdStart + r.Cells[1].Text + htmlTdEnd;
                messageBody = messageBody + htmlTdStart + r.Cells[2].Text + htmlTdEnd;
                messageBody = messageBody + htmlTdStart + r.Cells[3].Text + htmlTdEnd;
                messageBody = messageBody + htmlTdStart + r.Cells[4].Text + htmlTdEnd;
                messageBody = messageBody + htmlTrEnd;
            }
            messageBody = messageBody + htmlTableEnd;

            MailMessage messge = new MailMessage(from, to);
                 
            messge.Body = messageBody;
            messge.Subject = "Notification: Purchase Order from Logic University Stationery Inventory " ; //change and use session
            messge.IsBodyHtml = true;
            messge.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.live.com";
            client.Credentials = new NetworkCredential("lujianfeng1990@hotmail.com", "ibm1990324");
            client.EnableSsl = true;
            client.Send(messge);
            messge.Attachments.Dispose();


            }
                
        }  

}