using PackageManagerTool.Core.Presenter.Authentication;
using PackageManagerTool.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackageManagerTool
{
    public partial class VwAuthentication : Form,IAuthenticationView
    {

        #region BackingField
        IAuthenticationPresenter _presenter;
        #endregion
        public VwAuthentication()
        {
            InitializeComponent();
        }

        public IAuthenticationPresenter Presenter
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

        public void AuthenticateUser(string username, string password)
        {
            _presenter.AuthenticateUser(username, password);
                
               
        }


        #region Interface Contracts

        public bool PromptMessage(string caption, string message, bool isErrorMessage)
        {
            var dialogResult = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, isErrorMessage ? MessageBoxIcon.Error : MessageBoxIcon.Question);

            return (dialogResult == DialogResult.Yes);
        }

        public void Resume()
        {
            Show();
        }

        public void Run()
        {
            ShowDialog();
        }

        public void ShowMessage(string caption, string message, bool isErrorMessage)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, isErrorMessage ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }

        public void Stop()
        {
            Close();
        }

        public void Suspend()
        {
            Hide();
        }
        #endregion

     

        private void lblbtnClose_Click(object sender, EventArgs e)
        {
            _presenter.isDone(true);
            Stop();
        }

        private void pboxbtnAuthenticate_Click(object sender, EventArgs e)
        {
            AuthenticateUser(tboxUsername.Text.Trim(), tboxPassword.Text.Trim());
        }

        private void tboxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    {
                        pboxbtnAuthenticate_Click(sender,e);
                    }
                    break;
                case Keys.Back: case Keys.Delete:
                    {
                        tboxPassword.Clear();
                    }break;
               
            }
        }
    }
}
