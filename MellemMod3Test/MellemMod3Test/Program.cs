
// functions need 3 things to work
/* return type: This is what gets returned from the fuction call
   function name: UpperCamelCase
   parameters: Option - the arguments used to call a function
*/

void SayHi()
{
    Console.WriteLine("Hello");
}

SayHi();
SayHi();
SayHi();

//Function Signature - arguements need to match 
void SayHiToSomeone(string name)
{
    Console.WriteLine("Hello " + name);
}
// This function take one argument
SayHiToSomeone("Patrick");
SayHiToSomeone("Burt");

double GetArea(double width, double length)
{
    double area = width * length;
    return area;
    Console.WriteLine("I hate this class");
}

Console.WriteLine(GetArea(4, 5));
double area = GetArea(2.5, 10);
Console.WriteLine(area);


//A >= 100-90
// B >=80

// want a return letter grade
string GetLetterGrade(double grade)
{
    string letterGrade = "F";

    if (grade >= 90)
    {
        letterGrade = "A";
    } else if (grade >= 80)
    {
        letterGrade = "B";
    } else if (grade >= 70)
    {
        letterGrade = "C";
    } else if (grade >= 60)
    {
        letterGrade = "D";
    }

    return letterGrade;
}

Console.WriteLine(GetLetterGrade(92));
Console.WriteLine(GetLetterGrade(87));
Console.WriteLine(GetLetterGrade(80));
Console.WriteLine(GetLetterGrade(15));
Console.WriteLine(GetLetterGrade(68));