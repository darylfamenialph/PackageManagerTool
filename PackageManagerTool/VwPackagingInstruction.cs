using PackageManagerTool.Core.Presenter.PackagingInstruction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PackageManagerTool.Core.Base;
using static PackageManagerTool.Core.Utilities.Helper;

namespace PackageManagerTool
{
    public partial class VwPackagingInstruction : Form, IPackagingInstructionView
    {
        #region Backing Fields
        IPackagingInstructionPresenter _presenter;
        #endregion
        #region Private Variables
        // Variables...
        #endregion
        #region Public Properties
        public IPackagingInstructionPresenter Presenter
        {
            get
            {
                return _presenter;
            }
            set
            {
                SetValue(ref _presenter, ref value, true);
            }
        }

        

        #endregion

        public VwPackagingInstruction()
        {
            InitializeComponent();
            
        }

        public void Run()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            Stop();
        }

        public void setPackagingType(string PackagingType)
        {
            if (PackagingType == "Box w/ Accessories (JP ver) - No Adapter")
                this.BackgroundImage = PackageManagerTool.Properties.Resources.BoxwithAccesories_NOAdapter;
            else if (PackagingType == "Box w/ Accessories (AU ver) - Complete")
                this.BackgroundImage = PackageManagerTool.Properties.Resources.BoxwithAccessories_AU;
            else if (PackagingType == "Box w/ Accessories (JP ver) - Complete")
                this.BackgroundImage = PackageManagerTool.Properties.Resources.BoxwithAccessories_JPN;
            else
                this.BackgroundImage = PackageManagerTool.Properties.Resources.BoxwithAccessories_UK;

        }

        private void VwPackagingInstruction_Load(object sender, EventArgs e)
        {
            _presenter.setPackagingType();
        }
    }
}
