using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class DetalleVenta : BaseEntity
{
    public int Cantidad { get; set; }
    public double ValorUnitario { get; set; }
    public int MyProperty { get; set; }
    public int IdTalla { get; set; }
    public Talla Tallas { get; set; }
    public int IdVenta { get; set; }
    public Venta Ventas { get; set; }
    public int IdInventario { get; set; }
    public Inventario Inventarios { get; set; }
}
