namespace ProductionPlan.Models;

public class PowerPlant
{
    
    public string? Name { get; set; }

    public string? Type { get; set; }

    public decimal Efficiency { get; set; }
    //convert a MWh of fuel into a MWh of electrical energy. 1 for windturbine.

    public int Pmin { get; set; }
    // the maximum amount of power the powerplant can generate.
    public int Pmax { get; set; }
    // the minimmum amount of power the powerplant can generate.

}

// public enum PPType
// {
//     Gasfired,

//     Turbojet,

//     Windturbine
// }