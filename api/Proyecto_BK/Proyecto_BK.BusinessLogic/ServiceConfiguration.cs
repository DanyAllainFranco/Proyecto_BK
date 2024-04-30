using Microsoft.Extensions.DependencyInjection;
using Proyecto_BK.DataAccess;
//using Proyecto_BK.DataAccess.Repository;
using Proyecto_BK.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_BK.BusinessLogic.Services
{
    public static class ServiceConfiguration
    {
        public static void DataAccess(this IServiceCollection service, string conn)
        {


            Proyecto_BKContext.BuildConnectionString(conn);
        }
        public static void BusinessLogic(this IServiceCollection service)
        {

        }
    }
}
