using PackageManagerTool.Core.Model.TrackingSystem;
using PackageManagerTool.Core.Utilities;
using System;
using UniversalDatabaseAdapter;
using UniversalDatabaseAdapter.DapperConnection;

namespace PackageManagerTool.Core.Service.Dashboard
{
    public class DashboardService
    {
        private readonly BaseConnection _base;
        private string _facility;

        public DashboardService(DatabaseSettings databaseSettings,string facility)
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
                    _base.ExecuteQuery(Db.ChronosUK.Queries.AuthenticateUser, new { Imei = imei, printedByid = Printedby }, Db.ChronosUK.Name);
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
            catch (Exception)
            {
                throw new Exception("Error in Account Authentication");
            }
        }

        public Receiving GetIMEIData<Receiving>(string deviceIMEI,string client)
        {
            try
            {
                Receiving resultSet;
                if (_facility == "LTI")
                    if(client == "ECO - JP" || client == "ECO - JPRM")
                        resultSet = _base.ExecuteQuery<Receiving>(Db.TrackingSystem.Queries.JPGetIMEIData, new { DeviceIMEI = deviceIMEI, Client = client }, Db.TrackingSystem.Name, ReturnType.Single);
                    else
                        resultSet = _base.ExecuteQuery<Receiving>(Db.TrackingSystem.Queries.GetIMEIData, new { DeviceIMEI = deviceIMEI, Client = client }, Db.TrackingSystem.Name, ReturnType.Single);
                else
                    resultSet = _base.ExecuteQuery<Receiving>(Db.ChronosUK.Queries.GetPhoneDetail, new { DeviceIMEI = deviceIMEI }, Db.ChronosUK.Name, ReturnType.Single);

                return resultSet;
            } catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "Sequence contains no elements":
                        throw new Exception("Data Fetching Error. Please call the attention of Software Engineers. \r\n\n\n NOTE: This error occurs while fetching data from Phone/Receiving Table with ERROR:'Sequence Contains no elements'. \r\n\n\nNo Data to be fetched.");
                    case "Sequence contains more than one element":
                        throw new Exception("Data Fetching Error. Please call the attention of Software Engineers. \r\n\n\n NOTE: This error occurs while fetching data from Phone/Receiving Table with ERROR:'Sequence Contains more than one element'.\r\n\n\nMore than one same data were saved.");
                    default:
                        throw new Exception(ex.Message);
                }
            }
        }

        public string GetPackagingTypeData(string imei)
        {
            try
            {
                string resultSet;
                if (_facility == "LTI")
                    resultSet = _base.ExecuteQuery<string>(Db.TrackingSystem.Queries.GetPackagingTypeData, new { Imei = imei }, Db.TrackingSystem.Name, ReturnType.Single);
                else
                    resultSet = "Box w/ Accessories (UK ver)";


                return resultSet;
            }catch(Exception ex)
            {
                switch (ex.Message)
                {
                    case "Sequence contains no elements":
                        throw new Exception("Data Fetching Error. Please call the attention of Software Engineers. \r\n\n\n NOTE: This error occurs while fetching data from packaging_type Table join with receiving/stock_shipment_unit/stock_client_matrix table in LTI facility with ERROR:'Sequence Contains no elements'. \r\n\n\nNo Data to be fetched.");
                    case "Sequence contains more than one element":
                        throw new Exception("Data Fetching Error. Please call the attention of Software Engineers. \r\n\n\n NOTE: This error occurs while fetching data from packaging_type Table join with receiving/stock_shipment_unit/stock_client_matrix table in LTI facility with ERROR:'Sequence Contains more than one element'.\r\n\n\nMore than one same data were saved.");
                    case "Subquery returns more than 1 row":
                        throw new Exception("Data Fetching Error. Please call the attention of Software Engineers. \r\n\n\n NOTE:This error occurs while fetching data from Subquery in receiving/stock_shipment_unit/stock_client_matrix table in LTI facility with ERROR: 'Subquery returns more than 1 row'");
                    default:
                        throw new Exception(ex.Message);
                }
            }
        }

        public string GetClient(string imei)
        {
            try
            {
                string resultSet;
                if (_facility == "LTI")
                    resultSet = _base.ExecuteQuery<string>(Db.TrackingSystem.Queries.GetClient, new { Imei = imei }, Db.TrackingSystem.Name, ReturnType.Single);
                else
                    resultSet = string.Empty;

                return resultSet;
            }catch(Exception ex)
            {
                switch (ex.Message)
                {
                    case "Sequence contains no elements":
                        throw new Exception("Data Fetching Error. Please call the attention of Software Engineers. \r\n\n\n NOTE: This error occurs while fetching data from stocks_shipment_unit Table joined with receiving/stocks_client_matrix table in LTI facility with ERROR:'Sequence Contains no elements'. \r\n\n\nNo Data to be fetched.");
                    case "Sequence contains more than one element":
                        throw new Exception("Data Fetching Error. Please call the attention of Software Engineers. \r\n\n\n NOTE: This error occurs while fetching data from stocks_shipment_unit Table joined with receiving/stocks_client_matrix table in LTI facility with ERROR:'Sequence Contains more than one element'.\r\n\n\nMore than one same data were saved.");
                    default:
                        throw new Exception(ex.Message);
                }
            }
        }

        public string GetShipto(string imei)
        {
            try
            {
                string resultSet;
                if (_facility == "LTI")
                    resultSet = _base.ExecuteQuery<string>(Db.TrackingSystem.Queries.GetShiptoClient, new { Imei = imei }, Db.TrackingSystem.Name, ReturnType.Single);
                else
                    resultSet = string.Empty;

                return resultSet;
            }
            catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "Sequence contains no elements":
                        throw new Exception("Data Fetching Error. Please call the attention of Software Engineers. \r\n\n\n NOTE: This error occurs while fetching data from stocks_shipment_unit Table joined with receiving/stocks_client_matrix table in LTI facility with ERROR:'Sequence Contains no elements'. \r\n\n\nNo Data to be fetched.");
                    case "Sequence contains more than one element":
                        throw new Exception("Data Fetching Error. Please call the attention of Software Engineers. \r\n\n\n NOTE: This error occurs while fetching data from stocks_shipment_unit Table joined with receiving/stocks_client_matrix table in LTI facility with ERROR:'Sequence Contains more than one element'.\r\n\n\nMore than one same data were saved.");
                    default:
                        throw new Exception(ex.Message);
                }
            }
        }


        public PrintData GetPrintData<PrintData>(string imei,string client)
        {
            try
            {
                var param = new
                {
                    Imei = imei,
                    Client = client
                };

                var resultSet = _base.ExecuteQuery<PrintData>(Db.TrackingSystem.Queries.GetPrintData, param, Db.TrackingSystem.Name, ReturnType.Single);

                return resultSet;
            }catch(Exception)
            {
                throw new Exception("UNABLE_TO_GET_PRINTDATA");
            }
        }

        public bool IsPrinted(string imei)
        {
            try
            {
                bool resultSet;
                if (_facility == "LTI")
                    resultSet = _base.ExecuteQuery<bool>(Db.TrackingSystem.Queries.IsPrinted, new { Imei = imei }, Db.TrackingSystem.Name, ReturnType.Single);
                else
                    resultSet = _base.ExecuteQuery<bool>(Db.ChronosUK.Queries.IsPrinted, new {Imei = imei }, Db.ChronosUK.Name, ReturnType.Single);

                return resultSet;
            }catch(Exception)
            {
                throw new Exception("ERROR_IN_FETCHING_PRINT_TABLE");
            }
        }

        public void AddPrintLog(string imei,int Printedby, string workstation)
        {
            try
            {
                var param = new
                {
                    Imei = imei,
                    printedBy = Printedby,
                    Workstation = workstation
                };
                if (_facility == "LTI")
                    _base.ExecuteQuery(Db.TrackingSystem.Queries.AddPrintLogs, param, Db.TrackingSystem.Name);
                else
                    _base.ExecuteQuery(Db.ChronosUK.Queries.AddPrintLogs,new {Imei = imei, printedBy = Printedby },Db.ChronosUK.Name);
            }catch(Exception)
            {
                throw new Exception("ERROR_IN_ADDING_DATA_TO_PRINTLOGS");
            }
        }

       

        public bool IsOQC(string imei,string client)
        {
            try
            {
                bool resultSet;
                if (_facility == "LTI")
                    if(client == "ATT - RT" || client == "ECO - JPRM" || client == "ECO - UKRM")
                        resultSet = _base.ExecuteQuery<bool>(Db.TrackingSystem.Queries.RMAOQCChecker, new { Imei = imei }, Db.TrackingSystem.Name, ReturnType.Single);
                    else
                        resultSet = _base.ExecuteQuery<bool>(Db.TrackingSystem.Queries.OQCChecker, new { Imei = imei }, Db.TrackingSystem.Name, ReturnType.Single);
                else
                    resultSet = true;

                return resultSet;
            }catch(Exception ex)
            {
                switch (ex.Message)
                {
                    case "Sequence contains no elements":
                        throw new Exception("Data Fetching Error. Please call the attention of Software Engineers. \r\n\n\n NOTE: This error occurs while fetching data from Phone Atribute Trail Table join with parts.inventory table with ERROR:'Sequence Contains no elements'. \r\n\n\nNo Association Detected.");
                    case "Sequence contains more than one element":
                        throw new Exception("Data Fetching Error. Please call the attention of Software Engineers. \r\n\n\n NOTE: This error occurs while fetching data from Phone/Receiving Table join with parts.inventory table with ERROR:'Sequence Contains more than one element'.\r\n\n\nMore than one associations detected.");
                    default:
                        throw new Exception(ex.Message);
                }
            }
        }
        public string GetShipToClient(string imei)
        {
            try
            {
                var param = new
                {
                    Imei = imei
                };

                var resultSet = _base.ExecuteQuery<string>(Db.TrackingSystem.Queries.GetShiptoClient, param, Db.TrackingSystem.Name, ReturnType.Single);

                return resultSet;
            }catch(Exception)
            {
                throw new Exception("ERROR_IN_GETTING_SHIPTO_CLIENT_LTI");
            }
        }

        public iPhoneModel GetiPhoneModel<iPhoneModel>(string imei)
        {
            try
            {
                var param = new
                {
                    Imei = imei
                };

                var resultSet = _base.ExecuteQuery<iPhoneModel>(Db.TrackingSystem.Queries.GetiPhoneModel, param, Db.TrackingSystem.Name, ReturnType.Single);

                return resultSet;
            }catch(Exception)
            {
                throw new Exception("ERROR_IN_GETTING_PHONEMODEL");
            }
        }
    }
}
