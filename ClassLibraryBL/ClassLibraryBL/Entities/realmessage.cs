using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace ClassLibraryBL.Entities
{
    public class realmessage
    {
        int MSG;
         [DataMember]
        public int MSG1
        {
            get { return MSG; }
            set { MSG = value; }
        }
         DateTime msgdatetime;
         [DataMember]
        public DateTime Msgdatetime
        {
            get { return msgdatetime; }
            
            set {
                msgdatetime = value;
                convert();
                }
         }
         public void convert()
         {
             timespan = (DateTime.Now - msgdatetime).TotalHours.ToString().Split('.')[0];
         }

         string timespan;
        [DataMember]
         public string Timespan
         {
             get { return timespan; }
             set { timespan = value; }
         }


        string status;
         [DataMember]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
