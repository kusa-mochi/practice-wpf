using Prism.Ioc;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PracticeRegionManager.Common
{
    public class GlobalDialogService : DialogService
    {
        protected override void ConfigureDialogWindowContent(string dialogName, IDialogWindow window, IDialogParameters parameters)
        {
            IRegionManager rm = _regionManager.CreateRegionManager();
            RegionManager.SetRegionManager(window as Window, rm);
            RegionManager.UpdateRegions();
            parameters.Add("rm", rm);

            base.ConfigureDialogWindowContent(dialogName, window, parameters);
        }

        public GlobalDialogService(IContainerExtension containerExtension, IRegionManager regionManager) : base(containerExtension)
        {
            _containerExtension = containerExtension;
            _regionManager = regionManager;
        }

        private readonly IContainerExtension _containerExtension;
        private readonly IRegionManager _regionManager;
    }
}
