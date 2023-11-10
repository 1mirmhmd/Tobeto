string[] names = new string[]
{
    "Aziz",
    "Nadir",
    "Gaffar",
    "Samet"
};
foreach (string name in names)
{
    Console.WriteLine(name);
}
List<string> names0 = new List<string>
{
    "Aziz",
    "Nadir",
    "Gaffar",
    "Samet"
};
names0.Add("Bilal");
foreach (var name in names0)
{
    Console.WriteLine(name);
}