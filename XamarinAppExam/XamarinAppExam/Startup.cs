using Microsoft.Extensions.DependencyInjection;
using System;
using XamarinAppExam.Services;
using XamarinAppExam.ViewModel;

namespace XamarinAppExam
{
    public static class Startup
    {
        private static IServiceProvider serviceProvider;
        public static void ConfigureServices()
        {
            var services = new ServiceCollection();

            //add services
            services.AddSingleton<IBetPlayService, InMemoryBetPlayService>();

            //add viewmodels
            services.AddTransient<BetPlayViewModel>();
            services.AddTransient<AddBetPlayViewModel>();
            services.AddTransient<BetPlayDetailsViewModel>();

            serviceProvider = services.BuildServiceProvider();
        }

        public static T Resolve<T>() => serviceProvider.GetService<T>();
    }
}
