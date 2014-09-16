using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutDemo.Samples
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if (value != _password)
                {
                    _password = value;
                    OnPropertyChanged();
                    LoginCommand.ChangeCanExecute();
                }
            }
        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set
            {
                if (value != _userName)
                {
                    _userName = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isRunning;

        public bool IsRunning
        {
            get { return _isRunning; }
            set
            {
                if (value != _isRunning)
                {
                    _isRunning = value;
                    OnPropertyChanged();
                }
            }
        }

        private Command _remindMeCommand;

        public Command RemindMeCommand
        {
            get
            {
                return _remindMeCommand ?? (_remindMeCommand = new Command(
                    () =>
                    {
                        UserName = "Arielbh";
                    }));
            }
        }




        private Command _loginCommand;

        public Command LoginCommand
        {
            get
            {
                return _loginCommand ?? (_loginCommand = new Command(
                   async () =>
                   {
                       IsRunning = true;
                        await Task.Delay(4000);
                        IsRunning = false;

                        Navigation.PushAsync(new Page2());

                    },
                    () => !string.IsNullOrEmpty(Password) || !string.IsNullOrEmpty(UserName)));
            }
        }

        public INavigation Navigation { get; set; }





    }
}
