using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week08
{
    public class DemosticStudent :Student
    {
        public string DomesticAddress
        {

            get; set;
        }

        public DemosticStudent(string name, int age, string studentID)
            :base(name, age, studentID)
            {
            this.DomesticAddress = "Unknown";
        }

    }
}