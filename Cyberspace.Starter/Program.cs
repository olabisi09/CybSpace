using System;


namespace Cyberspace.Starter
{
    public interface IConvertible
    {
        public string ConvertToCSharp(string val);
        public string ConvertToVB2005(string val);
    }

    public class ProgramHelper : ProgramConverter, IOtherInterface
    {
        public bool CodeCheckSyntax(string stringToCheck, string langToUse)
        {
            if (langToUse == "CSharp")
            {
                Console.WriteLine($"Check if the string '{stringToCheck}' is in C#.".ToString());
                return true;
            }
            else if (langToUse == "VB2005")
            {
                Console.WriteLine($"Check if the string '{stringToCheck}' is in VB2005.");
                return true;
            }

            return false;
        }
    }


    //public interface ICompress
    //{
    //    void Write();
    //}
    //public interface IStore:ICompress
    //{
    //    void Write();
    //}

    //public class StoreCompress : IStore 
    //{
    //    public void Write()
    //    {

    //    }

    //    void ICompress.Write()
    //    {

    //    }
    //}

    ////public class ProgramA { }

    ////public abstract class ProgramB : ProgramA { }

    public interface IOtherInterface : IConvertible
    {
        public bool CodeCheckSyntax(string stringToCheck, string langToUse);
    }

    public class ProgramConverter : IConvertible
    {
        public string ConvertToCSharp(string val)
        {
            return $"{val} converted to C#";
        }

        public string ConvertToVB2005(string val)
        {
            return $"{val} converted to VB 2005";
        }
    }

    

    public class Program
    {
        public static void Main()
        {
            ProgramHelper programHelper = new ProgramHelper();
            string cSharpString = programHelper.ConvertToCSharp("Some string");
            string vbString = programHelper.ConvertToVB2005("Other string");

            //Implementing Exercise 13-2 and 13-3
            Console.WriteLine(cSharpString);
            Console.WriteLine(vbString);

            programHelper.CodeCheckSyntax(cSharpString, "CSharp");
            programHelper.CodeCheckSyntax(vbString, "VB2005");

            //Testing the is and as keywords
            ProgramConverter[] programConverters = new ProgramConverter[2];
            programConverters[0] = new ProgramConverter();
            programConverters[1] = new ProgramHelper();

            //Demonstrating the 'is' keyword
            for (int i = 0; i < programConverters.Length; i++)
            {
                Console.WriteLine(programConverters[i] is ProgramHelper);
            }

            //Demonstrating the 'as' keyword
            for (int i = 0; i < programConverters.Length; i++)
            {
                ProgramHelper ph = programConverters[i] as ProgramHelper;
                if (ph != null)
                {
                    ph.CodeCheckSyntax(vbString, "VB2005");
                }
                else Console.WriteLine("Not VB syntax");

                if(ph != null)
                {
                    ph.CodeCheckSyntax(cSharpString, "CSharp");
                }
                else Console.WriteLine("Not C# syntax");

                
            } 

        }
        
    }

}


//Question 131: An interface defines or declares the methods, fields and properties that the
//class will then implement.

//Question 132: An abstract base class can only be inherited by an abstract class,
//and all of them must be inherited.

//Question 133: class NameOfClass : MyBase, ISuppose, IDo{}

//Question 134: is and as operators

//Question 135: the 'is' operator compares two types to determine if they are compatible.
//If they are not, false is returned. The 'as' operator is casting from one type to another.
//If the types are not compatible, null is returned, otherwise the resultant object type is returned.

//Question 136: An interface extends another interface by implementing its properties and
//methods, and can also add its own.

//Question 137: interface MyInterface : AnotherInterface {}

//Question 138: When an interface extends another and implements a method in the parent
//
//it, then they can be overridden in derived classes.

//Question 139: This is implementing an interface by writing its name along with its methods.
//This is to avoid confusion with methods in different interfaces with the same signatures.
