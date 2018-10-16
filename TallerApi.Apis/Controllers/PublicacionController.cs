using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TallerApi.Apis.Models;

namespace TallerApi.Apis.Controllers
{
    public class PublicacionController : ApiController
    {
        [HttpGet]
        public IEnumerable<Publicacion> Get()
        {
            using (var context = new TallerContext())
            {
                return context.Publicaciones.ToList();
            }
        }

        [HttpGet]
        public Publicacion Get(int id)
        {
            using (var context = new TallerContext())
            {
                return context.Publicaciones.FirstOrDefault(x=> x.Id == id);
            }
        }

        [HttpPost]
        public IHttpActionResult post(Publicacion publicacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new TallerContext())
            {
                context.Publicaciones.Add(publicacion);
                context.SaveChanges();
                return Ok(publicacion);
            }
        }

        [HttpPut]
        public Publicacion Put(Publicacion publicacion)
        {
            using (var context = new TallerContext())
            {
                var publicacionAct = context.Publicaciones.FirstOrDefault(x => x.Id == publicacion.Id);
                publicacionAct.Usuario = publicacion.Usuario;
                publicacionAct.Descripcion = publicacion.Descripcion;
                publicacionAct.Usuario = publicacion.Usuario;
                publicacionAct.MeGusta = publicacion.MeGusta;
                publicacionAct.MeDisgusta = publicacion.MeDisgusta;
                publicacionAct.VecesCompartido = publicacion.VecesCompartido;

                context.SaveChanges();
                return publicacion;
            }
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new TallerContext())
            {
                var publicacionDel = context.Publicaciones.FirstOrDefault(x => x.Id == id);
                context.Publicaciones.Remove(publicacionDel);
                context.SaveChanges();
                return true;
            }
        }
    }
}
