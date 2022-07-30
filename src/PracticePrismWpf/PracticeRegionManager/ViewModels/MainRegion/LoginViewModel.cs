using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeRegionManager.ViewModels.MainRegion
{
    public class LoginViewModel : BindableBase
    {
        #region Hoge 変更通知プロパティ

        private string _Hoge = "てちゅてちゅシンカリオン！";
        public string Hoge
        {
            get { return _Hoge; }
            set { SetProperty(ref _Hoge, value); }
        }

        #endregion

        #region LogInCommand コマンド

        private DelegateCommand _LogInCommand;
        public DelegateCommand LogInCommand =>
            _LogInCommand ?? (_LogInCommand = new DelegateCommand(ExecuteLogInCommand));
        void ExecuteLogInCommand()
        {
            _regionManager?.RequestNavigate("MainRegion", "Main_Front");
        }

        #endregion

        #region コンストラクタ

        public LoginViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion

        #region フィールド

        private IRegionManager _regionManager = null;

        #endregion
    }
}
