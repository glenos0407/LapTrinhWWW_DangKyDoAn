﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DangKyDoAn_BTL
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "LoginSinhVien", id = UrlParameter.Optional }
            );
            
            routes.MapRoute(
                name: "GiangVien",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "LoginGiangVien", id = UrlParameter.Optional }
            );
        }
    }
}
