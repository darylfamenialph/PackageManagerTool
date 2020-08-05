using UniversalDatabaseAdapter;

namespace PackageManagerTool.Core
{
   public interface IApplicationController
    {
        string SystemName { get; }

        DatabaseSettings DatabaseSettings { get; }
        
        string Facility { get; }
        int LoggedInID { get; }
        string UserType { get; }

        void RunSystem();
        void RestartSystem();
        void StopSystem();

        void RunDashboard();
        void RunPackagingInstruction(string PackagingType);
        bool RunAuthentication(string Imei);
    }
}
