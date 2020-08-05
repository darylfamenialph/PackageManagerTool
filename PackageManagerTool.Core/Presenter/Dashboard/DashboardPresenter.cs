using PackageManagerTool.Core.Model.ChronosUK;
using PackageManagerTool.Core.Model.TrackingSystem;
using PackageManagerTool.Core.Service.Dashboard;
using PackageManagerTool.Core.Utilities;
using System;

namespace PackageManagerTool.Core.Presenter.Dashboard
{
    public class DashboardPresenter : IDashboardPresenter
    {
        #region Backing Fields
        IDashboardView _view;
        #endregion
        #region Private Variables
        private IApplicationController _appController;
        private DashboardService _service;
        private int _loggedInId;
        private bool _forReprint;
        private string _userType;
        #endregion
        #region Public Properties
        public IDashboardView View
        {
            get
            {
                return _view;
            }

        }
        #endregion
        public DashboardPresenter(IDashboardView view, IApplicationController appController,int LoggedInUserId)
        {
            _view = view;
            _view.Presenter = this;

            _appController = appController;

            _service = new DashboardService(_appController.DatabaseSettings,_appController.Facility);

            _loggedInId = LoggedInUserId;
            _userType = _appController.UserType;
        }



        public void Run()
        {
            _view.Run();
        }
        public void DisplayIMEIDetails(string DeviceIMEI)
        {
            try
            {
                if (string.IsNullOrEmpty(DeviceIMEI))
                {
                    _view.ShowMessage("Empty Input", "An input is required.", true);
                    
                }
                else
                {
                    if (DeviceIMEI.Length == 15)
                    {
                        _view.ClearControls();
                        string LCMType = "OEM";
                         var client = _service.GetClient(DeviceIMEI);
                        var  imeiDetails = _service.GetIMEIData<Receiving>(DeviceIMEI, client);
                        var shiptoClient = _service.GetShipto(DeviceIMEI);
                        var packagingType = _service.GetPackagingTypeData(DeviceIMEI);
                        //var isOQC = _service.IsOQC(DeviceIMEI,client);
                        //if (isOQC)
                          //  LCMType = "OQC";
                        //else
                           // LCMType = "OEM";
                        _view.DisplayIMEIDetails(imeiDetails, LCMType, packagingType, shiptoClient);
                    }
                    else
                    {
                        _view.ShowMessage("Invalid Input", "The entered imei exceeds/lack the default length of 15 characters.", true);
                    }
                }
            }catch(Exception ex)
            {
                _view.ShowMessage("Error", ex.Message, true);
            }
        }

        public void PrintBarcodeLabel(string DeviceImei, string PartNo, string PhoneModel,string PrintType,string LCMType)
        {
            try
            {
                switch (PrintType)
                    {
                        case "LabelwithLCMType":
                            {
                                BrotherLabel.Initialize($@"{AppDomain.CurrentDomain.BaseDirectory}Resources\Labels\ICT_Label-LCM.lbx");

                                BrotherLabel.SetObjectValue("Model", PhoneModel);
                                BrotherLabel.SetObjectValue("PartNo", PartNo);
                                BrotherLabel.SetObjectValue("PartNoBarcode", PartNo);
                                BrotherLabel.SetObjectValue("IMEI", DeviceImei);
                                BrotherLabel.SetObjectValue("IMEIBarcode", DeviceImei);
                                BrotherLabel.SetObjectValue("LCMType", LCMType);

                            }
                            break;
                        case "ImeiLabel":
                            {
                                BrotherLabel.Initialize($@"{AppDomain.CurrentDomain.BaseDirectory}Resources\Labels\24IMEILabel(least).lbx");

                                BrotherLabel.SetObjectValue("imeivalue", DeviceImei);
                                BrotherLabel.SetObjectValue("imeibarcode", DeviceImei);
                                BrotherLabel.SetObjectValue("modelname", PhoneModel);
                            }
                            break;

                    case "Amazon":
                        {
                            BrotherLabel.Initialize($@"{AppDomain.CurrentDomain.BaseDirectory}Resources\Labels\amazon.lbx");

                            BrotherLabel.SetObjectValue("Text12", PhoneModel);
                            BrotherLabel.SetObjectValue("PartNo", PartNo);
                            BrotherLabel.SetObjectValue("PartNoBarcode", PartNo);
                            BrotherLabel.SetObjectValue("IMEI", DeviceImei);
                            BrotherLabel.SetObjectValue("IMEIBarcode", DeviceImei);
                        }
                        break;
                    case "DEFAULT":
                            {
                                BrotherLabel.Initialize($@"{AppDomain.CurrentDomain.BaseDirectory}Resources\Labels\ICT_Label.lbx");

                                BrotherLabel.SetObjectValue("Model", PhoneModel);
                                BrotherLabel.SetObjectValue("PartNo", PartNo);
                                BrotherLabel.SetObjectValue("PartNoBarcode", PartNo);
                                BrotherLabel.SetObjectValue("IMEI", DeviceImei);
                                BrotherLabel.SetObjectValue("IMEIBarcode", DeviceImei);
                            }
                            break;



                    }
                    BrotherLabel.Print(1, true);
                
                   
             }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ShowPackagingInstruction(string PackagingType)
        {
            _appController.RunPackagingInstruction(PackagingType);
        }

        public void AddPrintLogs(string DeviceImei, string workstation)
        {
            try
            {
                _service.AddPrintLog(DeviceImei, _loggedInId, workstation);
            } catch(Exception ex)
            {
                _view.ShowMessage("Error", ex.Message, true);
            }
            
        }

        public bool isPrinted(string DeviceImei,string caption, string message, bool isErrorMessage)
        {
            _forReprint = true;
            if (_service.IsPrinted(DeviceImei))
            {
               
                    if (_view.PromptMessage(caption, message, isErrorMessage))
                    {
                        if (_appController.UserType == "Admin" || _appController.UserType == "Super User")
                        {
                            return false;
                        }
                        else
                        {
                            if (_appController.RunAuthentication(DeviceImei))
                            {
                                _forReprint = true;
                                return true;
                            }
                            else
                            {
                                _forReprint = false;
                                return false;
                            }
                        }
                    }
                    else
                        return true;
                
                
            }
            else
                return false;

        }

        public bool ForReprint()
        {
            return _forReprint;
        }

        public void AuthenticateUser(string username, string password, string Imei)
        {
            try
            {
                _service.AuthenticateUser(Imei, _loggedInId, Environment.MachineName, username);
                _service.GetPasswordHash(username);
               
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Error", $"Error in Authenticating User:{ex.Message}", true);
            }
        }

       // public string UserType()
       // {
           // return _userType;
       // }
    }
}
