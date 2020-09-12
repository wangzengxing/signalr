using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SignalRDemo.Service
{
    public class CustomerUserIdProvider : IUserIdProvider
    {
        public string GetUserId(HubConnectionContext connection)
        {
            if (connection.User.Identity.IsAuthenticated)
            {
                return connection.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            }
            else
            {
                return connection.ConnectionId;
            }
        }
    }
}
