using System;

namespace Composition1.Entities
{
    class Department
    {
        public String Name { get; set; }

        public Department()
        {
        }

        public Department(string name)
        {
            Name = name;
        }
    }
}
