using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BrickplasWebCore.Model;

namespace Frontend.Data
{
    public class CasaContext : DbContext
    {
        public CasaContext (DbContextOptions<CasaContext> options)
            : base(options)
        {
        }

        public DbSet<BrickplasWebCore.Model.Usuario> Usuario { get; set; } = default!;

        public DbSet<BrickplasWebCore.Model.Familia> Familia { get; set; } = default!;

        public DbSet<BrickplasWebCore.Model.Patente> Patente { get; set; } = default!;

        public DbSet<BrickplasWebCore.Model.Categoria> Categoria { get; set; } = default!;

        public DbSet<BrickplasWebCore.Model.Producto> Producto { get; set; } = default!;

        public DbSet<BrickplasWebCore.Model.Venta> Venta { get; set; } = default!;

        public DbSet<BrickplasWebCore.Model.DetalleVenta> detalleVenta { get; set; } = default!;

        public DbSet<BrickplasWebCore.Model.Pedido> Pedido { get; set; } = default!;

        public DbSet<BrickplasWebCore.Model.DetallePedido> DetallePedido { get; set; } = default!;

        public DbSet<BrickplasWebCore.Model.Bitacora> Bitacora { get; set; } = default!;


    }
}
