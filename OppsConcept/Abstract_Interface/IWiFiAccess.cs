using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Abstract_Interface
{
   

    // Define an abstract interface for Wi-Fi access
    public interface IWiFiAccess
    {
        void ConnectInsideRoom();
        void DisconnectInsideRoom();
        void ConnectFromAdjacentRoom();
        void DisconnectFromAdjacentRoom();
    }

    // Implement the abstract interface with a concrete class
    public class WiFiAccessPoint : IWiFiAccess
    {
        // Protected constructor to restrict direct instantiation
        protected WiFiAccessPoint()
        {
            // Private constructor
        }

        // Factory method to create a Wi-Fi access point
        public static WiFiAccessPoint CreateWiFiAccessPoint()
        {
            return new WiFiAccessPoint();
        }

        // Connect to Wi-Fi inside the room (accessible to employees)
        public void ConnectInsideRoom()
        {
            Console.WriteLine("Connected to Wi-Fi inside the room.");
        }

        // Disconnect from Wi-Fi inside the room (accessible to employees)
        public void DisconnectInsideRoom()
        {
            Console.WriteLine("Disconnected from Wi-Fi inside the room.");
        }

        // Connect to Wi-Fi from the adjacent room (protected for admin staff)
        public void ConnectFromAdjacentRoom()
        {
            Console.WriteLine("Connected to Wi-Fi from the adjacent room (admin staff).");
        }

        // Disconnect from Wi-Fi from the adjacent room (protected for admin staff)
        public void DisconnectFromAdjacentRoom()
        {
            Console.WriteLine("Disconnected from Wi-Fi from the adjacent room (admin staff).");
        }
    }

    // Admin staff class
    public class AdminStaff
    {
        // Method to access Wi-Fi from the adjacent room
        public void AccessWiFiFromAdjacentRoom(WiFiAccessPoint wifi)
        {
            wifi.ConnectFromAdjacentRoom();
            // Perform admin staff-specific tasks
            wifi.DisconnectFromAdjacentRoom();
        }
    }

    class Wifi
    {
        static void Main(string[] args)
        {
            // Create a Wi-Fi access point
            WiFiAccessPoint wifi = WiFiAccessPoint.CreateWiFiAccessPoint();

            // Employees inside the room can connect and disconnect
            wifi.ConnectInsideRoom();
            wifi.DisconnectInsideRoom();

            // Admin staff from the adjacent room can access Wi-Fi
            AdminStaff admin = new AdminStaff();
            admin.AccessWiFiFromAdjacentRoom(wifi);
        }
    }

}
