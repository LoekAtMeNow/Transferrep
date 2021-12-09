using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouse
{
    internal class Messages
    {
        public int MessageID { get; set; }
        public string MessageTitle { get; set; }
        public string MessageStatus { get; set; }
        public string MessageDetail { get; set; }
        public string PersonName { get; set; }
        public bool AnonymousMessage { get; set; }
        public bool SendToOwner { get; set; }
        public DateTime MessageDate { get; set; }


        public void AddMessage()
        {

        }

        public void AddReport()
        {

        }

        public string UpdateMessage()
        {
            string UpdatedMessage = "";

            return UpdatedMessage;
        }

        public void ReadMessageShort()
        {

        }

        public void ReadmessageFull()
        {

        }

        public void ReadStatusReport()
        {

        }

    }
}
