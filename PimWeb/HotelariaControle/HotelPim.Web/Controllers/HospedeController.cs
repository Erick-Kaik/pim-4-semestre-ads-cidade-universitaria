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
    public class HospedeController : Controller
    {
        private HospedeService oHospedeService = new HospedeService();

        public IActionResult Hospede()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Hospede(Hospedes model)
        {
            if (ModelState.IsValid)
            {
                string dataNascimento = Request.Form["nascimento"];

                model.DataDeNascimento = Convert.ToDateTime(dataNascimento);

                model.HStatus = Convert.ToBoolean(1);

                string NomeHospede = Request.Form["nome"];

                TempData["NomeHospede"] = NomeHospede;

                oHospedeService.oRepositoryHospede.Incluir(model);

                return RedirectToAction("Create", "Usuario");
            }

            return View();


        }
    }
}
