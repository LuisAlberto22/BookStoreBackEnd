using AutoMapper;
using BookStore.Dtos.Requests.Customers;
using BookStore.Entities;

namespace BookStore.Mappers.Profiles
{
	public class CustomerMapper : Profile
	{

		public CustomerMapper()
		{
			CreateMap<StoreCustomerRequest, Customer>();
			CreateMap<UpdateCustomerRequest, Customer>();
		}
	}
}
