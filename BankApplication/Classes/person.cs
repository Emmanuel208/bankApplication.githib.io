using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Classes
{
    class person
    {
        public person(string fisrtName, string lastName, string pin)
        {
            this.fisrtName = fisrtName;
            this.lastName = lastName;
            this.pin = pin;
        }

        public string fisrtName { get; set; }
        public string lastName { get; set; }

        public string pin { get; set; }
    }
}
