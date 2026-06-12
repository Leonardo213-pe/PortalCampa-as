using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Models;
using PortalCampanas.Services;

namespace PortalCampanas.Controllers;

public class CampanasController : Controller
{
    private readonly CampanaService _service;

    public CampanasController(CampanaService service)
    {
        _service = service;
    }

    // Accion Resumen: calcula indicadores en memoria
    public IActionResult Resumen()
    {
        var campanas = _service.ObtenerTodas();
        var resumen = new ResumenViewModel
        {
            TotalCampanas = campanas.Count,
            CampanasVigentes = campanas.Count(c => c.Estado == "Vigente"),
            CampanasProximas = campanas.Count(c => c.Estado == "Próxima"),
            CampanasFinalizadas = campanas.Count(c => c.Estado == "Finalizada"),
            PromedioDescuento = campanas.Average(c => c.DescuentoPct),
            CantidadPorCanal = campanas.GroupBy(c => c.Canal)
                .ToDictionary(g => g.Key, g => g.Count())
        };
        return View(resumen);
    }

    public IActionResult Index(string? categoria, string? estado)
    {
        var campanas = _service.ObtenerTodas();

        if (!string.IsNullOrEmpty(categoria))
            campanas = campanas.Where(c => c.Categoria == categoria).ToList();

        if (!string.IsNullOrEmpty(estado))
            campanas = campanas.Where(c => c.Estado == estado).ToList();

        ViewBag.Categorias = _service.ObtenerCategorias();
        ViewBag.Estados = _service.ObtenerEstados();
        ViewBag.CategoriaSeleccionada = categoria;
        ViewBag.EstadoSeleccionado = estado;

        return View(campanas);
    }

    public IActionResult Detalle(int id)
    {
        var campana = _service.ObtenerPorId(id);
        if (campana == null)
            return NotFound();
        return View(campana);
    }
}
