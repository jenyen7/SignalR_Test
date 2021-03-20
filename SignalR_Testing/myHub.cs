using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR_Testing
{
    //[HubName("chat")]
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
        //public void Hello()
        //{
        //    Clients.All.hello();
        //}
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }

        [HubMethodName("announceToEveryBody")]
        public void Announce(string message)
        {
            Clients.All.Announce(message);
        }

        public DateTime GetServerDateTime()
        {
            return DateTime.Now;
        }

        //public void GetServerDateTime()
        //{
        //    Clients.Caller.DisplayDateTime();
        //}
    }
}