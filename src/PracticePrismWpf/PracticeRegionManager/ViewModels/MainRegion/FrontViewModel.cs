using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeRegionManager.ViewModels.MainRegion
{
    public class FrontViewModel : BindableBase
    {
        private string _Hoge = "てちゅてちゅカイサツブレード！！！！！";
        public string Hoge
        {
            get { return _Hoge; }
            set { SetProperty(ref _Hoge, value); }
        }

        public FrontViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        private IRegionManager _regionManager = null;
    }
}
