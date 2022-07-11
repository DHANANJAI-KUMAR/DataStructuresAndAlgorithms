using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace New.Features
{
    [TestClass]
    //C# 7.0 is supported on .NET .
    //https://www.codeproject.com/Articles/1156167/Csharp-Version-7-Introduction-to-New-Language-Feat
    public class WhatsNewCsharp7Tests
    {

        [TestInitialize]
        public void InitialSetup()
        {

        }


        [TestMethod]
        public async Task BinaryLiteralsFeatureTest()
        {
            //int employeeNumber = 34;      // integer literal constant
            float passPercentage = 34.0f; // float literal constant
            int employeeAge = 0x22;       // hexadecimal literal which is equivalent of 
                                          // decimal number 34

            var employeeNumber = 0b00100010;   // binary equivalent of whole number 34. 
                                               // Underlying data type defaults to System.Int32
            Console.WriteLine(employeeNumber); // prints 34 on console.
            long empNumberWithLongBackingType = 0b00100010;      // here backing data type is long 
                                                                 // (System.Int64)
            Console.WriteLine(empNumberWithLongBackingType);     // prints 34 on console.
            int employeeNumber_WithCapitalPrefix = 0B00100010;   // 0b and 0B prefixes are equivalent.
            Console.WriteLine(employeeNumber_WithCapitalPrefix); // prints 34 on console.
                                                                 //
        }


        [TestMethod]
        public async Task DigitSeparatorsFeatureTest()
        {
            // underscores coming in between the numbers have no impact 
            // on the underlying value being stored
            // it is simply to improve readability for long literal numerical values.
            int largeNaturalNumber = 345_2_45;
            int largeNaturalNumber_oldFormat = 345245;     // same as above
            long largeWholeNumber = 1_2_3_4___5_6_7_8_0_10;
            long largeWholeNumber_oldFormat = 12345678010; // same as above
            int employeeNumber = 0b0010_0010;              // specially useful in binary equivalents

            
            //here are few restrictions though while using digit separators:
            //Underscore can't appear at the start of the number.
            //Underscore can't appear before decimal point.
            //Underscore can't appear after exponential sign.
            //Underscore can't appear before type specifier suffix.

        }


        [TestMethod]
        public async Task TupleDataTypeNowAvailableasValueTypeTest()
        {
            Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(1, "cat", true);
            /*Console prints
             1
             cat
             true
             */
            Console.WriteLine(tuple.Item1); // compile creates public properties 
                                            // using a "Item" series based naming convention
            Console.WriteLine(tuple.Item2); // Item1, Item2 and Item3 properties start appearing 
                                            // in intellisense magically
            Console.WriteLine(tuple.Item3);


        }

        //[TestMethod]
        //public void TupleValueTypeLiterals()
        //{
        //    //Using System.Value.Tuple

        //    // types of struct members are automatically inferred by the compiler as string, string
        //    var genders = ("Male", "Female");
        //    Console.WriteLine("Possible genders in human race are : {0} and {1} ", genders.Item1, genders.Item2);
        //    Console.WriteLine($"Possible genders in human race are { genders.Item1}, { genders.Item2}.");

        //    // to override the default named Tuple public properties Item1 and Item2
        //    var geoLocation = new(double latitude, double longitude){ latitude = 124, longitude = 23 };
        //    Console.WriteLine("Geographical location is : {0} , {1} ", geoLocation.longitude, geoLocation.latitude);

        //    // hetrogeneous data types are also possible in tuple
        //    var employeeDetail = ("Michael", 33, true); //(string,int,bool)
        //    Console.WriteLine("Details of employee are Name: {0}, Age : {1},  IsPermanent: { 2}", employeeDetail.Item1, employeeDetail.Item2, employeeDetail.Item3);

        //    // a reference type object can also be present as tuple member
        //    var employeeRecord = new(Employee emp, int Id) { emp = new Employee { FirstName = "Foo", LastName = "Bar" }, Id = 1 };
        //    Console.WriteLine("Employee details are - Id: {0}, First Name: {1}, Last Name: { 2}", employeeRecord.Id, employeeRecord.emp.FirstName, employeeRecord.emp.LastName);
        //}

        [TestMethod]
        public void TupleValueTypeLiteralsTest()
        {
            // Some code has been removed for brevity. 
            // Please download attached code for complete reference.
            var geographicalCoordinates = ReturnMultipleValuesFromAFunction("London");
            Console.WriteLine(geographicalCoordinates.longitude);
            Console.WriteLine(geographicalCoordinates.Item1); //prints same as longitude
            Console.WriteLine(geographicalCoordinates.latitude);
            Console.WriteLine(geographicalCoordinates.Item2); //print same as latitude
        }


        [TestMethod]
        public void LocalFunctionsFeatureTest()
        {
            // This function is not visible to any other function in this classs.
            string GetAgeGroup(int age)
            {
                if (age < 10)
                    return "Child";
                else if (age < 50)
                    return "Adult";
                else
                    return "Old";
            }

            Console.WriteLine("My age group is {0}", GetAgeGroup(33));
        }

        [TestMethod]
        public void RefReturnsandRefLocalsTest()
        {
            // Some code has been removed for brevity. 
            // Please download the attached code for complete reference
            Console.WriteLine("******Passing arguments by reference*********");
            string empName = "Foo";
            UpdateEmployeeName(ref empName);
            Console.WriteLine(empName);//prints Bar


            // Some code has been removed for brevity. 
            // Please download the attached code for complete reference
            Console.WriteLine("******ref locals and ref returns*********");
            int x = 10, y = 20;
            // After completion of the function, newEmpNumber is actually an alias to variable y
            ref var newEmpNumber = ref GetBiggerNumber(ref x, ref y);
            // Now I'm actually incrementing y by below statement through newEmpNumber 
            // which is referring to y only
            newEmpNumber += 20;
            Console.WriteLine(y); //in reality y got incremented to 20 + 20 = 40
        }

        

        [TestMethod]
        public void PatternMatchingforTypes()
        {
            Console.WriteLine("******Pattern matching with Types*********");
            // Prints nothing on console because of constant pattern matching inside the function call
            PatternMatchingFeatureWithTypes(2147483647);

            // Prints nothing on console because of constant pattern matching inside the function call
            PatternMatchingFeatureWithTypes(null);

            // Prints nothing on console because of type pattern mismatch inside the function call
            PatternMatchingFeatureWithTypes(5D);

            // Prints five asterisks on console because of type pattern matching inside the function call
            // Also prints a message on console because of var pattern matching  inside the function call
            PatternMatchingFeatureWithTypes(5);
            
            // Some code has been removed for brevity.
            // Please download the attached code for complete reference.
            Console.WriteLine("******Type Pattern matching in switch-case*********");
            var circleShape = new Circle();
            circleShape.Radius = 5;
            PatternMatchingFeatureWithSwitchCase(circleShape);
            var squareShape = new Rectangle();
            squareShape.Length = 10;
            squareShape.Width = 10;
            PatternMatchingFeatureWithSwitchCase(squareShape);
        }

        private void PatternMatchingFeatureWithTypes(object input)
        {
            // constant pattern "int.MaxValue"
            if (input is int.MaxValue)
            {
                return;
            }

            // constant pattern "null"
            if (input is null)
                return;

            // type pattern "int i"
            if (!(input is int i))
                return;

            // Since type pattern got satisfied above, variable i 
            // gets the value present in input parameter.
            Console.WriteLine(new string('*', i));

            // var pattern gets always satisfied for any type
            if (input is var v)
            {
                Console.WriteLine("var pattern will always have a match.");
            }
        }

        private void PatternMatchingFeatureWithSwitchCase(object input)
        {
            var shape = input as Shape;
            if (shape != null)
            {
                switch (shape)
                {
                    // use of type pattern
                    case Circle c:
                        // if case gets satisfied, then c actually starts to act
                        // as a variable which will get assigned the value of input variable
                        // after appropriate casting.
                        Console.WriteLine($"circle with radius {c.Radius}");
                        break;
                    case Rectangle s when (s.Length == s.Width): //when is a new keyword in C#
                        Console.WriteLine($"{s.Length} x {s.Width} square");
                        break;
                    case Rectangle r:
                        Console.WriteLine($"{r.Length} x {r.Width} rectangle");
                        break;
                    default:
                        Console.WriteLine("<unknown shape>");
                        break;
                    case null: // use of constant null pattern
                        throw new ArgumentNullException(nameof(shape));
                }
            }
        }

        private (double longitude, double latitude) ReturnMultipleValuesFromAFunction(string nameOfPlace)
        {
            var geoLocation = (0D, 0D);
            switch (nameOfPlace)
            {
                case "London":
                    geoLocation = (24.9277, 84.1910);
                    break;
                default:
                    break;
            }
            return geoLocation;
        }

        private ref int GetBiggerNumber(ref int num1, ref int num2)
        {
            // How to declare a ref local variable. 
            // Not really needed for the logic of this function
            ref int localVariable = ref num1;
            // You are not returning a value but a reference.
            if (num1 > num2)
                return ref num1;
            else
                return ref num2;
        }

        private void UpdateEmployeeName(ref string empName)
        {
            // This change will impact the variable in caller function which has
            // been passed by reference.
            empName = "Bar";
        }


    }


    class Shape
    {

    }

    class Circle : Shape
    {
        public int Radius
        {
            get;
            set;
        }
    }

    class Rectangle : Shape
    {
        public int Length
        {
            get;
            set;
        }

        public int Width
        {
            get;
            set;
        }
    }


}

