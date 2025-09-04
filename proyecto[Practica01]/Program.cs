using proyecto_Practica01_.Servicio;
using proyecto_Practica01_.Dominio;

FacturaServicio oServicio = new FacturaServicio();
List<Factura> lp = oServicio.GetFacturas();
if (lp.Count > 0)
    foreach (Factura f in lp)
        Console.WriteLine(f);
else Console.WriteLine("No hay facturas");
