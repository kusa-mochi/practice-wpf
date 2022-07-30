using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeRegionManager.ViewModels.Modals
{
    public class DetailModalViewModel : BindableBase, IDialogAware
    {
        public DetailModalViewModel()
        {

        }

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
