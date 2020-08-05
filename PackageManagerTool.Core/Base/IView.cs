
namespace PackageManagerTool.Core.Base
{
   public interface IView<TPresenter>
    {
        TPresenter Presenter { get; set; }

        void Run();
        void Stop();
        void Suspend();
        void Resume();


        void ShowMessage(string caption, string message, bool isErrorMessage);
        bool PromptMessage(string caption,string message, bool isErrorMessage);
       

    }
}
