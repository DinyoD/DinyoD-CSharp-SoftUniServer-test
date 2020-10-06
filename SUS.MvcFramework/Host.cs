﻿using SUS.HTTP;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SUS.MvcFramework
{
    public static class Host
    {
        public static async Task CreateHostAsync(IMvcAplication app, int port =80)
        {
            List<Route> routeTable = new List<Route>();
            app.Configure(routeTable);
            app.ConfigureServices();


            IHttpServer server = new HttpServer(routeTable);
            await server.StartAsync(port);
        }
    }
}
