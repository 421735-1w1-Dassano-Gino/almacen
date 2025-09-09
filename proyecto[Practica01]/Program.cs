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
//MiArticulo.id_articulo = 1; //update
MiArticulo.Nombre = "Speed";
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
//Mifactura.nro_factura = 2; //update
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
 DetalleFactura Midetalle = new DetalleFactura();
//Midetalle.idDetalle = 29; //update
Midetalle.idFactura = 1;
Midetalle.id_articulo = 1;
Midetalle.Cantidad = 1;

bool dfrdo = detalleServicio.SaveDetalle(Midetalle);
if (dfrdo)
{
    Console.WriteLine("Se a guardado con exito el detalle");
}
else
{
    Console.WriteLine("No se a podido guardar el detalle");
}


