using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LOUIE TKACIK 
//This is a demo following along how to make a class in C#
namespace PetDemo
{
    class Pet
    {
        //definte the backing fields
        private string _name;
        private string _type;
        private int _age;

        //define the properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string getData()
        {
            return  this._name+" is a " +this._type + " and is " + this._age + " years old.";

        }

        //default constructor
    //    public Pet()
   //     {
   //         _type = "";
 //           _name = "";
  //          _age = 0;
  //      }

        //Parameterized constructor
        public Pet(string n, string t, int a)
        {
            _name = n; _type = t; _age = a;
        }
    }
}
