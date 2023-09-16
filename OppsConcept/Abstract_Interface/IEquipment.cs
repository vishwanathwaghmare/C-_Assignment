using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Abstract_Interface
{
   

    // Define an interface for equipment
    public interface IEquipment
    {
        void Fill();
        void Mix();
    }

    // Define a class Cement_mixer that implements IEquipment
    public class Cement_mixer : IEquipment
    {
        // Implement the Fill method
        public void Fill()
        {
            Console.WriteLine("Cement mixer is filled.");
        }

        // Implement the Mix method
        public void Mix()
        {
            Console.WriteLine("Cement is mixed.");
        }

        // Additional method for pouring
        public void Pour()
        {
            Console.WriteLine("Cement is poured.");
        }
    }

    class Equipment1
    {
        static void Main(string[] args)
        {
            // a. Create an object of type Cement_mixer and call its fill, mix, and pour methods.
            Cement_mixer mixer1 = new Cement_mixer();
            mixer1.Fill();
            mixer1.Mix();
            mixer1.Pour();

            // b. Create an object of type Cement_mixer with a reference variable of IEquipment.
            IEquipment e = new Cement_mixer();

            // Check the methods available to e using the interface.
            e.Fill();
            e.Mix();

            
        }
    }

}
