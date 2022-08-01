using Microsoft.Extensions.Hosting; 
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting; 
using Microsoft.Extensions.Configuration;

using appDevAsm;

public class Program
{
    public static void Main(string[] args)
    {
        // Build -  tạo các dịch vụ đã đăng ký trả về WebHost
        // Run - chạy ứng dụng web
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                
                webBuilder.UseStartup<Startup>();
            });
}
   