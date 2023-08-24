using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Methods
{
    public interface IPrintable
    {
        string Print();
    }
    
    public class User : IPrintable
    {
        public string Print()
        {
            return "user details";
        }
    }
}
