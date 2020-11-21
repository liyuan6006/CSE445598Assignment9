using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Project5GroupSln
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // When the application starts setup a thread safe counter used to count active sessions.
            // We will display the number of active users to the user via the UserControl
            // The number of items in the Stack is the count of active users
            var threadSafeCounter = new ConcurrentStack<int>();
            Application["OnlineUserCount"] = threadSafeCounter;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // We are using a thread safe collection and only accessing it on session start and end
            // with the anticipated user load this should not cause concerns related to performance          
            if (Application["OnlineUserCount"] != null)
            {
                var counter = (ConcurrentStack<int>)Application["OnlineUserCount"];
                // Add one 'user' to the count
                counter.Push(1);
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {
            // We are using a thread safe collection and only accessing it on session start and end
            // with the anticipated user load this should not cause concerns related to performance  
            if (Application["OnlineUserCount"] != null)
            {
                var counter = (ConcurrentStack<int>)Application["OnlineUserCount"];
                // remove one 'user' from the count
                counter.TryPop(out _);
            }
        }
    }
}