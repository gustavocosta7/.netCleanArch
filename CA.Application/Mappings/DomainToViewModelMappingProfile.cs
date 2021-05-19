using AutoMapper;
using CA.Application.ViewModels;
using CA.Domain.Entities;

namespace CA.Application.Mappings
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}