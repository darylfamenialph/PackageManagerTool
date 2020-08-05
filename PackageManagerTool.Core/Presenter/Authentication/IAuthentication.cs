using PackageManagerTool.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManagerTool.Core.Presenter.Authentication
{
   public interface IAuthenticationView: IView<IAuthenticationPresenter>
    {
        void AuthenticateUser(string username, string password);
    }
   public interface IAuthenticationPresenter: IPresenter<IAuthenticationView>
    {
        void AuthenticateUser(string username, string password);
        bool isCancelled();
        void isDone(bool status);


    }
}
