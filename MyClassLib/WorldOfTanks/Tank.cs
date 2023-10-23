namespace MyClassLib.WorldOfTanks;

public class Tank
{
    public string Model { get; }
    public int? Ammunition { get; }
    public int? ArmorLevel { get; }     
    public int? LevelOfManeuverability { get; }

    public Tank(string model, int ammunition, int armorLevel, int levelOfManeuverability)
    {
        Model = model;
        if (ammunition >= 0 && ammunition <= 100) Ammunition = ammunition;
        else throw new Exception("Не правильное количество боекомплекта (0, 100)");
        if (armorLevel >= 0 && armorLevel <= 100) ArmorLevel = armorLevel;
        else throw new Exception("Не правильный уровень брони (0, 100)");
        if (levelOfManeuverability >= 0 && levelOfManeuverability <= 100) LevelOfManeuverability = levelOfManeuverability;
        else throw new Exception("Не правильный уровень маневренности (0, 100)");
    }
    public static Tank? operator* (Tank a, Tank b)
    {
        var countA = 0;
        var countB = 0;

        if (a.Ammunition > b.Ammunition) countA++;
        else countB++;
        if (a.ArmorLevel > b.ArmorLevel) countA++;
        else countB++;
        if (a.LevelOfManeuverability > b.LevelOfManeuverability) countA++;
        else countB++;
        try
        {
            if (countA - countB >= 2)
                return a;
            if (countB - countA >= 2)
                return b;
            throw new Exception("Exception: Два танка убили друг друга");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }

    public Tank()
    {
    }

    public override string ToString()
    {
        return
            "\nМодель: " + Model
                         + "\nБоекомплект: " + Ammunition + " снарядов "
                         + "\nУровень брони: " + ArmorLevel + " очков "
                         + "\nУровень маневренности: " + LevelOfManeuverability + " очков\n";
    }
}