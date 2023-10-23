namespace MyClassLib;


public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public List<int> score { get; set; }
    
    public Employee(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        score = new List<int>();
    }

    public static bool operator > (Employee a, Employee b)
    {
        return a.score.Sum() > b.score.Sum();
    }
    public static bool operator < (Employee a, Employee b)
    {
        return a.score.Sum() < b.score.Sum();
    }
    
    public static bool operator ==(Employee person1, Employee person2)
    {
        if (ReferenceEquals(person1, null) && ReferenceEquals(person2, null))
            return true;
        if (ReferenceEquals(person1, null) || ReferenceEquals(person2, null))
            return false;

        return person1.FirstName == person2.FirstName &&
               person1.LastName == person2.LastName &&
               person1.Age == person2.Age;
    }

    public static bool operator !=(Employee person1, Employee person2)
    {
        return !(person1 == person2);
    }

    public override bool Equals(object obj)
    {
        if (obj is Employee other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName, Age);
    }
}