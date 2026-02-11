using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace MyMonkeyApp
{
    /// Static helper class to manage Monkey data
    internal static class MonkeyHelper
    {


        static List<Monkey> monkeys = new List<Monkey>();

          
      static MonkeyHelper()
        {

          

            monkeys.Add(new Monkey("Cebus", "capucinus"));
            monkeys.Add(new Monkey("Cebus", "apella"));
            monkeys.Add(new Monkey("Cebus", "albifrons"));
            monkeys.Add(new Monkey("Saimiri", "sciureus"));
            monkeys.Add(new Monkey("Saimiri", "boliviensis"));
            monkeys.Add(new Monkey("Ateles", "geoffroyi"));
            monkeys.Add(new Monkey("Ateles", "belzebuth"));

        }


     //  Returns all monkeys

        static public string GetMonkeys()
        {

         
            var result = monkeys.Select(m => $"{m.Species} {m.Name}").ToList();

            return string.Join("\n", result);
        }



        /// Finds a monkey by its name
        static public string GetMonkeyByName(string name)
        {


            var foundMonkeys = monkeys.Where(n => n.Name == name);
            var result = foundMonkeys.Select(m => $"{m.Name}").ToList();

            return string.Join("\n", result);
            
        }


     
        /// Returns a random monkey from the list
        

        static Random random = new Random();
        static public string GetRandomMonkey()
        {

             int index = random.Next(0, monkeys.Count);
             Monkey specificMonkey = monkeys[index];
             string result = $"{specificMonkey.Species} - {specificMonkey.Name}";
           
          
            return result;
        }
    }
}
