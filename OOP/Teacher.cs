using OOP.Webinar.Pactics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Teacher : Person
    {
        protected override void GeneratedId()
        {
            Id = "T-" + new Random(DateTime.Today.Year).Next();
        }
    }
}
