using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Abstract_Interface
{
    

    // Define an abstract interface for closet access
    public interface IClosetAccess
    {
        void Open();
        void Close();
    }

    // Implement the abstract interface with a concrete class
    public class Closet : IClosetAccess
    {
        // Default constructor
        public Closet()
        {
            // Initialize the closet state (closed)
            IsOpen = false;
        }

        // Property to track the closet state
        protected bool IsOpen { get; private set; }

        // Open the closet (accessible to people inside the room)
        public void Open()
        {
            if (!IsOpen)
            {
                Console.WriteLine("Closet is now open.");
                IsOpen = true;
            }
            else
            {
                Console.WriteLine("Closet is already open.");
            }
        }

        // Close the closet (accessible to people inside the room)
        public void Close()
        {
            if (IsOpen)
            {
                Console.WriteLine("Closet is now closed.");
                IsOpen = false;
            }
            else
            {
                Console.WriteLine("Closet is already closed.");
            }
        }
    }

    // Room class where people can access the closet
    public class Room
    {
        public void AccessCloset(IClosetAccess closet)
        {
            closet.Open();
            // Perform operations inside the closet (e.g., retrieve items)
            closet.Close();
        }
    }

    class Closet1
    {
        static void Main(string[] args)
        {
            // Create a closet
            IClosetAccess closet = new Closet();

            // People inside the room can access the closet
            Room room = new Room();
            room.AccessCloset(closet);
        }
    }

}
