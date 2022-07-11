using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace New.Features
{
    [TestClass]
    //C# 6.0 is supported on .NET .
    //https://www.codeproject.com/Articles/808732/Briefly-exploring-Csharp-new-features
    public class WhatsNewCsharp6Tests
    {
        //Auto property initializer
        public string FirstName { get; set; } = "Hassan";


        [TestInitialize]
        public void InitialSetup()
        {

        }


        [TestMethod]
        public async Task AwaitInCatchAndFinallyBlockTest()
        {
            try
            {
                Console.WriteLine("AAAAA") ;
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
            }
        }


        [TestMethod]
        public async Task DeclarationExpressionsTest()
        {
            string Id = "11";
            //long id;
            //if (!long.TryParse(Id, out id))
            if (!long.TryParse(Id, out long id))
            { 
            
            }
        }


        [TestMethod]
        public async Task DictionaryInitializerTest()
        {
            // the old way of initializing a dictionary
            Dictionary<string, string> oldWay = new Dictionary<string, string>()
                {
                    { "Afghanistan", "Kabul" },
                    { "United States", "Washington" },
                    { "Some Country", "Some Capital city" }
                };

            // new way of initializing a dictionary
            Dictionary<string, string> newWay = new Dictionary<string, string>()
            {
                // Look at this!
                ["Afghanistan"] = "Kabul",
                ["Iran"] = "Tehran",
                ["India"] = "Delhi"
            };
        }




    }

}