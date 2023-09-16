using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Abstract_Interface
{
    using System;

    // Define an abstract interface for the locker
    public interface ISecureLocker
    {
        void StoreMoney(decimal amount);
        void StoreJewelry(string jewelry);
        void SetPinCode(string pinCode);
    }

    // Implement the abstract interface with a concrete class
    public class Locker : ISecureLocker
    {
        // Private fields to store the contents of the locker
        private decimal money;
        private string jewelry;
        private string pinCode;

        // Constructor to initialize the locker
        public Locker()
        {
            money = 0;
            jewelry = string.Empty;
            pinCode = string.Empty;
        }

        // Store money in the locker (private access)
        public void StoreMoney(decimal amount)
        {
            money += amount;
            Console.WriteLine($"Money stored in the locker: ${amount}");
        }

        // Store jewelry in the locker (private access)
        public void StoreJewelry(string jewelryItem)
        {
            jewelry += jewelryItem;
            Console.WriteLine($"Jewelry stored in the locker: {jewelryItem}");
        }

        // Set the PIN code for the locker (private access)
        public void SetPinCode(string newPinCode)
        {
            pinCode = newPinCode;
            Console.WriteLine($"PIN code set for the locker: {newPinCode}");
        }

        // Private method to retrieve the PIN code (not accessible outside)
        private string GetPinCode()
        {
            return pinCode;
        }
    }

    class Locker1
    {
        static void Main(string[] args)
        {
            // Create a locker
            ISecureLocker locker = new Locker();

            // Store contents in the locker
            locker.StoreMoney(1000);
            locker.StoreJewelry("Diamond ring");
            locker.SetPinCode("1234");

            
        }
    }

}
