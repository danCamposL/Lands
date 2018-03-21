namespace Lands.ViewModel
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    class LoginViewModel
    {
        #region Properties
        public string User
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }

        public bool IsRemembered
        {
            get;
            set;
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private void Login()
        {
            
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
        }

        #endregion
    }
}
