using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Demo.Services
{
    public static class IClientProxyExtensions
    {
        public static Task SendNoticeAsync<T>(this IClientProxy clientProxy, T data)
            where T : class
        {
            return clientProxy.SendAsync(typeof(T).Name, data);
        }
    }
}
