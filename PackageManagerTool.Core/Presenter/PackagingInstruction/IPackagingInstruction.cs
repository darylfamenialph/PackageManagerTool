using PackageManagerTool.Core.Base;
namespace PackageManagerTool.Core.Presenter.PackagingInstruction
{
    public interface IPackagingInstructionView: IView<IPackagingInstructionPresenter>
    {
         void setPackagingType(string PackagingType);
    }
    public interface IPackagingInstructionPresenter: IPresenter<IPackagingInstructionView>
    {
        void setPackagingType();
    }
}
