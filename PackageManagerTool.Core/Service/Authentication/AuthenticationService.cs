using PackageManagerTool.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversalDatabaseAdapter;
using UniversalDatabaseAdapter.DapperConnection;

namespace PackageManagerTool.Core.Service.Authentication
{
    public class AuthenticationService
    {
        private readonly BaseConnection _base;
        private string _facility;

        public AuthenticationService(DatabaseSettings databaseSettings, string facility)
        {
            _base = BaseConnection.Instance;
            _base.DatabaseSettings = databaseSettings;

            _facility = facility;
        }

        public void AuthenticateUser(string imei, int Printedby, string workstation, string username)
        {
            try
            {
                if (_facility == "LTI")
                    _base.ExecuteQuery(Db.TrackingSystem.Queries.AuthenticateUser, new { Imei = imei, printedBy = Printedby, Workstation = workstation, Username = username }, Db.TrackingSystem.Name);
                else
                    _base.ExecuteQuery(Db.ChronosUK.Queries.AuthenticateUser,new { Imei = imei, printedByid = Printedby},Db.ChronosUK.Name);
            }
            catch (Exception)
            {
                throw new Exception("ERROR_IN_ADMIN_AUTHENTICATION");
            }
        }

        public string GetPasswordHash(string username)
        {
            try
            {
                   // return _base.ExecuteQuery<string>(Db.TrackingSystem.Queries.GetPasswordHash,new { Username = username},Db.TrackingSystem.Name,ReturnType.Single);
               
                    return _base.ExecuteQuery<string>(Db.TrackingSystem.Queries.GetPasswordHash, new { Username = username }, Db.TrackingSystem.Name, ReturnType.Single);
            }
            catch(Exception)
            {
                throw new Exception("Error in Account Authentication");
            }
        }


       
    }
}
