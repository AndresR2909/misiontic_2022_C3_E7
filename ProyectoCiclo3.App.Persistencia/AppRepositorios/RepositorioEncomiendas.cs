using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomiendas
    {
        //List<Encomienda> encomiendas;
 
    /*public RepositorioEncomiendas()
        {
            encomiendas= new List<Encomienda>()
            {
                new Encomienda{id=1,descripcion="Camiseta",peso= 100,tipo= "Ropa",presentacion= "Caja"},
                new Encomienda{id=2,descripcion="Disco Duro",peso= 200,tipo= "Electronico",presentacion= "Caja"},
                new Encomienda{id=3,descripcion="Destornilladores",peso= 130,tipo= "Electronico",presentacion= "Caja"}
            };
        }*/
        private readonly AppContext _appContext = new AppContext();
        public IEnumerable<Encomienda> GetAll()
        {
            //return encomiendas;
            return _appContext.Encomiendas;
        }
 
        public Encomienda GetWithId(int id){
            //return encomiendas.SingleOrDefault(e => e.id == id);
            return _appContext.Encomiendas.Find(id);
        }

        public Encomienda Update(Encomienda newEncomienda){
            //var encomienda = encomiendas.SingleOrDefault(e => e.id == newEncomienda.id);
            var encomienda = _appContext.Encomiendas.Find(newEncomienda.id);
            if(encomienda != null){
                encomienda.descripcion = newEncomienda.descripcion;
                encomienda.peso = newEncomienda.peso;
                encomienda.tipo = newEncomienda.tipo;
                encomienda.presentacion = newEncomienda.presentacion;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return encomienda;
        }
        public Encomienda Create(Encomienda newEncomienda)
        {
           /*if(encomiendas.Count > 0){
             newEncomienda.id=encomiendas.Max(r => r.id) +1;
            }else{
               newEncomienda.id = 1;
            }
           encomiendas.Add(newEncomienda);
           return newEncomienda;*/
           var addEncomienda = _appContext.Encomiendas.Add(newEncomienda);
            //Guardar en base de datos
            _appContext.SaveChanges();
            return addEncomienda.Entity;
        }

        public Encomienda Delete(int id)
        {
            /*var encomienda = encomiendas.SingleOrDefault(e => e.id == id);
            encomiendas.Remove(encomienda);
            return encomienda;*/
            var encomienda = _appContext.Encomiendas.Find(id);
            if (encomienda != null){
                _appContext.Encomiendas.Remove(encomienda);
                //Guardar en base de datos
                _appContext.SaveChanges();
            }
            return null;
        }

    }
}