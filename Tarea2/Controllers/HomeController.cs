using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Tarea2.Models;

namespace Tarea2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string MonedaDestino, int Cantidad)
        {
            decimal TasadeCambio = 18;
            decimal Resultado = 0;
            if (MonedaDestino == "USD")
            {
                Resultado = Cantidad / TasadeCambio;
            }
            else
            {
                Resultado = Cantidad * TasadeCambio;
            }

            //if (model.MonedaDestino == "MXN")
            //{
            //    model.Resultado = model.Cantidad - tasaDeCambio;
            //}
            ConvYajala vm = new() 
            {
                Resultado=Resultado,
            };
            return View(vm);

        }

        public IActionResult Conversion()
        {
            return View(new ConvYajala());
        }

        //public IActionResult Cambiar(ConvYajala model) 
        //{
            
        //}
    }
}
