namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of Vehical do you want to make? Car or Moto");
            string userInput = Console.ReadLine();

            vehicleFactory factory = new vehicleFactory();
            IVehicle myVehicle = factory.CreatVehicle(userInput);

            myVehicle.Drive();

            Console.WriteLine("Lets make another vehicle");
            userInput = Console.ReadLine();

        }
    }
}
