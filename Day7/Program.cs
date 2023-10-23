using MyClassLib.WorldOfTanks;
using MyClassLib;

public class Program
{
    public static void Main(string[] args)
    {
        //Task1
        Fight();
        
        
        //Task2 
        Thread.Sleep(1500);
        Console.WriteLine("\nДополнительное задание #1");
        var sanzh = new Employee("Sanzhar", "Kalibekov", 21);
        var sanzh2 = new Employee("Sanzhar", "Kalibekov", 21);
        var elkhan = new Employee("Elkhan", "Isaev", 20);
        var alikhan = new Employee("Alikhan", "Sabitov", 20);

        Console.WriteLine("Проверка на равенство с использованием перегруженных операторов");
        Console.WriteLine("sanzh == sanzh2: " + (sanzh == sanzh2));
        Console.WriteLine("elkhan == alikhan: " + (elkhan == alikhan));

        Console.WriteLine("Проверка на неравенство с использованием перегруженных операторов");
        Console.WriteLine("sanzh != alikhan: " + (sanzh != alikhan)); 
        Console.WriteLine("sanzh != sanzh2: " + (sanzh != sanzh2));

        Console.WriteLine("Проверка на равенство с использованием метода Equals");
        Console.WriteLine("sanzh.Equals(sanzh2): " + sanzh.Equals(sanzh2));
        Console.WriteLine("elkhan.Equals(alikhan): " + elkhan.Equals(alikhan));
        
        //Task 3
        Console.WriteLine("\nДополнительное задание #2 Сравнивание массивов в обьекте");
        //Добавляем количество очков каждому Employee
        sanzh.score.Add(4);
        sanzh.score.Add(2);
        sanzh2.score.Add(3);
        sanzh2.score.Add(2);

        Console.WriteLine("sanzh>sanzh2: " + (sanzh>sanzh2));
        Console.WriteLine("sanzh<sanzh2: " + (sanzh<sanzh2));
        
        
        //Task 4
        Console.WriteLine("\nДополнительное задание #3 сравнивание и суммирование разных валют");
        var OneUsdToKzt = Money.Convert(new Money(1, "USD"), "KZT").Result;
        var tenge = new Money(OneUsdToKzt, "KZT");
        var dollar = new Money(1, "USD");
        Console.WriteLine("479 KZT == 1 USD: " + (tenge == dollar));

        var eur = new Money(500, "EUR");
        var usd = new Money(500, "USD");
        Console.WriteLine("500 eur != 500 USD: " + (eur!=usd));

        Console.WriteLine("500 eur + 500 USD = " + (eur+usd));
    }

    private static void Fight()
    {
        var random = new Random();
        var teamA = new List<Tank>(5)
        {
            new Tank("E100", random.Next(0, 100), random.Next(0, 100), random.Next(0, 100)),
            new Tank("Maus", random.Next(0, 100), random.Next(0, 100), random.Next(0, 100)),
            new Tank("Leopard1", random.Next(0, 100), random.Next(0, 100), random.Next(0, 100)),
            new Tank("E50M", random.Next(0, 100), random.Next(0, 100), random.Next(0, 100)),
            new Tank("WaffentragerAufE100", random.Next(0, 100), random.Next(0, 100), random.Next(0, 100))
        };
        
        var teamB = new List<Tank>(5)
        {
            new Tank("IS7", random.Next(0, 100), random.Next(0, 100), random.Next(0, 100)),
            new Tank("Object430u", random.Next(0, 100), random.Next(0, 100), random.Next(0, 100)),
            new Tank("Object268var4", random.Next(0, 100), random.Next(0, 100), random.Next(0, 100)),
            new Tank("T100LT", random.Next(0, 100), random.Next(0, 100), random.Next(0, 100)),
            new Tank("Object279Early", random.Next(0, 100), random.Next(0, 100), random.Next(0, 100))
        };

        if (teamA.Count != teamB.Count)
        {
            Console.WriteLine("Не честный ВБР!");
            return;
        }

        var countA = 0;
        var countB = 0;
        for (var i = 0; i < teamA.Count; i++)
        {
            Console.WriteLine("Счёт - " + countA + " : " + countB);
            Console.WriteLine("Бой: " + teamA[i].Model + " vs " + teamB[i].Model);
            Console.WriteLine(teamA[i]);
            Console.WriteLine(teamB[i]);
            Thread.Sleep(2000);
            var winner = teamA[i] * teamB[i];
            if (winner == null)
            {
                Console.WriteLine("Обе танки проиграли из за недостаточных характеристик");
                continue;
            }
            Console.WriteLine(winner.Model + " выиграл");
            if (winner.Model == teamA[i].Model) countA++;
            if (winner.Model == teamB[i].Model) countB++;
            Thread.Sleep(2000);
            if (i != teamA.Count - 1) Console.Clear();
        }
        Console.WriteLine(countA > countB ? "Команда A выйграла" : "Команда B выйграла");


    }
}