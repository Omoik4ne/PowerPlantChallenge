using Microsoft.AspNetCore.Mvc;
using ProductionPlan.Models;

namespace ProductionPlan.Services;

public class ProductionPlanService
{
    public static List<Payload> Payloads { get; }

    public static List<PowerPlant> PowerPlants { get; }

    public static PowerPlant powerplant;

    static ProductionPlanService()
    {

    }
    public static List<Payload> GetAll() => Payloads;

    public static void Add(Payload payload)
    {
        Payloads.Add(payload);
    }

    // public void CalculateMeritOrderToActivatePowerPlant(){
        
    //    if(powerplant.Type == "windturbine"){

    //    } else if (powerplant.Type == "turbojet"){

    //    } else if (powerplant.Type == "gasfired"){

    //    }

    // }


    //  public void CalculateProductionCost(){
        
    //  if(powerplant.Type == "windturbine"){

    //  ---None---

    //    } else if (powerplant.Type == "gasfired" || powerplant.Type == "turbojet"){

    //  PricePerHour / efficiency (env 0.5 or 0.3) -> Price for 1/MWH

    //    }

    // }


    //  public void CalculateProductionEnergy(){
        
    //    if(powerplant.Type == "windturbine"){

    //   ((PercentOfWind * Pmax) / efficiency (1) ) / 100 -> WHM/H

    //    } else if (powerplant.Type == "turbojet"){

    //

    //    } else if (powerplant.Type == "gasfired"){

    //    }

    // }


    // public void CalculateSumPower()
    // {
    //    
    // }

    // public static bool CompareMatchingEnergy(power, load)
    // {
    //     int power = p.Power;
    //     int load = l.Load;

    //     if (power == load)
    //     {
    //         return true;
    //     }
    //     else
    //     {
    //         return false;
    //     }
    // }







}


