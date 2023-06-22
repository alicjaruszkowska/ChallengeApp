var name = "Ewa";
bool isFemale = true;
var age = 33;

if (isFemale)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta powyżej 33 lat");
    }
    else if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }

}
else
{
    if (age > 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
}