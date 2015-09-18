using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL;
using ClassLibraryBL.Entities;
using ClassLibraryBL.Controller;

namespace ClassLibraryBL.EntityFacade
{
    public class messageFacade
    {
        LogicUnivSystemEntities luse = new LogicUnivSystemEntities();

        public List<realmessage> getAllmessage(User u)
        {
            var msg = (from x in luse.requisitions
                       where x.status_dept == "Pending" && x.departmentId == u.DepartmentId
                       select new realmessage
                       {
                           MSG1 = x.requisitionId,
                           Msgdatetime = x.requestDate,
                           Status = x.status
                       }
                       ).ToList();
                     return msg;
        }


    }
}
