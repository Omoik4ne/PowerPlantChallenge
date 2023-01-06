using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductionPlan.Models;
using ProductionPlan.Services;

namespace ProductionPlan.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductionPlanController : ControllerBase
{

    public ProductionPlanController()
    {

    }

    [HttpGet]
public ActionResult<List<Payload>> GetAll() =>
    ProductionPlanService.GetAll();


[HttpPost]
    public IActionResult Create(Payload payload)
    { 
        ProductionPlanService.Add(payload);
        return CreatedAtAction(nameof(Create), new { id = payload.Id }, payload);

    }

    // [HttpPost]
    // public IActionResult Create(PowerPlant powerplant)
    // {
    //     ProductionPlanService.Add(powerplant);
    //     return CreatedAtAction(nameof(Create), new { name = powerplant.Name }, powerplant);

    // }


}
