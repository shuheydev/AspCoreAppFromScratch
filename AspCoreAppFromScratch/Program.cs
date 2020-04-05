using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AspCoreAppFromScratch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //サーバーインスタンスの設定
            IHostBuilder hostBuilder = MyCreateHostBuilder(args);

            //サーバーインスタンスの生成、サーバープロセスの起動
            hostBuilder.Build()
                       .Run();
        }

        private static IHostBuilder MyCreateHostBuilder(string[] args)
        {
            //MyStartUpクラスの中で色々な設定を行う
            return Host.CreateDefaultBuilder(args)
                        .ConfigureWebHostDefaults(webBuilder =>
                        {
                            webBuilder.UseStartup<MyStartUp>();
                        });
        }
    }
}