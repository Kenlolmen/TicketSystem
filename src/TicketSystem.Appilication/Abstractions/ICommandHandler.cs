namespace TicketSystem.src.TicketSystem.Appilication.Abstractions
{
    public interface ICommandHandler<in TCommand> where TCommand : class, ICommand
    {
        Task HandleAsync(TCommand command);
    }
}