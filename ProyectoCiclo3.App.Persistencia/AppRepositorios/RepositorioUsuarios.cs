using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    {
        List<Usuario> usuarios;
 
    public RepositorioUsuarios()
        {
            usuarios= new List<Usuario>()
            {
                new Usuario{id=1,nombre="Andres",apellidos= "Restrepo",direccion= "call 23 # 42-13",telefono= "11111113", ciudad="medellin"},
                new Usuario{id=2,nombre="Juliana",apellidos= "Moncada",direccion= "call 40 # 42-13",telefono= "99999999", ciudad="medellin"}
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetWithId(int id){
            return usuarios.SingleOrDefault(e => e.id == id);
        }
    }
}