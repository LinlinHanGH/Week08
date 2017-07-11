using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08
{ 
    /// <summary>
    /// This is the Person Super Class
    /// </summary>
    public class Person
    {
        //PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _name;
        private int _age;

        //PUBLIC PROPERTIES-------------------------------------------
        public string Name {
            get
            {
                return this._name;
            }
            set
            {
                _name = value;
            }
        }
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                _age = value;
            }
        }
        //CONSTRUCTOR-------------------
        /// <summary>
        /// This is the Constructor for the Person class. 
        /// The constuctor returns two arguments - name (string) and age (int).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;

        }

        //PUBLIC METHODS---------------------
        /// <summary>
        /// This method enables the person to talk
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this.Name+"is talking!");
        }

    }
}
