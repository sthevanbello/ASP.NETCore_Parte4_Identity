using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Controllers
{
    public class ContaController : Controller
    {
        [Authorize]
        public async Task<ActionResult> Login()
        {
            return Redirect(Url.Content("~/"));
        }

        [Authorize]
        public async Task Logout()
        {
            // Atualizar os cookies (Autenticação local)
            await HttpContext.SignOutAsync("Cookies");

            // Faz a desconexão no Identity Server (OpenIdConnect)
            await HttpContext.SignOutAsync("OpenIdConnect");

        }
    }
}
