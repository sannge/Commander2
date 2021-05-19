using System.Collections.Generic;
using Commander2.Models;

namespace Commander2.Data {

    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command> {
                 new Command{Id=0, HowTo="Boil an Egg",Line="Boil Water",Platform="Kettle & Pan"},
                  new Command{Id=0, HowTo="Boil an Sausage",Line="Get a knife",Platform="Chopping Board"},
                   new Command{Id=0, HowTo="Cut Bread",Line="Eat it",Platform="Go Go"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an Egg",Line="Boil Water",Platform="Kettle & Pan"};
        }
    }
}