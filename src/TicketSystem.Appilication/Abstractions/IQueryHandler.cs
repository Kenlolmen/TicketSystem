namespace TicketSystem.src.TicketSystem.Appilication.Abstractions
{
    public interface IQueryHandler<in TQuery, TResult> where TQuery : class, IQuery<TResult>
    {
        
    }
}