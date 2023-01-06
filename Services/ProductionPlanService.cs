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
        //The response should be a json as in example_response.json, specifying for each powerplant
        // how much power each powerplant should deliver. The power produced by each powerplant has to be a multiple of 0.1 Mw 
        //and the sum of the power produced by all the powerplants together should equal the load.
    }
    public static List<Payload> GetAll() => Payloads;

    public static void Add(Payload payload)
    {
        Payloads.Add(payload);
    }

    //1) la load est un type de power. C'est la demande continue du power qui peut se prévoir.
    //2) A n'importe quel moment, la centrale doit générer suffisement de power pour arriver au meme stade que le load.
    //3) Le cout de production du power est différent pour chaque centrale et depend de plusieurs facteurs :
    //4) - turboreacteur qui fonctionne au kérosene a un cout de production + elevé que la centrale à gaz car :
    // *gaz est - cher que kerozene.
    // * rendement thermique d'une centrale a gaz est environ 50% (2 unité de gaz produise 1 unité electricité)
    //5) turboreacteur a un rendement thermique de 30% (environ 3 unité de kerozene pour 1 unité de electricité)
    //6) Coup de production des moulins à vent est nul
    //7) Tenir compte du Pmax
    //8) les centrales à gaz ont une charge minimale




    //private List<PayloadResponse> GetPowerPlantsActived(Payload powerSupplyDemand){};

    //private static int GetPowerPlantMaxPower(Payload powerSupplyDemand, PayloadResponse? powerPlantToActivate){};

    //private List<PayloadResponse> GetPowerUnitCosts(Payload powerSupplyDemand){};

    //Calculate Cost



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








}


    // EnergyProd p1 = new EnergyProd();
    // EnergyNeed l1 = new EnergyNeed();

    // public static void Add(PowerPlant p)
    // {
    //     PowerPlants.Add(p);
    // }
    // public bool FinalMethod()
    // {
    //    var result = CompareMatchingEnergy(this.p1, this.l1);
    //    return result;
    // }

    // public static bool CompareMatchingEnergy(EnergyProd p, EnergyNeed l)
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

