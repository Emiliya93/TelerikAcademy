namespace AnimalHierarchy
{
    using System;

    class HierarchyTests
    {
        static void Main()
        {
            Animal[] animals = 
            {
                new Cat("Murry", 4, 'f'),
                new Cat("Jack", 2, 'm'),
           
                new Dog("Mark", 5, 'm'),
                new Dog("Lily", 3, 'f'),
            
                new Frog("Kim", 1, 'f'),
                new Frog("Ponty", 2, 'm'),
            
                new Kitten("Merry", 1, 'f'),
                new Kitten("Terry", 1, 'f'),
           
                new Tomcat("Jack", 1, 'm'),
                new Tomcat("Jackie", 1, 'm'),
            };

        }
    }
}
