using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;
namespace ClassLibraryBL.Controller.DeptHead
{
    public class NewMessageController
    {
        messageFacade mf = new messageFacade();
        public List<realmessage> getAllmessage(User u)
        {
            return mf.getAllmessage(u);
        }

    }
}
