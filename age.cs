using System;
class myclass
{
    private int age;
    public void showage()
    {
        Console.WriteLine("Enter the age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Age is" + age);
    }
}
class prg
{
    static void Main()
    {
        myclass a=new myclass();
        a.showage();
    }
}
