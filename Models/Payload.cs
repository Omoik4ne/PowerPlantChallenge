namespace ProductionPlan.Models;

public class Payload
{
    public int Load { get; set; }
    //load: The load is the amount of energy (MWh) that need to be generated during one hour.

    public int Power { get; set; }

}