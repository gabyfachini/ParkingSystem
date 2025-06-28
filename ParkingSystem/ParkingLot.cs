namespace ParkingSystem
{
    public class ParkingLot
    {
        private decimal InitialPrice { get; set; }
        private decimal HourlyRate { get; set; }
        private List<string> Vehicles;

        public ParkingLot(decimal initialPrice, decimal hourlyRate)
        {
            InitialPrice = initialPrice;
            HourlyRate = hourlyRate;
            Vehicles = new List<string>();
        }

        public void AddVehicle(string plate)
        {
            if (string.IsNullOrWhiteSpace(plate))
            {
                Console.WriteLine("Invalid plate.");
                return;
            }

            Vehicles.Add(plate.ToUpper());
            Console.WriteLine($"Vehicle with plate {plate.ToUpper()} added.");
        }

        public void ListVehicles()
        {
            if (Vehicles.Any())
            {
                Console.WriteLine("Parked vehicles:");
                foreach (var vehicle in Vehicles)
                {
                    Console.WriteLine($"- {vehicle}");
                }
            }
            else
            {
                Console.WriteLine("There are no parked vehicles.");
            }
        }

        public void RemoveVehicle(string plate)
        {
            string formattedPlate = plate.ToUpper();

            if (Vehicles.Contains(formattedPlate))
            {
                Console.Write("Enter the number of hours the vehicle was parked: ");
                if (int.TryParse(Console.ReadLine(), out int hours))
                {
                    decimal totalPrice = InitialPrice + (HourlyRate * Math.Max(hours - 1, 0));
                    Vehicles.Remove(formattedPlate);
                    Console.WriteLine($"Vehicle {formattedPlate} removed.");
                    Console.WriteLine($"Total price: ${totalPrice:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid number of hours.");
                }
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
        }
    }
}
