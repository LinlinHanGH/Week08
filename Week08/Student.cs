using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08
{
    /// <summary>
    /// This is student class
    /// </summary>
    public class Student : Person
    {
        //PRIVATE　
        private string _studentID;

        public string StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                _studentID = value;
            }
        }

        // CONSTRUCORS----------------------------------------------
        /// <summary>
        /// This is the constuctor for the student class.
        /// It takes three arguments 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public Student(string name, int age, string studentID)
            :base(name, age)
        {
            this.StudentID = studentID;

        }

        //PUBLIC METHODS------------------------------------------------
        /// <summary>
        /// This is the study method. Takes no arguments
        /// </summary>

        public void Studies()
        {
            Console.WriteLine(this.Name+ "is studying!");
        }
    }
}
