using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data; //много е важно, когато ни е описано винаги да направим private field.

        public Clinic(int capacity)
        {
            Capacity = capacity;
            data = new List<Pet>(); //initialize the data with a new instance of the collection. 
        }

        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }

        public void Add(Pet pet)
        {
            if (data.Count < Capacity)  //adds an entity to the data if there is an empty cell for the pet.
            {
                data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet pet = data.FirstOrDefault(p => p.Name == name);

            if (pet == null) //FirstOrDefault връща null по default, затова проверяваме дали пет == нъл;
            {
                return false;
            }

            data.Remove(pet);
            return true;
        }

        public Pet GetPet(string name, string owner)
        {
            Pet pet = data.FirstOrDefault(p => p.Name == name && p.Owner == owner);

            return pet;
        }

        public Pet GetOldestPet()
        {
            return data.OrderByDescending(a => a.Age).FirstOrDefault(); //FirstOrDefault ще върне null, ако нямаме елементи в колекцията, затова използваме него.
        }

        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("The clinic has the following patients:");

            foreach (var pet in data)
            {
                result.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return result.ToString();
        }
    }
}
