using PortalCampanas.Models;

namespace PortalCampanas.Services;

public class CampanaService
{
    private static readonly List<Campana> _campanas = new()
    {
        new Campana
        {
            Id = 1,
            Nombre = "Super Oferta Verano Tech",
            Categoria = "Tecnología",
            Estado = "Vigente",
            FechaInicio = new DateTime(2026, 5, 15),
            FechaFin = new DateTime(2026, 6, 30),
            DescuentoPct = 25,
            Canal = "Web",
            Descripcion = "Grandes descuentos en laptops, tablets y smartphones de las mejores marcas."
        },
        new Campana
        {
            Id = 2,
            Nombre = "Renovación Hogar Junio",
            Categoria = "Hogar",
            Estado = "Vigente",
            FechaInicio = new DateTime(2026, 6, 1),
            FechaFin = new DateTime(2026, 6, 30),
            DescuentoPct = 30,
            Canal = "Tienda",
            Descripcion = "Renueva tu hogar con muebles, electrodomésticos y decoración a precios increíbles."
        },
        new Campana
        {
            Id = 3,
            Nombre = "Moda Primavera Collection",
            Categoria = "Moda",
            Estado = "Vigente",
            FechaInicio = new DateTime(2026, 5, 1),
            FechaFin = new DateTime(2026, 7, 15),
            DescuentoPct = 20,
            Canal = "App",
            Descripcion = "Las últimas tendencias de moda para esta temporada con descuentos exclusivos."
        },
        new Campana
        {
            Id = 4,
            Nombre = "Electro Fest Julio",
            Categoria = "Electro",
            Estado = "Próxima",
            FechaInicio = new DateTime(2026, 7, 1),
            FechaFin = new DateTime(2026, 7, 31),
            DescuentoPct = 35,
            Canal = "Web",
            Descripcion = "El festival de electrodomésticos más grande del año. Lavadoras, refrigeradoras y más."
        },
        new Campana
        {
            Id = 5,
            Nombre = "Back to School Tech",
            Categoria = "Tecnología",
            Estado = "Próxima",
            FechaInicio = new DateTime(2026, 7, 15),
            FechaFin = new DateTime(2026, 8, 15),
            DescuentoPct = 15,
            Canal = "App",
            Descripcion = "Prepárate para el nuevo año escolar con laptops, tablets y útiles tecnológicos."
        },
        new Campana
        {
            Id = 6,
            Nombre = "Liquidación Verano Moda",
            Categoria = "Moda",
            Estado = "Próxima",
            FechaInicio = new DateTime(2026, 7, 20),
            FechaFin = new DateTime(2026, 8, 10),
            DescuentoPct = 50,
            Canal = "Tienda",
            Descripcion = "Liquidación total de la colección de verano. Hasta 50% de descuento."
        },
        new Campana
        {
            Id = 7,
            Nombre = "Oferta Navidad Hogar 2025",
            Categoria = "Hogar",
            Estado = "Finalizada",
            FechaInicio = new DateTime(2025, 12, 1),
            FechaFin = new DateTime(2025, 12, 31),
            DescuentoPct = 40,
            Canal = "Web",
            Descripcion = "Campaña navideña con descuentos especiales en artículos para el hogar."
        },
        new Campana
        {
            Id = 8,
            Nombre = "Año Nuevo Electro",
            Categoria = "Electro",
            Estado = "Finalizada",
            FechaInicio = new DateTime(2026, 1, 1),
            FechaFin = new DateTime(2026, 1, 15),
            DescuentoPct = 20,
            Canal = "App",
            Descripcion = "Inicia el año con los mejores electrodomésticos a precios de año nuevo."
        },
        new Campana
        {
            Id = 9,
            Nombre = "San Valentín Moda",
            Categoria = "Moda",
            Estado = "Finalizada",
            FechaInicio = new DateTime(2026, 2, 10),
            FechaFin = new DateTime(2026, 2, 15),
            DescuentoPct = 18,
            Canal = "Web",
            Descripcion = "Sorprende a tu pareja con regalos de moda para San Valentín."
        },
        new Campana
        {
            Id = 10,
            Nombre = "Semana Santa Tech Deals",
            Categoria = "Tecnología",
            Estado = "Finalizada",
            FechaInicio = new DateTime(2026, 4, 1),
            FechaFin = new DateTime(2026, 4, 10),
            DescuentoPct = 22,
            Canal = "Tienda",
            Descripcion = "Aprovecha las fiestas para renovar tu equipo tecnológico con grandes descuentos."
        }
    };

    public List<Campana> ObtenerTodas() => _campanas;

    public Campana? ObtenerPorId(int id) => _campanas.FirstOrDefault(c => c.Id == id);
}
