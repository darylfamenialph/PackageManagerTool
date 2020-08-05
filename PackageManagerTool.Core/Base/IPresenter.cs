
namespace PackageManagerTool.Core.Base
{
    public interface IPresenter<TView>
    {
        TView View { get; }

        void Run();
    }
}
