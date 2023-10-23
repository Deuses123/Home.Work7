namespace MyClassLib.WorldOfTanks;

public class Tank
{
    public string Model { get; set; 
    public int? Ammunition { get; set; }
    public int? ArmorLevel { get; set; }     
    public int? LevelOfManeuverability { get; set; }

    public Tank(string model, int ammunition, int armorLevel, int levelOfManeuverability)
    {
        Model = model;
        if (ammunition >= 0 && ammunition <= 100)
            Ammunition = ammunition;
            else throw new Exception("Не правильное количество боекомплекта должно быть 0, 100");
        checkParam(armorLevel, " уровня брони ");
        checkParam(levelOfManeuverability, " уровня маневренности ");
    }


    public override string ToString()
    {
        return
                           "\nМодель: " + Model
                         + "\nБоекомплект: " + Ammunition + " снарядов "
                         + "\nУровень брони: " + ArmorLevel
                         + "\nУровень маневренности: " + LevelOfManeuverability + "\n";
    }
}