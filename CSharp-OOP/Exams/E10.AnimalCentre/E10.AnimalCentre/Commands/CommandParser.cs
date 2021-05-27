using E10.AnimalCentre.Commands.Contracts;
using System.Linq;

namespace E10.AnimalCentre.Commands
{
    public class CommandParser : ICommandParser
    {
        public ICommand Parse(string input)
        {
            var inputParts = input.Split();
            var name = inputParts[0];
            var arguments = inputParts.Skip(1).ToArray();

            return new Command(name, arguments);
        }
    }
}
