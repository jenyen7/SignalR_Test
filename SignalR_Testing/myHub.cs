using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR_Testing
{
    public class myHub : Hub
    {
        //public void Hello()
        //{
        //    Clients.All.hello();
        //}
        //public void Send(string name, string message)
        //{
        //    // Call the broadcastMessage method to update clients.
        //    Clients.All.broadcastMessage(name, message);
        //}

        public void Announce(string message)
        {
            Clients.All.Announce(message);
        }
    }
}