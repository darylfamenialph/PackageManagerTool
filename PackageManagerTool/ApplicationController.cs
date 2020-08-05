using PackageManagerTool.Core;
using PackageManagerTool.Core.Presenter.Authentication;
using PackageManagerTool.Core.Presenter.Dashboard;
using PackageManagerTool.Core.Presenter.PackagingInstruction;
using System;
using System.Windows.Forms;
using UniversalDatabaseAdapter;
using UniversalDatabaseAdapter.Adapters;

namespace PackageManagerTool
{
    
    public class ApplicationController : IApplicationController
    {
        #region Backing Fields
        DatabaseSettings _databaseSettings;
        string _facility,_username;
        int _loggedInId;
        string _userType;
        #endregion
        public ApplicationController(DatabaseSettings databaseSettings,string facility,int LoggedInUserID,string username, string UserType)
        {
            _databaseSettings = databaseSettings;
            _facility = facility;
            _loggedInId = LoggedInUserID;
            _username = username;
            _userType = UserType;

        }

        public DatabaseSettings DatabaseSettings
        {
            get
            {
               return _databaseSettings;
            }
        }

        public string SystemName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Facility
        {
            get
            {
               return  _facility;
            }
        }

        public int LoggedInID
        {
            get
            {
               return _loggedInId;
            }
        }

        public string UserType
        {
            get
            {
                return _userType;
            }
        }

        public void RunSystem()
        {
            RunDashboard();
        }
        public void RestartSystem()
        {
            Application.Restart();
        }
        public void StopSystem()
        {
            Environment.Exit(0);
        }
        public void RunDashboard()
        {
            using (var view = new VwDashboard())
            {
                IDashboardPresenter presenter = new DashboardPresenter(view, this, _loggedInId);
                presenter.Run();
            }
        }

        public void RunPackagingInstruction(string PackagingType)
        {
            using (var view = new VwPackagingInstruction())
            {
                IPackagingInstructionPresenter presenter = new PackagingInstructionPresenter(view, this, PackagingType);
                presenter.Run();
            }
        }

        public bool RunAuthentication(string Imei)
        {
            using (var view = new VwAuthentication())
            {
                IAuthenticationPresenter presenter = new AuthenticationPresenter(view, this, _loggedInId, _username, Imei);
                presenter.Run();
                if (presenter.isCancelled())
                    return true;
                else
                    return false;
                 
            } 
        }
    }
}
