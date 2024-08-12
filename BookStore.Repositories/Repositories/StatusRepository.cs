using BookStore.Entities;
using BookStore.Persistences.DBContexts;
using BookStore.Repositories.BaseRepositories;
using BookStore.Repositories.Interfaces;

namespace BookStore.Repositories.Repositories
{
	public class StatusRepository : BaseRepository<Status>, IStatusRepository
	{
		public StatusRepository(SqlDbContext context) : base(context)
		{
		}
	}
}
