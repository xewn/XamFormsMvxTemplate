﻿using MvvmCross.Core.ViewModels;

namespace XamForms.MvxTemplate.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        private string _title;
        private bool _isBusy;

        public BaseViewModel()
        {
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }
    }
}
