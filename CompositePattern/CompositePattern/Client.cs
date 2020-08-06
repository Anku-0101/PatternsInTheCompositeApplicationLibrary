using System;

/// <summary>
/// *Composite Design Pattern*
/// Composite pattern is a partitioning design pattern and describes a 
/// group of objects that is treated the same way as a single instance 
/// of the same type of object. The intent of a composite is to “compose” 
/// objects into tree structures to represent part-whole hierarchies. 
/// It allows us to have a tree structure and ask each node in the tree 
/// structure to perform a task.
/// </summary>
namespace CompositePattern
{
    /// <summary>
    /// *The Composite Pattern has four participants:*
    /// 
    /// 1. Component – Component declares the interface for objects in the 
    /// composition and for accessing and managing its child components. 
    /// It also implements default behavior for the interface common to all 
    /// classes as appropriate.
    /// 
    /// 2. Leaf – Leaf defines behavior for primitive objects in the composition.
    /// It represents leaf objects in the composition.
    ///
    /// 3. Composite – Composite stores child components and implements child 
    /// related operations in the component interface.
    /// 
    /// 4. Client – Client manipulates the objects in the composition through 
    /// the component interface.
    /// </summary>
    class Client
    {
        static void Main(string[] args)
        {
            Developer dev1 = new Developer(100, "Aman Kumar", "Pro Developer");
            Developer dev2 = new Developer(101, "Vinay Sharma", "Developer");
            
            CompanyDirectory engDirectory = new CompanyDirectory();
            engDirectory.AddEmployee(dev1);
            engDirectory.AddEmployee(dev2);

            Manager man1 = new Manager(200, "Kushagra Garg", "SEO Manager");
            Manager man2 = new Manager(201, "Vikram Sharma", "Kushagra's Manager");

            CompanyDirectory accDirectory = new CompanyDirectory();
            accDirectory.AddEmployee(man1);
            accDirectory.AddEmployee(man2);

            CompanyDirectory directory = new CompanyDirectory();
            directory.AddEmployee(engDirectory);
            directory.AddEmployee(accDirectory);
            
            directory.ShowEmployeeDetails();
        }
    }
}
