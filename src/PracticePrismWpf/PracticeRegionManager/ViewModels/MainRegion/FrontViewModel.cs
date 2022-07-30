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
        #region Hoge 変更通知プロパティ

        private string _Hoge = "てちゅてちゅカイサツブレード！！！！！";
        public string Hoge
        {
            get { return _Hoge; }
            set { SetProperty(ref _Hoge, value); }
        }

        #endregion

        #region LogOutCommand コマンド

        private DelegateCommand _LogOutCommand = null;
        public DelegateCommand LogOutCommand =>
            _LogOutCommand ?? (_LogOutCommand = new DelegateCommand(ExecuteLogOutCommand));
        void ExecuteLogOutCommand()
        {
            _regionManager?.RequestNavigate("MainRegion", "Main_Login");
        }

        #endregion

        #region コンストラクタ

        public FrontViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion

        #region フィールド

        private IRegionManager _regionManager = null;

        #endregion
    }
}
