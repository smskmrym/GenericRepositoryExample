using System;
using GenericRepositoryExample.Areas.Identity.Data;
using GenericRepositoryExample.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


[assembly: HostingStartup(typeof(GenericRepositoryExample.Areas.Identity.IdentityHostingStartup))]
namespace GenericRepositoryExample.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GenericRepositoryExampleContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GenericRepositoryExampleContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                .AddEntityFrameworkStores<GenericRepositoryExampleContext>();
            });
        }
    }
}