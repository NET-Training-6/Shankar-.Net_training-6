class Person
{
    string Fname;
    string lname;
    int age;
    string fullname;

    void GetName()
    {
        Console.Write("Enter first name:");
        this.Fname = Console.ReadLine();
        Console.Write("Enter Last name:");
        this.lname = Console.ReadLine();
        Console.Write("Enter age");
        this.age = Convert.ToInt32(Console.ReadLine());

    }

    void displayName()
    {
        this.fullname = this.Fname + " " + this.lname;
        Console.WriteLine("Hai.." + fullname);
        Console.WriteLine("Your age is:-" + this.age);
    }

    
}