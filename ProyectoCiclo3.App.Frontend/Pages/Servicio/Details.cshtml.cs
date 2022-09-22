using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
using Microsoft.AspNetCore.Authorization;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{   
    [Authorize]
    public class DetailsServicioModel : PageModel
    {
        
        private readonly RepositorioServicios repositorioServicio;
        public Servicio Servicio {get;set;}
 
        public DetailsServicioModel(RepositorioServicios repositorioServicio)
       {
            this.repositorioServicio=repositorioServicio;
       }
 
        public IActionResult OnGet(int servicioId)
        {
                Servicio=repositorioServicio.GetWithId(servicioId);
                return Page();
        }
    }
}