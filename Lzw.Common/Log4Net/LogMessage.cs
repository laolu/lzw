using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.SessionState;

namespace Lzw.Common.Log4Net
{
    public class LogMessage : IRequiresSessionState
    {
        public LogMessage() {
            this.userID = 0;
            this.userName = string.Empty;
        }
        public LogMessage(long userID, string userName)
        {
            this.userID = userID;
            this.userName = userName;
        }
        private long userID;
        public long UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private string userName;
        public string LoginName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
