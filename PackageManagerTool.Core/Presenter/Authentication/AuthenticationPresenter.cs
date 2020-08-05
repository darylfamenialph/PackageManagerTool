using PackageManagerTool.Core.Service.Authentication;
using PackageManagerTool.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManagerTool.Core.Presenter.Authentication
{
    public class AuthenticationPresenter : IAuthenticationPresenter
    {
        #region BackingFields
        IAuthenticationView _view;
        #endregion
        #region Private Variables
        private IApplicationController _appController;
        private AuthenticationService _service;
        private int _loggedInId;
        private string _username,_imei;
        private bool _status;

        #endregion
        #region Public Properties
        public IAuthenticationView View
        {
            get
            {
                return _view;
            }

        }
        #endregion


        public AuthenticationPresenter(IAuthenticationView view, IApplicationController appController, int LoggedInUserId,string Username,string Imei)
        {
            _view = view;
            _view.Presenter = this;

            _appController = appController;

            _service = new AuthenticationService(_appController.DatabaseSettings, _appController.Facility);

            _loggedInId = LoggedInUserId;
            _username = Username;
            _imei = Imei;
        }



        public void Run()
        {
            _view.Run();
        }

        public void AuthenticateUser(string username, string password)
        {
           try
            {
                _service.AuthenticateUser(_imei, _loggedInId,Environment.MachineName,_username);
               var passwordHash =  _service.GetPasswordHash(username);
                if (PasswordHash.ValidatePassword(password, passwordHash))
                {
                    _view.ShowMessage("Info", $"The IMEI is {_imei} ", false);
                    _status = false;
                    _view.Stop();
                }
                else
                    throw new Exception("INVALID ACCOUNT");
            }
            catch(Exception ex)
            {
                _view.ShowMessage("Error",$"Error in Authenticating User:{ex.Message}",true);
            }
        }

        public bool isCancelled()
        {
            return _status;
        }

        public void isDone(bool status)
        {
            _status = status;
        }
    }
}
