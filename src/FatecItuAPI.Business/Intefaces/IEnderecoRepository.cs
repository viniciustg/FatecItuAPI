using System;
using System.Threading.Tasks;
using FatecItuApi.Business.Models;

namespace FatecItuApi.Business.Intefaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}