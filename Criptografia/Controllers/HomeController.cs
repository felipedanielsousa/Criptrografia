using Criptografia.Models;
using System.Web.Mvc;

namespace Criptografia.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            CriptografiaCifra criptografia = new CriptografiaCifra();
            return View(criptografia);
        }

        [HttpPost]
        public ActionResult OpcaoCriptografia(CriptografiaCifra criptografia)
        {
            if (criptografia.CripDescrip)
            {
                criptografia.TextoFinal = Criptografar.Crip(criptografia.Texto, criptografia.Chave);
            }
            else
            {
                criptografia.TextoFinal = Descriptografar.Descrip(criptografia.Texto, criptografia.Chave);
            }

            return View("Index", criptografia);

        }
    }
}