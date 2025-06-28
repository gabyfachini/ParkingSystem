namespace ParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot(initialPrice: 5, hourlyRate: 2);
            string option;

            do
            {
                Console.Clear();
                Console.WriteLine("PARKING SYSTEM");
                Console.WriteLine("1. Add vehicle");
                Console.WriteLine("2. List vehicles");
                Console.WriteLine("3. Remove vehicle");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter the vehicle plate: ");
                        string plate = Console.ReadLine();
                        parkingLot.AddVehicle(plate);
                        break;

                    case "2":
                        parkingLot.ListVehicles();
                        break;

                    case "3":
                        Console.Write("Enter the plate of the vehicle to remove: ");
                        string plateToRemove = Console.ReadLine();
                        parkingLot.RemoveVehicle(plateToRemove);
                        break;

                    case "0":
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

            } while (option != "0");
        }
    }
}