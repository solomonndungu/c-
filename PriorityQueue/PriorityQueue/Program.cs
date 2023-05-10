using System;
using System.Collections.Generic;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<string, int> vehicleRepairQueue = new PriorityQueue<string, int>();

            vehicleRepairQueue.Enqueue("Mirror Damaged Car", 3);
            vehicleRepairQueue.Enqueue("Wash Car", 10);
            vehicleRepairQueue.Enqueue("Severe Damaged Car", 1);

            Console.WriteLine("\nVehicle Repair Queue:\n");

            while (vehicleRepairQueue.Count > 0)
            {
                Console.WriteLine(vehicleRepairQueue.Dequeue());
            }

            Console.WriteLine("\nVehicle Service Queue:\n");
            vehicleRepairQueue.Enqueue("General Service Sedan Car", 5);

            var lastDequeue = vehicleRepairQueue.EnqueueDequeue("General Service Suv Car", 7);
            Console.WriteLine(lastDequeue);

            var severeDamagedVehicles = new List<string>
            {
                "Car Damaged Sedan",
                "Car Damaged SUV",
                "Car Damaged Hatchback"
            };

            vehicleRepairQueue.EnqueueRange(severeDamagedVehicles, 1);
            Console.WriteLine("\nVehicle Bulk Damage Queue:\n");

            while(vehicleRepairQueue.Count > 0)
            {
                Console.WriteLine(vehicleRepairQueue.Dequeue());
            }
            Console.WriteLine("\nBulk Service Queue:\n");

            var bulkServiceVehiclesRequest = new List<(string, int)>
            {
                ("Tyre Change Request 1", 3),
                ("Tyre Change Request 2", 3),
                ("Tyre Change Request 3", 3),
                ("Tyre Change Request 4", 3),
                ("Severe Damaged Car", 1)
            };
            vehicleRepairQueue.EnqueueRange(bulkServiceVehiclesRequest);

            while(vehicleRepairQueue.Count > 0)
            {
                Console.WriteLine(vehicleRepairQueue.Dequeue());
            }
        }
    }
}