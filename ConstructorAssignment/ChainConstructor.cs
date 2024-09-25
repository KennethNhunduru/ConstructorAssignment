using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class ChainConstructor
    {
        //A constructor in C# is a special method in a class that is called when object of that class is created.
        //Multiple constructors can be defined within the same class and the constructors can be overloaded in the same way method are.

        //Assume this ChainConstructor that can be instantiated with the two parameters (or properties),
        //chainpara1 and chainpara2 provided or with only the parameter chainpara1 and the second parameter
        //chainpara2 given a default value of, say, "Event".
        
        //The two constructors can be overloaded in the normal way, but this results in DUPLICATE CODE.
        //CHAINING the construcors allows the overloading of the constructors without duplicating the code (DRY!).

        public ChainConstructor(string chainpara1) : this(chainpara1, "Event") 
        {

        }
        public ChainConstructor(string chainpara1, string chainpara2)
        {
            this.chainpara1 = chainpara1;
            this.chainpara2 = chainpara2;
        }

        public string chainpara1 { get; set; }
        public string chainpara2 { get; set; }
       
        //Here the first constructor takes the one parameter (chainpara1) and using thekeyword "this",
        //references the second constructor that takes two parameters (chainpara1 and chainpara2) and passes
        //the parameter it received as well as the default value for the second parameter.

        //Notice how the constructor has to have the same name as the class so the compiler can recognise
        //it as a constructor.

        //The constructor has to be placed at the top of the class before the properties.
    }
}
