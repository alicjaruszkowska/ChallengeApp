﻿var name = "Ewa";
bool isFemale = true;
var age = 29;

if (isFemale)
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }

}
else if (!isFemale)
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else if (age > 18)
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }
}
