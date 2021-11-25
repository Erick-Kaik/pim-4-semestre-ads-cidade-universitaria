using HotelariaControle.Data.Models;
using HotelariaControle.Data.Servicos;
using HotelPim.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HotelPim.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        private QuartosService oQuartoService = new QuartosService();

        private UsuarioService oUsuarioService = new UsuarioService();

        private ReservaService oReservaService = new ReservaService();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            bool Logado = Convert.ToBoolean(TempData["Logado"]);

            var ListaQuartos = (from quartos in oQuartoService.oRepositoryQuartos.SelecionarTodos()
                                select new SelectListItem()
                                {
                                    Text = ("Quarto N°:" + quartos.NumeroQuarto.ToString() + ", " + quartos.TipoQuarto),
                                    Value = quartos.IdQuarto.ToString(),
                                }).ToList();
            ListaQuartos.Insert(0, new SelectListItem()
            {
                Text = "------Selecione------",
                Value = String.Empty
            });
            ViewBag.ListaDeQuartos = ListaQuartos;
            return View();
        }

        [HttpPost]
        public IActionResult ReservarQuarto(Reservas model)
        {
            bool Ativa = Convert.ToBoolean(TempData["Ativa"]);

            if (Ativa == true)
            {
                var PegaUsuario = TempData["NomeUsuario"];

                var ListaUsuario = (from usuario in oUsuarioService.oRepositoryUsuario.SelecionarTodos()
                                    select new SelectListItem()
                                    {
                                        Text = usuario.Usuario,
                                        Value = Convert.ToInt32(usuario.IdHospede).ToString()
                                    });
                var lista = ListaUsuario.FirstOrDefault(s => s.Text == PegaUsuario.ToString());
                if (lista != null)
                {
                    model.IdHospede = Convert.ToInt32(lista.Value);
                }


                var ListaQuartos = (from quartos in oQuartoService.oRepositoryQuartos.SelecionarTodos()
                                    select new SelectListItem()
                                    {
                                        Text = ("Quarto N°:" + quartos.NumeroQuarto.ToString() + ", " + quartos.TipoQuarto),
                                        Value = quartos.IdQuarto.ToString(),
                                    }).ToList();
                ListaQuartos.Insert(0, new SelectListItem()
                {
                    Text = "------Selecione------",
                    Value = String.Empty
                });

                ViewBag.ListaDeQuartos = ListaQuartos;

                string PegaId = Request.Form["lista"];

                var QuartoID = ListaQuartos.FirstOrDefault(s => s.Value == PegaId);
                if(QuartoID != null)
                {
                    model.IdQuarto = Convert.ToInt32(QuartoID.Value);
                }

                string CheckInData = Request.Form["dataCheckIn"];
                string CheckOutData = Request.Form["dataCheckOut"];

                model.RStatus = Convert.ToBoolean(1);
                TempData["NomeUsuario"] = PegaUsuario;
                TempData["ativa"] = Ativa;
                model.CheckIn = Convert.ToDateTime(CheckInData);
                model.CheckOut = Convert.ToDateTime(CheckOutData);

                oReservaService.oRepositoryReserva.Incluir(model);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Hospede", "Hospede");
        }

        public IActionResult Sobre()
        {
            var ListaQuartos = (from quartos in oQuartoService.oRepositoryQuartos.SelecionarTodos()
                                select new SelectListItem()
                                {
                                    Text = "Quarto N°:" + quartos.NumeroQuarto.ToString() + ", " + quartos.TipoQuarto,
                                    Value = quartos.IdQuarto.ToString()
                                }).ToList();
            ListaQuartos.Insert(0, new SelectListItem()
            {
                Text = "----Selecione----",
                Value = String.Empty
            });
            ViewBag.ListaDeQuartos = ListaQuartos;

            return View();
        }
        public IActionResult Reserva()
        {
            var ListaQuartos = (from quartos in oQuartoService.oRepositoryQuartos.SelecionarTodos()
                                select new SelectListItem()
                                {
                                    Text = "Quarto N°:" + quartos.NumeroQuarto.ToString() + ", " + quartos.TipoQuarto,
                                    Value = quartos.IdQuarto.ToString()
                                }).ToList();
            ListaQuartos.Insert(0, new SelectListItem()
            {
                Text = "----Selecione----",
                Value = String.Empty
            });
            ViewBag.ListaDeQuartos = ListaQuartos;

            var ListaTipoQuartos = (from quartos in oQuartoService.oRepositoryQuartos.SelecionarTodos()
                                select new SelectListItem()
                                {
                                    Text = quartos.TipoQuarto,
                                    Value = quartos.IdQuarto.ToString(),
                                }).ToList();
            ListaTipoQuartos.Insert(0, new SelectListItem()
            {
                Text = "------Selecione------",
                Value = String.Empty
            });
            ViewBag.ListaTipoDeQuartos = ListaTipoQuartos;


            return View();
        }
        public IActionResult QuartoSolteiro()
        {
            var ListaQuartos = (from quartos in oQuartoService.oRepositoryQuartos.SelecionarTodos()
                                select new SelectListItem()
                                {
                                    Text = "Quarto N°:" + quartos.NumeroQuarto.ToString() + ", " + quartos.TipoQuarto,
                                    Value = quartos.IdQuarto.ToString()
                                }).ToList();
            ListaQuartos.Insert(0, new SelectListItem()
            {
                Text = "----Selecione----",
                Value = String.Empty
            });
            ViewBag.ListaDeQuartos = ListaQuartos;
            return View();
        }

        public IActionResult QuartoDuploSolteiro()
        {
            var ListaQuartos = (from quartos in oQuartoService.oRepositoryQuartos.SelecionarTodos()
                                select new SelectListItem()
                                {
                                    Text = "Quarto N°:" + quartos.NumeroQuarto.ToString() + ", " + quartos.TipoQuarto,
                                    Value = quartos.IdQuarto.ToString()
                                }).ToList();
            ListaQuartos.Insert(0, new SelectListItem()
            {
                Text = "----Selecione----",
                Value = String.Empty
            });
            ViewBag.ListaDeQuartos = ListaQuartos;
            return View();
        }

        public IActionResult QuartoCasal()
        {
            var ListaQuartos = (from quartos in oQuartoService.oRepositoryQuartos.SelecionarTodos()
                                select new SelectListItem()
                                {
                                    Text = "Quarto N°:" + quartos.NumeroQuarto.ToString() + ", " + quartos.TipoQuarto,
                                    Value = quartos.IdQuarto.ToString()
                                }).ToList();
            ListaQuartos.Insert(0, new SelectListItem()
            {
                Text = "----Selecione----",
                Value = String.Empty
            });
            ViewBag.ListaDeQuartos = ListaQuartos;
            return View();
        }

        public IActionResult Dormitorio()
        {
            var ListaQuartos = (from quartos in oQuartoService.oRepositoryQuartos.SelecionarTodos()
                                select new SelectListItem()
                                {
                                    Text = "Quarto N°:" + quartos.NumeroQuarto.ToString() + ", " + quartos.TipoQuarto,
                                    Value = quartos.IdQuarto.ToString()
                                }).ToList();
            ListaQuartos.Insert(0, new SelectListItem()
            {
                Text = "----Selecione----",
                Value = String.Empty
            });
            ViewBag.ListaDeQuartos = ListaQuartos; 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
