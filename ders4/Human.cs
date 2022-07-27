namespace Mammals;
public class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public bool isHaveSalary { get; set; }


    public static bool IsEnoughSalary(decimal salary)
    {
        if (salary > 6500)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}