using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicios
    {
        List<Servicio> servicios;
 
    public RepositorioServicios()
        {
            servicios= new List<Servicio>()
            {
                new Servicio{id=1,origen=new Usuario{id=3,nombre="Pedro",apellidos= "Perez",direccion= "carrera 80 # 2-10",telefono= "2222222", ciudad="Bogota"},destino= new Usuario{id=2,nombre="Julian",apellidos= "Moncada",direccion= "calle 40 # 42-13",telefono= "99999999", ciudad="Medellin"},fecha= DateTime.Now,hora= "3:50", encomienda=new Encomienda{id=3,descripcion="Destornilladores",peso= 130,tipo= "Electronico",presentacion= "Caja"}}
            };
        }
 
        public IEnumerable<Servicio> GetAll()
        {
            return servicios;
        }
 
        public Servicio GetWithId(int id){
            return servicios.SingleOrDefault(e => e.id == id);
        }

         public Servicio Create(Servicio newServicio)
        {
           if(servicios.Count > 0){
             newServicio.id=servicios.Max(r => r.id) +1;
            }else{
               newServicio.id = 1;
            }
           servicios.Add(newServicio);
           return newServicio;
        }

        public Servicio Delete(int id)
        {
            var servicio = servicios.SingleOrDefault(e => e.id == id);
            servicios.Remove(servicio);
            return servicio;
        }
    }
}