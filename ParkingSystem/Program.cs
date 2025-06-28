namespace ParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PARKING SYSTEM");
            string option;
            Console.WriteLine("Set the initial value:");
            string inputInitial = Console.ReadLine();

            if (!decimal.TryParse(inputInitial, out decimal initialPrice))
            {
                Console.WriteLine("Invalid input for initial value.");
                return;
            }

            Console.WriteLine("Enter the value of additional hours:");
            string inputHourly = Console.ReadLine();

            if (!decimal.TryParse(inputHourly, out decimal hourlyRate))
            {
                Console.WriteLine("Invalid input for hourly rate.");
                return;
            }

            ParkingLot parkingLot = new ParkingLot(initialPrice, hourlyRate);

            do
            {
                Console.Clear();
                Console.WriteLine("PARKING SYSTEM");
                Console.WriteLine($"Initial price: R$ {initialPrice}");
                Console.WriteLine($"Hourly rate: R$ {hourlyRate}");
                Console.WriteLine();
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