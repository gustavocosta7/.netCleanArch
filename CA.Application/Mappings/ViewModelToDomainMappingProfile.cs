using AutoMapper;
using CA.Application.ViewModels;
using CA.Domain.Entities;

namespace CA.Application.Mappings
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Product>();
        }
    }
}