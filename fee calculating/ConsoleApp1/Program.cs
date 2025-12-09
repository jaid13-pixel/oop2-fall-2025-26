using System;

abstract class Member
{
    public string name;
    public int memberId;

    public abstract int CalculateFee();
}

class StudentMember : Member
{
    public override int CalculateFee()
    {
        return 300;
    }
}

class RegularMember : Member
{
    public override int CalculateFee()
    {
        return 500;
    }
}

class Program
{
    static void Main()
    {
        Member s = new StudentMember();
        Member r = new RegularMember();

        Console.WriteLine("Student fee: " + s.CalculateFee());
        Console.WriteLine("Regular fee: " + r.CalculateFee());
    }
}
