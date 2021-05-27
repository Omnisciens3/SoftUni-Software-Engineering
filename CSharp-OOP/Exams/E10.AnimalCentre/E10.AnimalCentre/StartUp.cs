using E10.AnimalCentre.Commands;
using E10.AnimalCentre.Core;
using E10.AnimalCentre.Factories;
using E10.AnimalCentre.IO;
using E10.AnimalCentre.Models.Entities;
using System;

namespace E10.AnimalCentre
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var hotel = new Hotel();
            var animalFactory = new AnimalFactory();
            var procedureFactory = new ProcedureFactory();

            AnimalCentree animalCentre = new AnimalCentree(hotel, animalFactory, procedureFactory);

            var commandParser = new CommandParser();
            var dataWriter = new ConsoleDataWriter();
            var dataReader = new ConsoleDataReader();

            var engine = new Engine(
                animalCentre,
                commandParser,
                dataReader,
                dataWriter);

            engine.Run();
        }
    }
}
