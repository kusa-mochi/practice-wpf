using Prism.Mvvm;
using Prism.Regions;

namespace PracticeRegionManager.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public string Title { get; set; } = "けーねアプリ";

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(PracticeRegionManager.Views.MainRegion.Login));
        }

        private IRegionManager _regionManager = null;
    }
}
