using Microsoft.AspNetCore.Mvc;
using ProductionPlan.Services;
using ProductionPlan.Models;

namespace ProductionPlan.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductionPlanController : ControllerBase
{

    public ProductionPlanController()
    {

    }

    [HttpPost]
    public IActionResult Create(PowerPlant powerplant){
        ProductionPlanService.Add(powerplant);
        return CreatedAtAction(nameof(Create), new { name = powerplant.Name}, powerplant);

    }
}
