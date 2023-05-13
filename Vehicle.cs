class Vehicle
{
    string Name;
    public string _Name
    {
        get { return Name; }
    }
    int Passengers;
    public int _Passengers
    {
        get { return Passengers; }
    }
    string Color;
    public string _Color
    {
        get { return Color; }
    }
    Boolean Engine;
    public Boolean _Engine
    {
        get { return Engine; }
    }
    int Miles = 0;
    public int _Miles
    {
        get { return Miles; }
    }

    public Vehicle(string name, int passengers, string color, Boolean engine)
    {
        Name = name;
        Passengers = passengers;
        Color = color;
        Engine = engine;
        Miles = 0;
    }
    public Vehicle(string name, string color)
    {
        Name = name;
        Color = color;
        Engine = false;
        Miles = 0;
        Passengers = 0;
    }

    //method that prints out all information about the vehicle
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Passengers: {Passengers}, Color: {Color}, Engine: {Engine}, Miles: {Miles}");
    }


    public void Travel(int Miles)
    {
        this.Miles += Miles;
        Console.WriteLine($"This vehicle traveled {Miles} miles");
    }
}