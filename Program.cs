string[] mass1 = ["Hgggo", "2", "ld", ":-)"];
int size_mass2 = 0;

for (int i = 0; i < mass1.Length; i++)
{
    if (mass1[i].Length <= 3)
    {
        size_mass2 = size_mass2 += 1;
    }
}

string[] mass2 = new string[size_mass2];
int j = 0;

for (int i = 0; i < mass1.Length; i++)
{
    if (mass1[i].Length <= 3)
    {
        mass2[j] = mass1[i];
        j += 1;
    }
}

Console.WriteLine($"Массив: [ {string.Join("; ", mass2)} ]");