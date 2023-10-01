//Mod3LabMellem.Helper.Inputs.GetInt
// used for using
using Mod3LabMellem.Helper;



double GetBigDayCost(int days)
{
    double cost = days * 10.0;
    Console.WriteLine("The big day pass would cost you " + String.Format("{0:C2}", cost));
    return cost;
}
double GetTouristCost(int days, int minutes)
{
    double cost = days * minutes * .2;
    Console.WriteLine("The tourist pass would cost you " + String.Format("{0:C2}", cost));
    return cost;
}
double GetAdventurerCost(int days, int minutes)
{
    // total minutes/ total cost per day
    double cost = (days * minutes * .1) + (days * 3);
    Console.WriteLine("The adventure pass would cost you " + String.Format("{0:C2}", cost));
    return cost;
}
void GetCost()
{
    int numOfDays = Inputs.GetInt("How many days are you on vacation: ");
    int numOfMinutes = Inputs.GetInt("How many minutes per day do you talk: ");
    // must use the same data types ** check what GetBigDayCost was used as before
    double bigDay = GetBigDayCost(numOfDays);
    double tourist = GetTouristCost(numOfDays, numOfMinutes);
    double adventurer = GetAdventurerCost(numOfDays, numOfMinutes);

    if (bigDay < tourist && bigDay < adventurer)
    {
        Console.WriteLine("The big day is cheapest at " + String.Format("{0:C2}", bigDay));
    }else if (tourist < bigDay && tourist < adventurer)
    {
        Console.WriteLine("The tourist is cheapest at " + String.Format("{0:C2}", tourist));
    }
    else if (adventurer < bigDay && adventurer < tourist)
    {
        Console.WriteLine("The adventurer is cheapest at " + String.Format("{0:C2}", adventurer));
    }

}

GetCost();
GetCost();
GetCost();