using ProductionPlan.Models;

namespace ProductionPlan.Services;

public static class ProductionPlanService
{
    public static List<PowerPlant> PowerPlants { get; }
    static ProductionPlanService()
    {
        //The response should be a json as in example_response.json, specifying for each powerplant
        // how much power each powerplant should deliver. The power produced by each powerplant has to be a multiple of 0.1 Mw 
        //and the sum of the power produced by all the powerplants together should equal the load.


        PowerPlants = new List<PowerPlant>
        {
            new PowerPlant { Name = "gasfiredbig1", Type= "gasfired", Efficiency= 0.53M, Pmin= 100, Pmax= 460 },
            new PowerPlant { Name= "gasfiredsomewhatsmaller", Type= "gasfired", Efficiency= 0.37M, Pmin= 40, Pmax= 210  }
        };
    }

    public static List<PowerPlant> GetAll() => PowerPlants;

    public static void Add(PowerPlant p)
    {
        PowerPlants.Add(p);
    }

    public static PowerPlant? Get(string Name) => PowerPlants.FirstOrDefault(p => p.Name == Name);

    public static void Delete(string Name)
    {
        var p = Get(Name);
        if (p is null)
            return;

        PowerPlants.Remove(p);
    }

    public static void Update(PowerPlant p)
    {
        var index = PowerPlants.FindIndex(p => p.Name == p.Name);
        if (index == -1)
            return;

        PowerPlants[index] = p;
    }

}