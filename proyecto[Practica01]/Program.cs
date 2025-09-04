using proyecto_Practica01_.Servicio;
using proyecto_Practica01_.Dominio;

FacturaServicio fServicio = new FacturaServicio();
List<Factura> fc = fServicio.GetFacturas();

DetalleServicio detalleServicio = new DetalleServicio();
List<DetalleFactura> dc = detalleServicio.GetDetalleFacturas();

ArticuloServicio articuloServicio = new ArticuloServicio();
List<Articulo> ac = articuloServicio.GetArticulos();

if (ac.Count > 0)
    foreach (Articulo a in ac)
        Console.WriteLine(a);
else Console.WriteLine("No hay Detalles");
