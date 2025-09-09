using proyecto_Practica01_.Servicio;
using proyecto_Practica01_.Dominio;

ArticuloServicio oServicio = new ArticuloServicio(); 
FacturaServicio facturaServicio = new FacturaServicio();

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

//                                   SAVE articulo
//---------------------------------------------------------------------

Articulo MiArticulo = new Articulo();
MiArticulo.id_articulo = 5;
MiArticulo.Nombre = "Monster";
MiArticulo.PrecioUnitario = 2500.4M;

bool resultado = oServicio.SaveArticulo(MiArticulo);

if (resultado)
{
    Console.WriteLine("Se ha guardado el articulo con exito");
}
else
{
    Console.WriteLine("No se ha podido guardar el articulo");
}
//                                   SAVE factura
//---------------------------------------------------------------------
Factura Mifactura = new Factura();
Mifactura.nro_factura = 2;
Mifactura.Fecha = DateTime.Today;
Mifactura.id_formapago = 3;
Mifactura.Cliente = "facundo";

bool rdo = facturaServicio.SaveFactura(Mifactura);
if (rdo)
{
    Console.WriteLine("Se ha guardado la factura con exito");
}
else
{
    Console.WriteLine("No se ha podido guardar la factura");
}

//                                   SAVE detallefactura
//---------------------------------------------------------------------




