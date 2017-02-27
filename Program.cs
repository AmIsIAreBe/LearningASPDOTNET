using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(
                Context =>
                { 
                    return Context.Response.WriteAsync("Hello Mike into the beyond");
                }
            );
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            //execute host and display it to webbrowser
            host.Run();

            //Console.WriteLine("Hello World!");
            //var name = Console.ReadLine();
            //Console.WriteLine($"Hello {name} welcome to C#");
        }
    }
}