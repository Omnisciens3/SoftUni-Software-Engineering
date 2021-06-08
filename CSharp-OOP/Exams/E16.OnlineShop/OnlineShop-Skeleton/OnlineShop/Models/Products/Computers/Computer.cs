using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private List<IComponent> components;
        private List<IPeripheral> peripherals;

        protected Computer(
            int id, 
            string manufacturer, 
            string model, 
            decimal price, 
            double overallPerformance) 
            : base(id, manufacturer, model, price, overallPerformance)
        {
        }

        public override double OverallPerformance 
            => components.Count == 0 ? base.OverallPerformance : components.Average(x => x.OverallPerformance) + base.OverallPerformance;

        public override decimal Price => base.Price + components.Sum(x => x.Price) + peripherals.Sum(x => x.Price);

        public IReadOnlyCollection<IComponent> Components => components.AsReadOnly();

        public IReadOnlyCollection<IPeripheral> Peripherals => peripherals.AsReadOnly();

        public void AddComponent(IComponent component)
        {
            if (components.Any(x => x.GetType().Name == component.GetType().Name))
            {
                throw new ArgumentException($"Component {component.GetType().Name} already exists in {GetType().Name} with Id {Id}.");
            }

            components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (peripherals.Any(x => x.GetType().Name == peripheral.GetType().Name))
            {
                throw new ArgumentException($"Peripheral {peripheral.GetType().Name} already exists in {GetType().Name} with Id {Id}.");
            }

            peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            IComponent component = components.FirstOrDefault(x => x.GetType().Name == componentType);

            if (component == null)
            {
                throw new ArgumentException($"Component {componentType} does not exist in {GetType().Name} with Id {Id}.");
            }

            components.Remove(component);

            return component;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            IPeripheral peripheral = peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);

            if (peripheral == null)
            {
                throw new ArgumentException($"Peripheral {peripheralType} does not exist in {GetType().Name} with Id {Id}.");
            }

            peripherals.Remove(peripheral);

            return peripheral;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($" Components ({components.Count}):");

            foreach (var component in components)
            {
                sb.AppendLine(component.ToString());
            }

            sb.AppendLine($" Peripherals ({peripherals.Count}); Average Overall Performance ({peripherals.Average(x => x.OverallPerformance)}):");

            foreach (var peripheral in peripherals)
            {
                sb.AppendLine(peripheral.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
