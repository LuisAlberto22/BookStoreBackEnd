using BookStore.Entities;
using BookStore.Persistences;
using BookStore.Repositories.Interfaces;

namespace BookStore.Repositories
{
    public class StatusRepository : RepositoryBase<Status>, IStatusRepository
	{
		public StatusRepository(SQlDBContext context) : base(context)
		{
		}
	}
}
