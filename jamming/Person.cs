using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jamming
{
    public interface IlegalInformation
    {
        public int DNI { get; set; }
        public DateTime Birthday { get; set; }
    }
    public class Person : IlegalInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int DNI { get; set; }

        public DateTime Birthday { get; set; }

        public Person(string _FirstName, string _LastName, int _DNI, DateTime _Birthday)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            DNI = _DNI;
            Birthday = _Birthday;
        }
    }
}
