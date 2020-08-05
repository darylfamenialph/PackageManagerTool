using PackageManagerTool.Core.Presenter.Dashboard;
using System;
using System.Windows.Forms;
using PackageManagerTool.Core.Model.TrackingSystem;
using PackageManagerTool.Core.Utilities;
using PackageManagerTool.Core.Model.ChronosUK;

namespace PackageManagerTool
{
    public partial class VwDashboard : Form, IDashboardView
    {

        #region BackingFields
        IDashboardPresenter _presenter;
        #endregion
        #region Private Variables
        private bool isAuthenticated;
        private bool _successPrinting;
        #endregion
        #region Public Properties
        public IDashboardPresenter Presenter
        {
            get
            {
                return _presenter;
            }
            set
            {
                Helper.SetValue(ref _presenter, ref value, true);
            }
        }
        #endregion
        

        public VwDashboard()
        {
            InitializeComponent();
            tBoxIMEI.Focus();
            Extensions.DraggableControl(this);
        }

        private void pBoxBtnClose_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void tBoxIMEI_TextChanged(object sender, EventArgs e)
        {
            pBoxMainUI.Visible = false;
            lblBarcode.Visible = true;
            this.BackgroundImage = PackageManagerTool.Properties.Resources.full_bg_green;
            lblBarcode.Text = tBoxIMEI.Text.Trim();

            ClearControls();


        }

        private void tBoxIMEI_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    {
                        string deviceIMEI = tBoxIMEI.Text.Trim();

                        _presenter.DisplayIMEIDetails(deviceIMEI);

                        pBoxBtnPrint.Visible = true;
                        lblBtnPrint.Visible = true;
                    }
                    break;
                case Keys.Back: case Keys.Delete:
                    {
                        tBoxIMEI.Clear();
                        ClearControls();
                    }
                    break;
                
