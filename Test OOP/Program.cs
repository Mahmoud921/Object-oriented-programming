using OOP;

class Program {
    static void Main()
    {
        Console.WriteLine("=============== Car ===============");
        Car car = new Car("BMW", "Xs6","Red",2022,Fuel.Electric);
        Console.WriteLine($"Brand: {car.CarBrand}");
        Console.WriteLine($"Model: {car.CarModel}");
        Console.WriteLine($"Color: {car.CarColor}");
        Console.WriteLine($"Year: {car.MakeYear}");
        Console.WriteLine($"Fuel Type: {car.Fuel}");

    }
}
