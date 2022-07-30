using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeRegionManager.ViewModels.Modals
{
    public class DetailModalViewModel : BindableBase, IDialogAware
    {
        #region ShowLargeItemsCommand コマンド

        private DelegateCommand _ShowLargeItemsCommand;
        public DelegateCommand ShowLargeItemsCommand =>
            _ShowLargeItemsCommand ?? (_ShowLargeItemsCommand = new DelegateCommand(ExecuteShowLargeItemsCommand));
        void ExecuteShowLargeItemsCommand()
        {
            _regionManager.RequestNavigate("DetailRegion", "Detail_Large");
        }

        #endregion

        #region ShowMiddleItemsCommand コマンド

        private DelegateCommand _ShowMiddleItemsCommand;
        public DelegateCommand ShowMiddleItemsCommand =>
            _ShowMiddleItemsCommand ?? (_ShowMiddleItemsCommand = new DelegateCommand(ExecuteShowMiddleItemsCommand));
        void ExecuteShowMiddleItemsCommand()
        {
            _regionManager.RequestNavigate("DetailRegion", "Detail_Middle");
        }

        #endregion

        #region ShowSmallItemsCommand コマンド

        private DelegateCommand _ShowSmallItemsCommand;
        public DelegateCommand ShowSmallItemsCommand =>
            _ShowSmallItemsCommand ?? (_ShowSmallItemsCommand = new DelegateCommand(ExecuteShowSmallItemsCommand));
        void ExecuteShowSmallItemsCommand()
        {
            _regionManager.RequestNavigate("DetailRegion", "Detail_Small");
        }

        #endregion

        #region コンストラクタ

        public DetailModalViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        #endregion

        #region フィールド

        private IRegionManager _regionManager = null;

        #endregion

        #region IDialogAware の実装

        public string Title => "てちゅてちゅもーだる";

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
        }

        #endregion
    }
}