                case Keys.Space:
                    {
                        if (e.Modifiers == Keys.Alt)
                        {
                            pBoxBtnPrint_Click(this, EventArgs.Empty);
                            

                        }
                       

                    }
                    break;
                case Keys.F10:
                    {
                        pboxbtnPackagingInstruction_Click(this,EventArgs.Empty);
                    }break;
            }


        }

        public void ClearControls()
        {
            if (tBoxIMEI.Text.Trim() == string.Empty)
            {
                lblBarcode.Text = string.Empty;
                lblBarcode.Visible = true;
                pBoxMainUI.Visible = true;
                this.BackgroundImage = PackageManagerTool.Properties.Resources.bg_green;

                lblPhoneModel.Text = string.Empty;
                lblSerialNum.Text = string.Empty;
                lblPartNo.Text = string.Empty;
                lblPhoneColor.Text = string.Empty;
                lblPhoneSize.Text = string.Empty;
                lblLcmType.Text = string.Empty;
                lblPackagingType.Text = string.Empty;
                lblClient.Text = string.Empty;
                lblShipTo.Text = string.Empty;

                pBoxiPhoneView.Image = null;
                pBoxHeadPhoneCards.Image = null;
                pBoxChargerCards.Image = null;
                pBoxCableCards.Image = null;

                pBoxBtnPrint.Visible = false;
                lblBtnPrint.Visible = false;
                lblBooklet.Visible = false;
                pboxbtnPackagingInstruction.Visible = false;
            }

            
        }

        public void DisplayIMEIDetails(Receiving DataSource, string LCMType,string PackagingType, string ShiptoClient)
        {

            lblSerialNum.Text = DataSource.SerialNo;
            lblPartNo.Text = DataSource.PartNo;
            lblLcmType.Text = LCMType;

            pBoxiPhoneView.Image = PackageManagerTool.Properties.Resources.IP7SVR;
            pBoxHeadPhoneCards.Image = PackageManagerTool.Properties.Resources.HeadphoneCards;
            
            pBoxCableCards.Image = PackageManagerTool.Properties.Resources.CableCards;

            lblPhoneModel.Text = DataSource.Model;
            lblPhoneColor.Text = DataSource.Color;
            lblPhoneSize.Text = $"{DataSource.Size}GB";
            lblPackagingType.Text = PackagingType;
            lblClient.Text = DataSource.Client;
            lblBooklet.Visible = true;
            lblShipTo.Text = ShiptoClient;
            pboxbtnPackagingInstruction.Visible = true;

            // pBoxiPhoneView.ImageLocation = "ftp://chronosltisvr:26/model_images_new/" + DataSource.Model + " " + DataSource.Color + ".png";
            pBoxiPhoneView.Image = GetImage(DataSource.Model + " " + DataSource.Color);


            if (PackagingType == "Box w/ Accessories (JP ver) - No Adapter")
            {
                pBoxChargerCards.Image = PackageManagerTool.Properties.Resources.no_adapter;
                pBoxHeadPhoneCards.Image = PackageManagerTool.Properties.Resources.HeadphoneCards;
            }
            else if (PackagingType == "Box w/ Accessories (AU ver) - Complete")
            {
                pBoxChargerCards.Image = PackageManagerTool.Properties.Resources.adapter_australia;
                pBoxHeadPhoneCards.Image = PackageManagerTool.Properties.Resources.HeadphoneCards;
            }
            else if (PackagingType == "Box w/ Accessories (JP ver) - Complete")
            {
                pBoxChargerCards.Image = PackageManagerTool.Properties.Resources.adapter_japan;
                pBoxHeadPhoneCards.Image = PackageManagerTool.Properties.Resources.HeadphoneCards;
            }
            else if (PackagingType == "Box w/ Accessories (UK ver) - No heaphone")
            {
                pBoxChargerCards.Image = PackageManagerTool.Properties.Resources.ChargerCards;
                pBoxHeadPhoneCards.Image = PackageManagerTool.Properties.Resources.NO_HeadphoneCards;
            }
            else
            {
                pBoxChargerCards.Image = PackageManagerTool.Properties.Resources.ChargerCards;
                pBoxHeadPhoneCards.Image = PackageManagerTool.Properties.Resources.HeadphoneCards;
            }

           
            
        }

        private System.Drawing.Image GetImage(string PhoneModel)
        {
            switch(PhoneModel)
            {
                case "iPhone 6 Silver":
                    return PackageManagerTool.Properties.Resources.iPhone_6_Silver;
                case "iPhone 6 Gold":
                    return PackageManagerTool.Properties.Resources.iPhone_6_Gold;
                case "iPhone 6 Space Gray":
                    return PackageManagerTool.Properties.Resources.iPhone_6_Space_Gray;
                case "iPhone 6 Plus Silver":
                    return PackageManagerTool.Properties.Resources.iPhone_6_Plus_Silver;
                case "iPhone 6 Plus Gold":
                    return PackageManagerTool.Properties.Resources.iPhone_6_Plus_Gold;
                case "iPhone 6 Plus Space Gray":
                    return PackageManagerTool.Properties.Resources.iPhone_6_Plus_Space_Gray;
                case "iPhone 6s Silver":
                    return PackageManagerTool.Properties.Resources.iPhone_6s_Silver;
                case "iPhone 6s Gold":
                    return PackageManagerTool.Properties.Resources.iPhone_6s_Gold;
                case "iPhone 6s Rose Gold":
                    return PackageManagerTool.Properties.Resources.iPhone_6s_Rose_Gold;
                case "iPhone 6s Space Gray":
                    return PackageManagerTool.Properties.Resources.iPhone_6s_Space_Gray;
                case "iPhone 6s Plus Silver":
                    return PackageManagerTool.Properties.Resources.iPhone_6s_Plus_Silver;
                case "iPhone 6s Plus Gold":
                    return PackageManagerTool.Properties.Resources.iPhone_6s_Plus_Gold;
                case "iPhone 6s Plus Rose Gold":
                    return PackageManagerTool.Properties.Resources.iPhone_6s_Plus_Rose_Gold;
                case "iPhone 6s Plus Space Gray":
                    return PackageManagerTool.Properties.Resources.iPhone_6s_Plus_Space_Gray;
                case "iPhone 7 Silver":
                    return PackageManagerTool.Properties.Resources.iPhone_7_Silver;
                case "iPhone 7 Gold":
                    return PackageManagerTool.Properties.Resources.iPhone_7_Gold;
                case "iPhone 7 Rose Gold":
                    return PackageManagerTool.Properties.Resources.iPhone_6_Gold;
                case "iPhone 7 Matte Black":
                    return PackageManagerTool.Properties.Resources.iPhone_7_Matte_Black;
                case "iPhone 7 Jet Black":
                    return PackageManagerTool.Properties.Resources.iPhone_7_Jet_Black;
                case "iPhone 7 Product Red":
                    return PackageManagerTool.Properties.Resources.iPhone_7_Product_Red;
                case "iPhone 7 Plus Silver":
                    return PackageManagerTool.Properties.Resources.iPhone_7_Plus_Silver;
                case "iPhone 7 Plus Gold":
                    return PackageManagerTool.Properties.Resources.iPhone_7_Plus_Gold;
                case "iPhone 7 Plus Rose Gold":
                    return PackageManagerTool.Properties.Resources.iPhone_7_Rose_Gold;
                case "iPhone 7 Plus Matte Black":
                    return PackageManagerTool.Properties.Resources.iPhone_7_Plus_Matte_Black;
                case "iPhone 7 Plus Jet Black":
                    return PackageManagerTool.Properties.Resources.iPhone_7_Plus_Jet_Black;
                case "iPhone 7 Plus Product Red":
                    return PackageManagerTool.Properties.Resources.iPhone_7_Plus_Product_Red;
                case "iPhone 8 Silver":
                    return PackageManagerTool.Properties.Resources.iPhone_8_Silver;
                case "iPhone 8 Gold":
                    return PackageManagerTool.Properties.Resources.iPhone_8_Gold;
                case "iPhone 8 Space Gray":
                    return PackageManagerTool.Properties.Resources.iPhone_8_Space_Gray;
                case "iPhone 8 Product Red":
                    return PackageManagerTool.Properties.Resources.iPhone_8_Product_Red;
                case "iPhone 8 Plus Silver":
                    return PackageManagerTool.Properties.Resources.iPhone_8_Plus_Silver;
                case "iPhone 8 Plus Gold":
                    return PackageManagerTool.Properties.Resources.iPhone_8_Plus_Gold;
                case "iPhone 8 Plus Space Gray":
                    return PackageManagerTool.Properties.Resources.iPhone_8_Plus_Space_Gray;
                case "iPhone 8 Plus Product Red":
                    return PackageManagerTool.Properties.Resources.iPhone_8_Plus_Product_Red;
                case "iPhone X Silver":
                    return PackageManagerTool.Properties.Resources.iPhone_X_Silver;
                case "iPhone X Space Gray":
                    return PackageManagerTool.Properties.Resources.iPhone_X_Space_Gray;
                default:
                    return PackageManagerTool.Properties.Resources.iPhone_5_Silver;
            }
            
        }

        #region Interface Contracts
        public void Run()
        {
          //Application.Run(this);
            ShowDialog();
        }

        public void Stop()
        {
            Close();
        }

        public void Suspend()
        {
            Hide();
        }

        public void Resume()
        {
            Show();
        }

        public void ShowMessage(string caption, string message, bool isErrorMessage)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, isErrorMessage ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }

        public bool PromptMessage(string caption, string message, bool isErrorMessage)
        {
            var dialogResult = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, isErrorMessage ? MessageBoxIcon.Error : MessageBoxIcon.Question);

            return (dialogResult == DialogResult.Yes); 
        }
        #endregion


        private void VwDashboard_Load(object sender, EventArgs e)
        {
            ClearControls();
        }

        public void PrintBarcodeLabel(string DeviceImei, string PartNo, string PhoneModel,string PrintType,string LCMType)
        {
            try
            {
                _presenter.PrintBarcodeLabel(DeviceImei, PartNo, PhoneModel, PrintType, LCMType);
                _successPrinting = true;

            }
            catch(Exception ex)
            {
                ShowMessage("Warning",$"Error in Printer: {ex.Message}",true);
                _successPrinting = false;
            }
        }

        private void pBoxBtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isPrinted(lblBarcode.Text.Trim(), "Checking", "This Imei is already printed, do you want to reprint this?", false))
                {
                    if (lblPartNo.Text.Trim() == string.Empty || lblPartNo.Text.Trim() == "NONE")
                        throw new Exception("Part No must have a value. Cannot PrintData withtout Part No.");
                    else
                    {
                        var lcmtype = string.Empty;

                        if (lblLcmType.Text.Trim() == "OQC")
                            lcmtype = "B";
                        else
                            lcmtype = "A";
                        if (lblClient.Text.Trim() == "ECO - UK" || lblClient.Text.Trim() == "ECO - UKRM" || lblClient.Text.Trim() == "ECOUK - PO")
                        {
                            if (lblShipTo.Text.Trim() == "AMAZON")
                            {
                                PrintBarcodeLabel(lblBarcode.Text.Trim(), lblPartNo.Text.Trim(), lblPhoneModel.Text.Trim() + " " + lblPhoneColor.Text.Trim() + " " + lblPhoneSize.Text.Trim(), "Amazon", lcmtype);
                            }
                            else {
                                PrintBarcodeLabel(lblBarcode.Text.Trim(), lblPartNo.Text.Trim(), lblPhoneModel.Text.Trim() + " " + lblPhoneColor.Text.Trim() + " " + lblPhoneSize.Text.Trim(), "LabelwithLCMType", lcmtype);
                                PrintBarcodeLabel(lblBarcode.Text.Trim(), lblPartNo.Text.Trim(), lblPhoneModel.Text.Trim() + " " + lblPhoneColor.Text.Trim() + " " + lblPhoneSize.Text.Trim(), "ImeiLabel", lcmtype);
                            }
                        }
                        else if (lblClient.Text.Trim() == "CHRONOS-UK")
                        {
                            PrintBarcodeLabel(lblBarcode.Text.Trim(), lblPartNo.Text.Trim(), lblPhoneModel.Text.Trim()  + " " + lblPhoneColor.Text.Trim() + " " + lblPhoneSize.Text.Trim(), "DEFAULT", lcmtype);
                            PrintBarcodeLabel(lblBarcode.Text.Trim(), lblPartNo.Text.Trim(), lblPhoneModel.Text.Trim()  + " " + lblPhoneColor.Text.Trim() + " " + lblPhoneSize.Text.Trim(), "ImeiLabel", lcmtype);
                          
                        }
                        else
                        {
                            if (lblShipTo.Text.Trim() == "AMAZON")
                            {
                                PrintBarcodeLabel(lblBarcode.Text.Trim(), lblPartNo.Text.Trim(), lblPhoneModel.Text.Trim() + " " + lblPhoneColor.Text.Trim() + " " + lblPhoneSize.Text.Trim(), "Amazon", lcmtype);
                            }
                            else if (lblShipTo.Text.Trim() == "MZM - UK")
                            {
                                PrintBarcodeLabel(lblBarcode.Text.Trim(), lblPartNo.Text.Trim(), lblPhoneModel.Text.Trim() + " " + lblPhoneColor.Text.Trim() + " " + lblPhoneSize.Text.Trim(), "DEFAULT", lcmtype);
                                PrintBarcodeLabel(lblBarcode.Text.Trim(), lblPartNo.Text.Trim(), lblPhoneModel.Text.Trim() + " " + lblPhoneColor.Text.Trim() + " " + lblPhoneSize.Text.Trim(), "DEFAULT", lcmtype);
                            }
                            else
                            {

                                PrintBarcodeLabel(lblBarcode.Text.Trim(), lblPartNo.Text.Trim(), lblPhoneModel.Text.Trim() + " " + lblPhoneColor.Text.Trim() + " " + lblPhoneSize.Text.Trim(), "DEFAULT", lcmtype);
                            }
                        }
                        if (ForReprint())
                            AddPrintLogs(lblBarcode.Text.Trim(), Environment.MachineName);
                        if (_successPrinting == true)
                        {
                            ShowMessage("Info", "Printing Success", false);
                        }
                        else
                        {
                            ShowMessage("Warning", "Printing not Successfull", true);
                        }
                        tBoxIMEI.Text = string.Empty;
                        ClearControls();
                    }
                }
            }catch(Exception ex)
            {
               ShowMessage("Warning", ex.Message, true);
            }
        }

        private void pboxbtnPackagingInstruction_Click(object sender, EventArgs e)
        {  
            //ShowMessage("Warning","This method is not yet implemented.",false);
            Suspend();
            _presenter.ShowPackagingInstruction(lblPackagingType.Text.Trim());
            Resume();
        }

        public void AddPrintLogs(string DeviceImei, string workstation)
        {
            _presenter.AddPrintLogs(DeviceImei, workstation);
        }

        public bool isPrinted(string DeviceImei, string caption, string message, bool isErrorMessage)
        {
           return _presenter.isPrinted(DeviceImei, caption, message, isErrorMessage);
        }

        public bool ForReprint()
        {
            return _presenter.ForReprint();
        }

        public void AuthenticateUser(string username, string password, string Imei)
        {
            _presenter.AuthenticateUser(username,password,Imei);
        }

        private void lblClient_Click(object sender, EventArgs e)
        {

        }

        // public string UserType()
        // {
        //return _presenter.UserType();

        // }
    }
    public static class Extensions
    {
        public static void DraggableControl(params Control[] ctrlList)
        {
            var dragControl = new ns1.BunifuDragControl();

            foreach (Control ctrl in ctrlList)
            {
                ctrl.MouseDown += (sender, e) => dragControl.Grab(ctrl.FindForm());
                ctrl.MouseMove += (sender, e) => dragControl.Drag();
                ctrl.MouseUp += (sender, e) => dragControl.Release();
            }
        }
    }
}
