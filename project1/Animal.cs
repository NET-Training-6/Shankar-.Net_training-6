class Animal
{

    byte legs;
    string name;
    string color;

    string sex;
    string food;
    byte weight;

    void setValue()
    {
        Console.Write("Enter the no of legs");
        this.legs = Convert.ToByte(Console.ReadLine());
        Console.Write("Enter the  name of animal");
        this.name = Console.ReadLine();
        Console.Write("Enter the  color");
        this.color = Console.ReadLine();
        Console.Write("Enter the Sex");
        this.sex = Console.ReadLine();
        Console.Write("Enter the favourite food");
        this.food = Console.ReadLine();
        Console.Write("Enter the weight");
        this.weight = Convert.ToByte(Console.ReadLine());

    }

    void getValue()
    {

        Console.WriteLine("No of legs=" + this.legs);
        Console.WriteLine("NAME=" + this.name);
        Console.WriteLine("COLOR=" + this.color);
        Console.WriteLine("GENDER=" + this.sex);
        Console.WriteLine("FOOD=" + this.food);
        Console.WriteLine("WEIGHT=" + this.weight);

    }

    public static void Main()
    {

        Animal a1 = new Animal();
        a1.setValue();
        a1.getValue();
        Animal a2 = new Animal();
        a2.setValue();
        a2.getValue();
    }



}