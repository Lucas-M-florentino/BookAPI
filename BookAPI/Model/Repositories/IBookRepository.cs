namespace BookAPI.Model.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();

        Task<Book> Get(int Id);
        Task<Book> Create(Book book);
        Task<Book> Update(Book book);
        Task<Book> Delete(int id);
    }
}
