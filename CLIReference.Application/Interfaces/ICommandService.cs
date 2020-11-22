using CLIReference.Application.ViewModels;

namespace CLIReference.Application.Interfaces
{
    public interface ICommandService
    {
        CommandViewModel GetCommands();
    }
}
