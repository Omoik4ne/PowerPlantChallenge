namespace ProductionPlan.Models;

public class Payload {

    public int Id {get; set;}
    public int Load { get; set; }
    public FuelType Fuel {get; set;}
    public List<PowerPlant>? Powerplants {get; set;}

}