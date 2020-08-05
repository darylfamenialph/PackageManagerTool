using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManagerTool.Core.Presenter.PackagingInstruction
{
    public class PackagingInstructionPresenter : IPackagingInstructionPresenter
    {
        #region Backing Fields
        IPackagingInstructionView _view;
        #endregion
        #region Private Variables
        IApplicationController _appController;
        string _packagingType;

        #endregion
        #region Public Properties
        public IPackagingInstructionView View => _view;
        #endregion

        public PackagingInstructionPresenter(IPackagingInstructionView view, IApplicationController appController,string packaging_type)
        {
            _view = view;
            _view.Presenter = this;

            _appController = appController;
            _packagingType = packaging_type;


        }


        

        public void Run()
        {
            _view.Run();
        }

        public void setPackagingType()
        {
            _view.setPackagingType(_packagingType);
        }
    }
}
