using AutoMapper;
using FatecItuApi.Api.ViewModels;
using FatecItuApi.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FatecItuApi.Controllers
{
    public class FornecedoresController : MainController
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public FornecedoresController(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
                
        }

        public async Task<ActionResult<IEnumerable<ProdutoViewModel>>> ObterTodos()
        {
            var fornecedores = _mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterTodos());
            return Ok(fornecedores);
        }
    }
}
