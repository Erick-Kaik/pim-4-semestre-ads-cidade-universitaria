using HotelariaControle.Data.Models;
using HotelariaControle.Data.Servicos;
using HotelPim.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelPim.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioService oUsuarioService = new UsuarioService();
        private HospedeService oHospedeService = new HospedeService();

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuarios model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }

            string ConfirmarUsuario = Request.Form["username"];
            string ConfirmaSenha = Request.Form["senha"];
            bool Ativa = false;
            bool Logado = false;

            var ListaUsuario = (from usuario in oUsuarioService.oRepositoryUsuario.SelecionarTodos()
                                select new SelectListItem()
                                {
                                    Text = usuario.Usuario,
                                    Value = usuario.Senha
                                });

            var lista = ListaUsuario.FirstOrDefault(s => s.Text == ConfirmarUsuario && s.Value == ConfirmaSenha);
            if (lista != null)
            {
                Ativa = true;
                Logado = true;
                model.Usuario = ConfirmarUsuario;
                TempData["NomeUsuario"] = ConfirmarUsuario;
                TempData["Ativa"] = Ativa;
                TempData["Logado"] = Logado;
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Usuarios model)
        {
            string ConfirmarSenha = Request.Form["confirmarsenha"];
            string PegaHospede = TempData["NomeHospede"].ToString();

            if (model.Senha == ConfirmarSenha)
            {
                var HospedeId = (from hospede in oHospedeService.oRepositoryHospede.SelecionarTodos()
                                 select new SelectListItem()
                                 {
                                     Text = hospede.Nome,
                                     Value = hospede.IdHospede.ToString()
                                 }).ToList();
                var lista = HospedeId.FirstOrDefault(s => s.Text == PegaHospede);
                if(lista != null)
                {
                    model.IdHospede = Convert.ToInt32(lista.Value);
                }

                if (ModelState.IsValid)
                {
                    return View();
                }

                model.Tipo = "Hospede";
                model.UStatus = Convert.ToBoolean(1);
                oUsuarioService.oRepositoryUsuario.Incluir(model);
                return RedirectToAction("Login", "Usuario");
            }
            return View();
        }
    }
}
