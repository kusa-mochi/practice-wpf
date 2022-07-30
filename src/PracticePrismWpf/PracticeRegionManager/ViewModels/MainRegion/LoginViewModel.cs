using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeRegionManager.ViewModels.MainRegion
{
    public class LoginViewModel : BindableBase
    {
        private string _Hoge = "てちゅてちゅシンカリオン！";
        public string Hoge
        {
            get { return _Hoge; }
            set { SetProperty(ref _Hoge, value); }
        }

        public LoginViewModel()
        {
        }

    }
}
