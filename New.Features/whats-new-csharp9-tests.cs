using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace New.Features
{
    [TestClass]
    //C# 9.0 is supported on .NET 5
    //https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9
    public class WhatsNewCsharp9Tests 
    {
        private List<WeatherObservation> _observations = new();

        [TestInitialize]
        public void InitialSetup()
        {
            Console.WriteLine("Hello World!");


        }

        public record Person(string FirstName, string LastName, string[] PhoneNumbers);
        public record Person2(string FirstName, string LastName)
        {
            public string[] PhoneNumbers { get; init; }
        }

        [TestMethod]
        public async Task Record_ValueEquality_Test()
        {
            var phoneNumbers = new string[2];
            Person person1 = new("Nancy", "Davolio", phoneNumbers);
            Person person2 = new("Nancy", "Davolio", phoneNumbers);
            Console.WriteLine(person1 == person2); // output: True

            person1.PhoneNumbers[0] = "555-1234";
            Console.WriteLine(person1 == person2); // output: True

            Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
        }

        [TestMethod]
        public async Task Record_NondestructiveMutation_Test()
        {
            Person2 person1 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
            Console.WriteLine(person1);
            // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

            Person2 person2 = person1 with { FirstName = "John" };
            Console.WriteLine(person2);
            // output: Person { FirstName = John, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { PhoneNumbers = new string[1] };
            Console.WriteLine(person2);
            // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { };
            Console.WriteLine(person1 == person2); // output: True
        }


        public abstract record Person3(string FirstName, string LastName);
        public record Teacher(string FirstName, string LastName, int Grade): Person3(FirstName, LastName);
        public record Student(string FirstName, string LastName, int Grade): Person3(FirstName, LastName);
        public async Task Record_Inheritance_Test()
        {
            Person3 teacher = new Teacher("Nancy", "Davolio", 3);
            Person3 student = new Student("Nancy", "Davolio", 3);
            Console.WriteLine(teacher == student); // output: False

            Student student2 = new Student("Nancy", "Davolio", 3);
            Console.WriteLine(student2 == student); // output: True
        }


        [TestMethod]
        public async Task InitOnlySettersTest()
        {
            var now = new WeatherObservation
            {
                RecordedAt = DateTime.Now,
                TemperatureInCelsius = 20,
                PressureInMillibars = 998.0m
            };

            // Error! CS8852.
            //now.TemperatureInCelsius = 18;
        }



        [TestMethod]
        public async Task FitandfinishfeaturesTest()
        {
            List<WeatherObservation> observations = new();
            var forecast = ForecastFor(DateTime.Now.AddDays(2), new());

            WeatherObservation station = new() { Location = "Seattle, WA" };

        }

        public WeatherObservation ForecastFor(DateTime forecastDate, WeatherForecastOptions options)
        {
            return new();
        }

    }

    public class WeatherForecastOptions
    {

    }

    public struct WeatherObservation
    {
        public DateTime RecordedAt { get; init; }
        public string Location { get; init; }
        public decimal TemperatureInCelsius { get; init; }
        public decimal PressureInMillibars { get; init; }

        public override string ToString() =>
            $"At {RecordedAt:h:mm tt} on {RecordedAt:M/d/yyyy}: " +
            $"Temp = {TemperatureInCelsius}, with {PressureInMillibars} pressure";
    }

}