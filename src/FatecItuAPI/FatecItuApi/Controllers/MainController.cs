using FatecItuApi.Api.ViewModels;
using FatecItuApi.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FatecItuApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MainController : ControllerBase
    {
        //validacao de notificacoes de erro

        //validacao de model state

        //validacao da operacao de negocios
    }

    public class FornecedoresController : MainController
    {
        private readonly IProdutoRepository _produtoRepository;

        public FornecedoresController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<ActionResult<IEnumerable<ProdutoViewModel>>> ObterTodos()
        {
            var fornecedores = await _produtoRepository.ObterTodos();
            return Ok(fornecedores);
        }
    }
}
