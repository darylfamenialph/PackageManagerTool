

using UniversalDatabaseAdapter;
using UniversalDatabaseAdapter.Adapters;

namespace PackageManagerTool
{
    public class Injector
    {
        DatabaseSettings _databaseSettings;
        string _facility,_username,_userType;
        int _loggedInId;


       
        public Injector(string facility,string host, string username, string password,int LoggedInUserId, string User,string UserType,string schema = "")
        {
            MySqlAdapter databaseAdapter;

            if (string.IsNullOrEmpty(schema))
            {
                databaseAdapter = new MySqlAdapter(host, username, password);
            }
            else
            {
                databaseAdapter = new MySqlAdapter(host, username, password, schema);
            }

            _databaseSettings = new DatabaseSettings(databaseAdapter);
            _facility = facility;
            _loggedInId = LoggedInUserId;
            _username = User;
            _userType = UserType;
        }

        public void RunPackageManagerTool()
        {
            var appController = new ApplicationController(_databaseSettings,_facility, _loggedInId, _username,_userType);
            appController.RunSystem();
        }
    }
}
