using AutoMapper;
using FatecItuApi.Api.ViewModels;
using FatecItuApi.Business.Models;
using FatecItuApi.ViewModels;

namespace FatecItuApi.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
