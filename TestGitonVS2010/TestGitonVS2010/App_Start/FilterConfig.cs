﻿using System.Web;
using System.Web.Mvc;

namespace TestGitonVS2010
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}