using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatDemo
{
    public class ChatDemo : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
    }
}