using BookStore.Entities;
using BookStore.Persistences;
using BookStore.Repositories.Interfaces;

namespace BookStore.Repositories
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
	{
		public BookRepository(SQlDBContext context) : base(context)
		{
		}
	}
}
