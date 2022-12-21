namespace ProductionPlan.Models;

public class Fuel
{
    public int Gas { get; set; }
    //(euro/MWh): the price of gas per MWh. Thus if gas is at 6 euro/MWh and if the efficiency of the powerplant is 50% (i.e. 2 units of gas will generate one unit of electricity), the cost of generating 1 MWh is 12 euro.

    public int Kerosine { get; set; }
    //(euro/Mwh): the price of kerosine per MWh.
    public int CO2 { get; set; }
    //(euro/ton): the price of emission allowances (optionally to be taken into account).

    public int Wind { get; set; }
    //(%). 
    //Example: if there is on average 25% wind during an hour, a wind-turbine with a Pmax of 4 MW will generate 1MWh of energy.

}