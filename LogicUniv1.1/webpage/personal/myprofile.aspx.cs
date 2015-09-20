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


namespace LogicUniv1._1.webpage.personal
{
    public partial class myprofile : System.Web.UI.Page
    {
        LogicUnivSystemEntities ctx = new LogicUnivSystemEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                fuck();
            }             
                 
        }
        void fuck()
        {
            User u = (User)Session["UserEntity"];
            var n = (from a in ctx.users
                     where a.userId == u.UserId
                     select new
                     {
                         a.userId,
                         a.name,
                         a.password,
                         a.email,
                         a.address,
                         a.phoneNo
                     }).SingleOrDefault();

            TextBox7.Text = n.userId.ToString();
            TextBox8.Text = n.name.ToString();
            TextBox3.Text = n.password.ToString();
            TextBox4.Text = n.email.ToString();
            TextBox5.Text = n.address.ToString();
            TextBox6.Text = n.phoneNo.ToString();
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
           
                User u = (User)Session["UserEntity"];
                var n = ctx.users.SingleOrDefault(m => m.userId == u.UserId);

                n.name = TextBox8.Text;
                n.password = TextBox3.Text;
                n.email = TextBox4.Text;
                n.address = TextBox5.Text;
                n.phoneNo = TextBox6.Text;
                ctx.SaveChanges();
                Label9.Text = "Update Succesful!";
            
        }
    }
}