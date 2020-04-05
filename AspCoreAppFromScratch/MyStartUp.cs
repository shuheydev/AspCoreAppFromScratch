using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace AspCoreAppFromScratch
{
    public class MyStartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app)
        {
            //Routingの仕組みを使うよ。
            app.UseRouting();

            //Routingの具体的な指定はこれだよ。
            app.UseEndpoints(endpoints =>
            {
                //ここに指定する
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}