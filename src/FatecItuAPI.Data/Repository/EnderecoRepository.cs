using System;
using System.Threading.Tasks;
using FatecItuApi.Business.Intefaces;
using FatecItuApi.Business.Models;
using FatecItuApi.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FatecItuApi.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}