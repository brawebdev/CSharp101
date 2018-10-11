using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NOTES: Interfaces
//What do you all know about interfaces?
    //Start with I
        //Sometimes frowned upon in Java
        //Encouraged in C# as a convention
    //Commonly end with -able suffix
    //Forms a contract with a class

    //Why use?
        //Dependency Injection
            //Helps with Unit Testing
        //Coding at the big picture level
        //Coding with intent
    //Forming shapes on a class

namespace _00_General_Concepts
{
    //-- Generics Demo
    interface ICrudRepository<T, TT>
    {
        bool Create(T foo);
        void Read();
        bool Update();
        bool Delete();
        TT GetAll();
    }
}
