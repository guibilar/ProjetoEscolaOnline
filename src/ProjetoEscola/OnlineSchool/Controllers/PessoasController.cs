using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineSchool.App.ViewModels;
using OnlineSchool.Busness.Interfaces;
using OnlineSchool.Busness.Models;

namespace OnlineSchool.App.Controllers
{
    [AllowAnonymous]
    public class PessoasController : BaseController
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IMapper _mapper;

        public PessoasController(IPessoaRepository pessoaRepository,
                                      IMapper mapper,
                                      INotificador notificador) : base(notificador)
        {
            _pessoaRepository = pessoaRepository;
            _mapper = mapper;
        }

        [Route("lista-de-pessoas")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<PessoaViewModel>>(await _pessoaRepository.ObterTodos()));
        }

        [Route("dados-da-pessoa/{id:guid}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var pessoaViewModel = await ObterPessoaCursos(id);

            if (pessoaViewModel == null)
            {
                return NotFound();
            }

            return View(pessoaViewModel);
        }

        [Route("nova-pessoa")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("nova-pessoa")]
        public async Task<IActionResult> Create(PessoaViewModel pessoaViewModel)
        {
            if (!ModelState.IsValid) return View(pessoaViewModel);

            var pessoa = _mapper.Map<Pessoa>(pessoaViewModel);
            await _pessoaRepository.Adicionar(pessoa);

            if (!OperacaoValida()) return View(pessoaViewModel);

            return RedirectToAction("Index");
        }

        [Route("editar-pessoa/{id:guid}")]
        public async Task<IActionResult> Edit(Guid id)
        {
            var pessoaViewModel = await ObterPessoaCursos(id);

            if (pessoaViewModel == null)
            {
                return NotFound();
            }

            return View(pessoaViewModel);
        }

        [Route("editar-pessoa/{id:guid}")]
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, PessoaViewModel pessoaViewModel)
        {
            if (id != pessoaViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(pessoaViewModel);

            var pessoa = _mapper.Map<Pessoa>(pessoaViewModel);
            await _pessoaRepository.Atualizar(pessoa);

            if (!OperacaoValida()) return View(await ObterPessoaCursos(id));

            return RedirectToAction("Index");
        }

        [Route("excluir-pessoa/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var pessoaViewModel = await ObterPessoaCursos(id);

            if (pessoaViewModel == null)
            {
                return NotFound();
            }

            return View(pessoaViewModel);
        }

        [Route("excluir-pessoa/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var pessoa = await ObterPessoaCursos(id);

            if (pessoa == null) return NotFound();

            await _pessoaRepository.Remover(id);

            if (!OperacaoValida()) return View(pessoa);

            return RedirectToAction("Index");
        }

        private async Task<PessoaViewModel> ObterPessoaCursos(Guid id)
        {
            return _mapper.Map<PessoaViewModel>(await _pessoaRepository.ObterPessoaCursos(id));
        }
    }
}
