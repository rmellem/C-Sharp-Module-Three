using Helper;
//Ask the user for how many days they exceeded 10,000 steps in the month
//int test = Inputs.GetInt("Test");
//Console.Write("Number of days with 10,000 steps are exceeded: ");
//Hold the users days exceeded steps information in a variable to utilize later
int numDaysStepsExceeded = Inputs.GetInt("Number of days with 10,000 steps are exceeded: ");
//Ask the user for number of yoga classes attended in the month
//Console.Write("Number of yoga classes attended: ");
//Hold the users number of Yoga classes information in a variable to utilize later
int numYogaClasses = Inputs.GetInt("Number of yoga classes attended: ");
//Ask the user for number of Aerobics classes attended in the month
//Console.Write("Number of aerobics classes attended: ");
//Hold the users number of Aerobic classes information in a variable to utilize later
int numAerobicsClasses = Inputs.GetInt("Number of aerobics classes attended: ");
//Ask the user for number of weekly nutrition meetings attended in the month
//Console.Write("Number of weekly nutrition meetings attended: ");
//Hold the users number of weekly nutrition meetings information in a variable to utilize later
int numWeeklyNutritionMeetings = Inputs.GetInt("Number of weekly nutrition meetings attended: ");

/*Convert User data type (string input) to data type (int) variable
int numDaysOverTenThousand = Convert.ToInt32(numDaysStepsExceeded);
int numYoga = Convert.ToInt32(numYogaClasses);
int numAerobics = Convert.ToInt32(numAerobicsClasses);
int numNutritionMeetings = Convert.ToInt32(numWeeklyNutritionMeetings);
decided to convert to an int when I read the user data
- worked to better understand the Input.GetInt()
*/

//LOCAL function to determine alotted points for steps exceeded 10,000
int GetMonthlyStepPoints(int days)
{
    return days * 5;
}

//LOCAL funtion to assign correct points/month for Yoga classes attended
int GetMonthlyYogaPoints(int qtyYogaClasses)
{
    //GOAL
    if (qtyYogaClasses >= 12)
    {
        //Reward
        return 30;
    }
    else if (qtyYogaClasses >= 6)
    {
        return 10;
    }
    else
    {
        return 0;
    }
}

//LOCAL funtion to assign correct points/month for Aerobics classes attended
int GetMonthlyAerobicsPoints(int qtyAerobicsClasses)
{
    if (qtyAerobicsClasses >= 12)
    {
        return 50;
    }
    else if (qtyAerobicsClasses >= 6)
    {
        return 20;
    }
    else
    {
        return 0;
    }
}

//LOCAL funtion to assign correct points/month for Nutrition Weekly meetings
int GetMonthlyNutritionMeetings(int qtyNutritionMeetings)
{
    if (qtyNutritionMeetings >= 4)
    {
        return 40;
    }
    else if (qtyNutritionMeetings >= 1)
    {
        return 10;
    }
    else
    {
        return 0;
    }
}
int totalPointsEarned = GetMonthlyStepPoints(numDaysStepsExceeded) + GetMonthlyYogaPoints(numYogaClasses) 
    + GetMonthlyAerobicsPoints(numAerobicsClasses) + GetMonthlyNutritionMeetings(numWeeklyNutritionMeetings);
int totalGiftCardsEarned = totalPointsEarned / 50;
Console.WriteLine("Your Monthly Points earned was: " + totalPointsEarned);
Console.WriteLine("You earned " + totalGiftCardsEarned + " Amazon Gift Cards this month.");