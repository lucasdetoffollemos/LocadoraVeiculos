using AutoMapper;
using LocadoraVeiculos.Aplicacao.ParceiroModule;
using LocadoraVeiculos.netCore.Dominio.ParceiroModule;
using LocadoraVeiculos.WebApplication.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WebApplication.Controllers
{
    public class ParceiroController : Controller
    {

        private readonly ParceiroAppService parceiroAppService;

        private readonly IParceiroRepository parceiroRepository;

        private readonly IMapper mapper;

        public ParceiroController(ParceiroAppService parceiroAppService,
            IParceiroRepository parceiroRepository,
            IMapper mapper)
        {

            this.parceiroAppService = parceiroAppService;
            this.parceiroRepository = parceiroRepository;
            this.mapper = mapper;

        }

        // GET: ParceiroController
        public ActionResult Index()
        {

            var parceiros = parceiroRepository.SelecionarTodos();

            var parceiroIndexVm = mapper.Map<ParceiroIndexViewModel>(parceiros);

            return View(parceiroIndexVm);
        }

        // GET: ParceiroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ParceiroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParceiroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ParceiroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ParceiroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ParceiroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ParceiroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
