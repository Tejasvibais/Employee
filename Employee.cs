using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{

    //public
    //protected
    //internal
    //private
    //protected internal


    //A class is a UDT that is composed of field data(member variables) and methods(member functions)
    //that act on this data

    /*<class> <name-of class>{}
     * 
     */
    class sample
    {
        //fields

        public int a;
        //constructors
        //destructors
        //properties
        //methods
    }

    class Employee
    {
        public string Name;
        public int id;
        public string Gender;
        public int Salary;
        public void getData()

        {
            Console.WriteLine("Please enter employee Details");
            Console.WriteLine("Please enter Employee Name");
            Name = Console.ReadLine();

            Console.WriteLine("Please enter Employee id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Employee Salary");
            Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Employee Gender");
            Gender = Console.ReadLine();

        }
        public void PrintData()
        {
            {
                Console.WriteLine("please enter employee details");
                Console.WriteLine( Name);
                Console.WriteLine(id);
                Console.WriteLine( Salary);
                Console.WriteLine(Gender);

            }
        }

        class Class5
        {

            static void Main(string[] args)

            {
                //sample = new sample();
                //1.a = 6;

                //nsole.WriteLine(s1.a);

                //<class-name> <object-name>=new <class-Name>()

                /*ployee E = new Employee();
                     E.Name = "Tejasvi";
                     E.id = 23244;
                     E.Gender = "Female";
                     E.Salary = 30000;

                     Console.WriteLine("Eployee details are");
                     Console.WriteLine("Name of the employee is " + E.Name);
                     Console.WriteLine(" Gender" + E.Gender);
                     Console.WriteLine("Employee id is " + E.id);
                     Console.WriteLine("Employee salary is " + E.Salary);*/


                /// array of objects
                Employee[] employeeslist = new Employee[3];
                for (int i = 0; i < employeeslist.Length; i++)
                {
                    Employee E = new Employee();
                    E.getData();


                    employeeslist[i] = E;

                }
                for (int i = 0; i < employeeslist.Length; i++)
                {
                    employeeslist[i].PrintData();

                }
            }
        }
    }
}



    





    