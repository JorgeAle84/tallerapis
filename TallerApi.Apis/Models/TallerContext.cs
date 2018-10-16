using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TallerApi.Apis.Models
{
    public class TallerContext : DbContext
    {
        public TallerContext() : base("PublicacionConnection")
        {
        }
        public DbSet<Publicacion> Publicaciones { get; set; }

  }
}