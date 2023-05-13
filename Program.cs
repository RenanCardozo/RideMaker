// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Vehicle Jag = new Vehicle("Jaguar", 4, "Black", true);
Vehicle Benz = new Vehicle("Mercedes", "Red");
Vehicle Mustang = new Vehicle("Mustang", "Neon-Blue");
Vehicle Lambo = new Vehicle("lamborghini", 2, "White", true);



List<Vehicle> carList = new List<Vehicle>();

carList.Add(Jag);
carList.Add(Benz);
carList.Add(Mustang);
carList.Add(Lambo);

//loop through list of cars

//use ShowInfo() method to display information about each car

foreach (Vehicle car in carList)
{
    car.ShowInfo();
}

carList[1].Travel(100);
carList[1].ShowInfo();






