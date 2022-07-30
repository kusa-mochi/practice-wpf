using PracticeRegionManager.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace PracticeRegionManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Views.MainRegion.Login>("Main_Login");
            containerRegistry.RegisterForNavigation<Views.MainRegion.Front>("Main_Front");
            containerRegistry.RegisterDialog<Views.Modals.DetailModal>("Modal_Detail");
        }
    }
}
