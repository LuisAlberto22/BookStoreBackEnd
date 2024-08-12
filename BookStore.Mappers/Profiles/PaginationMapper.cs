using AutoMapper;
using BookStore.Dtos.Requests;
using BookStore.Pagination.Configurations;

namespace BookStore.Mappers.Profiles
{
	public class PaginationMapper : Profile
	{
		public PaginationMapper() 
		{
			CreateMap<PaginationRequest,PaginationConfiguration>();
		}
	}
}
