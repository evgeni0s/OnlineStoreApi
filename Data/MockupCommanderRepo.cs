using OnlineSiteApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStoreApi.Data
{
    public class MockupCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>() {
            new Command() { Id = 0, HowTo = "Boil an egg", Line="boil watter", Platform="Kattle & Penn" },
            new Command() { Id = 0, HowTo = "Cut bread", Line="Get a knife", Platform="knife & chopping board" },
            new Command() { Id = 0, HowTo = "Make a cup of tea", Line="Place tea in watter", Platform="Cup & Kettle" },
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return GetAppCommands().FirstOrDefault(command => command.Id == id);
        }
    }
}
