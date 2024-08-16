using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AresCampsWinForms.src
{
    internal class Trainer
    {
        List<Person> persons = new List<Person>();
        public List<Person> Persons { get { return persons; } set{ persons = value; } }
        public string Name { get; set; }
        public double Salary { get; set; }

    }
}
