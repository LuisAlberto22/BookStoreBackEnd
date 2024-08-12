using BookStore.Entities;
using BookStore.Persistences.DBContexts;
using BookStore.Repositories.BaseRepositories;
using BookStore.Repositories.Interfaces;

namespace BookStore.Repositories.Repositories
{
	public class BookRepository : BaseRepository<Book>, IBookRepository
	{
		public BookRepository(SqlDbContext context) : base(context)
		{
		}
	}
}
