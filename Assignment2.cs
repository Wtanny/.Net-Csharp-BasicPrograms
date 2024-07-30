using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitAssignment
{
    internal class Assignment2: IComparable<Assignment2>
    {
            public string Name { get; private set; }
            public int Age { get; private set; }

            public Assignment2(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public void PrintDetails()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
            public int CompareTo(Assignment2 other)
            {
                if (this.Age > other.Age)
                {
                    return 1;
                }
                else if (this.Age < other.Age)

                    return -1;
                else
                    return 0;
            }
        }
    }

