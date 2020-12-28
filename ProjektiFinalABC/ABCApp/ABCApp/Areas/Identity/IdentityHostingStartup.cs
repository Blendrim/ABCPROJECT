using System;
using ABCApp.Areas.Identity.Data;
using ABCApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ABCApp.Areas.Identity.IdentityHostingStartup))]
namespace ABCApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ABCAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ABCAppContextConnection")));

                services.AddDefaultIdentity<ABCApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ABCAppContext>();
            });
        }
    }
}