﻿using EcommerceData.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceData.ServiceExtension
{
    public static class ServiceExtension
    {
        public static void RegisterDBContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>

        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
        , getAssembly => getAssembly.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
        , ServiceLifetime.Transient);

            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseNpgsql(config.GetConnectionString("DefaultConnection"), 
            //    getAssembly => getAssembly.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        }
    }
}
