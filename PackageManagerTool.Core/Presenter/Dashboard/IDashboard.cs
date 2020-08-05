using PackageManagerTool.Core.Base;
using PackageManagerTool.Core.Model.ChronosUK;
using PackageManagerTool.Core.Model.TrackingSystem;

namespace PackageManagerTool.Core.Presenter.Dashboard
{
   public interface IDashboardView : IView<IDashboardPresenter>
    {
        void ClearControls();
        //void DisplayIMEIDetails(Receiving DataSource, string LCMType,iPhoneModel PhoneModel);
        void DisplayIMEIDetails(Receiving DataSource, string LCMType,string PackagingType, string ShiptoClient);
        void PrintBarcodeLabel(string DeviceImei, string PartNo, string PhoneModel,string PrintType, string LCMType);
        void AddPrintLogs(string DeviceImei, string workstation);
        void AuthenticateUser(string username, string password, string Imei);
        bool isPrinted(string DeviceImei, string caption, string message, bool isErrorMessage);
        bool ForReprint();
       // string UserType();
    }
    public interface IDashboardPresenter: IPresenter<IDashboardView>
    {
        void DisplayIMEIDetails(string DeviceIMEI);
        void PrintBarcodeLabel(string DeviceImei, string PartNo, string PhoneModel,string PrintType,string LCMType);
        void ShowPackagingInstruction(string PackagingType);
        void AddPrintLogs(string DeviceImei,string workstation);
        void AuthenticateUser(string username, string password, string Imei);
        bool isPrinted(string DeviceImei, string caption, string message, bool isErrorMessage);
        bool ForReprint();
       // string UserType();

    }
}
