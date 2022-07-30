using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
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

        #region OpenDetailModal コマンド

        private DelegateCommand<IRegionManager> _OpenDetailModal;
        public DelegateCommand<IRegionManager> OpenDetailModal =>
            _OpenDetailModal ?? (_OpenDetailModal = new DelegateCommand<IRegionManager>(ExecuteOpenDetailModal));
        void ExecuteOpenDetailModal(IRegionManager parameter)
        {
            _dialogService.ShowDialog("Modal_Detail");
        }

        #endregion

        #region コンストラクタ

        public FrontViewModel(IRegionManager regionManager, IDialogService dialogService)
        {
            _regionManager = regionManager;
            _dialogService = dialogService;
        }

        #endregion

        #region フィールド

        private IRegionManager _regionManager = null;
        private IDialogService _dialogService = null;

        #endregion
    }
}
