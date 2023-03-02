using MvvmCross.IoC;
using MvvmCross.ViewModels;
using DashboardLeadrat.Core.ViewModels.Home;
using DashboardLeadrat.Core.ViewModels;

namespace DashboardLeadrat.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<DashboardViewModel>();
        }
    }
}
